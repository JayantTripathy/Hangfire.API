namespace Hangfire.API.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string backGroundJobType, string startTime)
        {
            Console.WriteLine(backGroundJobType + " - " + startTime + " - Email Sent - " + DateTime.Now.ToLongTimeString());
        }
    }
}
