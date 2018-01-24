using System.Threading.Tasks;

namespace Neutronium.ReactiveTrader.Client.Application.WindowServices {
    public interface IMessageBox {
        Task<bool> ShowMessage(ConfirmationMessage confirmationMessage);

        void ShowInformation(MessageInformation messageInformation);
    }
}