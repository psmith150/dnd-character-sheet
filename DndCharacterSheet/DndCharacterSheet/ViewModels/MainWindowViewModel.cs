using System;
using System.Collections.Generic;
using System.Text;
using DndCharacterSheet.Services;
using GalaSoft.MvvmLight;

namespace DndCharacterSheet.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel(NavigationService navigation, SessionService session) : base(session)
        {
            this.NavigationService = navigation;
        }

        #region Public Properties
        private NavigationService _navigationService;
        public NavigationService NavigationService
        {
            get
            {
                return this._navigationService;
            }
            private set
            {
                this.Set(ref this._navigationService, value);
            }
        }
        #endregion
    }
}
