namespace D_SOLID;

public class Notification
{
    private readonly IEmailService _emailService;

    public Notification(EmailService emailService)
    {
        _emailService = emailService;
    }
    
    public void Send(string message)
    {
        _emailService.SendEmail("user@example.com", "Notification", message);
    }
}