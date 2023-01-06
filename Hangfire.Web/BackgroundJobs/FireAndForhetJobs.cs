using Hangfire.Web.Services.Email;

namespace Hangfire.Web.BackgroundJobs
{
    public class FireAndForhetJobs
    {
        public static void EmailSendToUserJob(string userId, string message)
        {
            BackgroundJob.Enqueue<IEmailSender>(x => x.Sender(userId, message));
        }
    }
}
