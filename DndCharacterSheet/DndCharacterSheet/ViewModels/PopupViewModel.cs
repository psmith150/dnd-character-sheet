using DndCharacterSheet.Services;
using DndCharacterSheet.Views.Popups;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DndCharacterSheet.ViewModels
{
    public abstract class PopupViewModel : BaseViewModel
    {
        public event EventHandler<PopupEventArgs> Closed;

        public ICommand ClosePopupCommand { get; private set; }

        protected PopupViewModel(SessionService session) : base(session)
        {
            this.ClosePopupCommand = new RelayCommand(() => this.ClosePopup(null));
        }

        protected void ClosePopup(PopupEventArgs e)
        {
            this.Closed?.Invoke(this, e);
        }
        public abstract void Initialize(object param);
        public abstract void Deinitialize();
    }
}
