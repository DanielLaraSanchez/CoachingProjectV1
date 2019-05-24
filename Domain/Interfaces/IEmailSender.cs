using System;
namespace Domain.Interfaces
{
    public interface IEmailSender
    {
         void SendEmail(Player player);
    }
}
