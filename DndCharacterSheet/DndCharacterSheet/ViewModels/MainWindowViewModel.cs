using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DndCharacterSheet.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace DndCharacterSheet.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel(NavigationService navigation, SessionService session) : base(session)
        {
            this.NavigationService = navigation;

            // Set commands
            this.ToggleMenuCommand = new RelayCommand(() => this.SetMenuVisibility(!this.MenuVisible));

            // Set the starting page
            this.NavigationService.NavigateTo<CharacterScreenViewModel>();
        }
        #region Commands
        public ICommand ToggleMenuCommand { get; private set; }
        #endregion

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

        private bool _MenuVisible;
        public bool MenuVisible
        {
            get
            {
                return this._MenuVisible;
            }
            set
            {
                this.Set(ref this._MenuVisible, value);
            }
        }
        #endregion
        #region Private Methods
        private void SetMenuVisibility(bool show)
        {
            this.MenuVisible = show;
        }
        #endregion
    }
}
