using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

public class EmailSender
{
    private readonly IConfiguration _configuration;

    public EmailSender(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void SendEmail(string toEmail, string subject, string body)
    {
        var smtpSettings = _configuration.GetSection("SmtpSettings");

        var fromAddress = new MailAddress(smtpSettings["From"]);
        var toAddress = new MailAddress(toEmail);

        var smtp = new SmtpClient
        {
            Host = smtpSettings["Host"],
            Port = int.Parse(smtpSettings["Port"]),
            EnableSsl = bool.Parse(smtpSettings["EnableSsl"]),
            UseDefaultCredentials = bool.Parse(smtpSettings["DefaultCredentials"]),
            Credentials = new NetworkCredential(
                smtpSettings["Username"],
                smtpSettings["Password"]
            )
        };

        using (var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body,
            IsBodyHtml = false
        })
        {
            smtp.Send(message);
        }
    }
}
