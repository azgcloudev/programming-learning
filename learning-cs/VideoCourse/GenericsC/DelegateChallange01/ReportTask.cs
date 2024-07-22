namespace DelegateChallange01
{
    internal class ReportTask : ITask<string>
    {
        private string ReportName { get; set; } = "The reporting";

        public string Perform()
        {
            return $"[{ReportName}]: random text";
        }
    }
}