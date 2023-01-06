using System.Threading.Tasks;

namespace Hangfire.Web.Services.Email
{
    public interface IEmailSender
    {
        Task Sender(string userId, string message);
    }
}
