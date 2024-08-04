namespace CustomEventArguments;

public class CarEventsArgs : EventArgs
{
    public readonly string msg;

    public CarEventsArgs(string message)
    {
        msg = message;
    }
}