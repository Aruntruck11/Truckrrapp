using Truckrrapp.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace Truckrrapp.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}