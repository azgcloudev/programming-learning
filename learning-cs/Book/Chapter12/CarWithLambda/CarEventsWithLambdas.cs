namespace CarWithLambda
{
    internal class CarEventsWithLambdas : EventArgs
    {
        public readonly string msg;
        public CarEventsWithLambdas(string message)
        {
            msg = message;
        }
    }
}
