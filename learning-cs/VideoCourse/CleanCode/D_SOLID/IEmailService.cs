namespace D_SOLID;

public interface IEmailService
{
    public void SendEmail(string to, string subject, string body);
}