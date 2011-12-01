using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.Views;

namespace Cirrious.MvvmCross.Console.Views
{
    public class MvxConsoleSystemMessageHandler
        : IMvxServiceConsumer<IMvxViewDispatcherProvider>
    {
        public bool ExitFlag { get; set; }

        private IMvxViewDispatcher ViewDispatcher { get { return this.GetService().Dispatcher; } }

        public virtual bool HandleInput(string input)
        {
            input = input.ToUpper();
            switch (input)
            {
                case "BACK":
                case "B":
                    ViewDispatcher.RequestNavigateBack();
                    return true;
                case "QUIT":
                case "Q":
                    ExitFlag = true;
                    return true;
            }

            return false;
        }
    }
}