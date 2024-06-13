namespace DelegateChallange01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailTask emailTask = new EmailTask();
            ReportTask reportTask = new ReportTask();

            TaskProcessor<EmailTask, string> taskProcessorEmail = new TaskProcessor<EmailTask, string>(emailTask);
            TaskProcessor<ReportTask, string> taskProcessorReportTask =
                new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(taskProcessorEmail.Execute());
            Console.WriteLine(taskProcessorReportTask.Execute());
        }
    }
}