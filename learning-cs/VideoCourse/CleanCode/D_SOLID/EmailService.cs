namespace D_SOLID;

public class EmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Sending email to {to} with subject {subject}, and body: {body}");
    }
}