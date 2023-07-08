namespace Hangfire.API.Services
{
    public interface IEmailService
    {
        void SendEmail(string backGroundJobType, string startTime);
    }
}
