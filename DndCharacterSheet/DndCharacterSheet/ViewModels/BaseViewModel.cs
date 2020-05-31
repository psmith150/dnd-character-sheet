using DndCharacterSheet.Services;
using GalaSoft.MvvmLight;
using System.Diagnostics.Contracts;
using System.Reflection;

namespace DndCharacterSheet.ViewModels
{
    public class BaseViewModel : ViewModelBase
    {
        protected BaseViewModel(SessionService session)
        {
            this.Session = session;
        }

        private SessionService _Session;
        public SessionService Session
        {
            get
            {
                return this._Session;
            }
            private set
            {
                this.Set(ref this._Session, value);
            }
        }

        public string AppVersion
        {
            get
            {
                return Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
        }
    }
}
