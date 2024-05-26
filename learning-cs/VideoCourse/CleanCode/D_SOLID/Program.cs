namespace D_SOLID;

// DEPENDENCY INVERSION PRINCIPLE = DIP
/*
 * It says that higher lever classes should not depend on lower level classes.
 * Meaning that in a class you should not create an object of the lower class.
 */
class Program
{
    static void Main(string[] args)
    {
        Notification notification = new Notification(new EmailService());
        notification.Send("Test");
    }
}