using DndCharacterSheet.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows.Input;

namespace DndCharacterSheet.ViewModels
{
    public class TextListEditViewModel : PopupViewModel
    {
        public TextListEditViewModel(SessionService session) : base(session)
        {
            // Set Commands
            this.ExitPopupCommand = new RelayCommand(() => this.Exit());
            this.SaveCommand = new RelayCommand(() => this.Save());
        }
        #region Commands
        public ICommand ExitPopupCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }
        #endregion
        #region Private Fields
        private ICollection<string> StringValues;
        private bool SavingNeeded = false;
        #endregion

        #region Inherited Methods
        public override void Deinitialize()
        {

        }

        public override void Initialize(object param)
        {
            if (param is ICollection<string> strings)
            {
                this.StringValues = strings;
                this.CollectionToText();
                this.SavingNeeded = false;
            }
            else
            {
                throw new ArgumentException("Parameter is not of type ICollection<string>");
            }
        } 
        #endregion
        #region Public Properties
        private string _Text;
        public string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                this.Set(ref this._Text, value);
                this.SavingNeeded = true;
            }
        }
        #endregion
        #region Public Methods

        #endregion
        #region Private Methods
        private void Save()
        {
            this.TextToCollection();
            this.ClosePopup(null);
        }
        private void Exit()
        {
            this.ClosePopup(null);
        }
        private void CollectionToText()
        {
            string text = "";
            foreach (string str in this.StringValues)
            {
                text += str + "\n";
            }
            text = text.Trim();
            this.Text = text;
        }
        private void TextToCollection()
        {
            var strings = Text.Split("\n");
            this.StringValues.Clear();
            foreach (string str in strings)
            {
                this.StringValues.Add(str);
            }
        }
        #endregion
    }
}
