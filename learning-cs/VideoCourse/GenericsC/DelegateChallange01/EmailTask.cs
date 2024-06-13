namespace DelegateChallange01
{
    internal class EmailTask : ITask<string>
    {
        private string Recipient { get; set; } = "aldair@azgcloudev.xyz";
        private string Message { get; set; } = "Test message";

        public string Perform()
        {
            return $"Email sent to {Recipient}, with message {Message}";
        }
    }
}