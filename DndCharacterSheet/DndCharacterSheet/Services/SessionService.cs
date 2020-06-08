using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Services
{
    public class SessionService : ObservableObject
    {
        public SessionService()
        {

        }
        #region Public Properties

        private bool _IsBusy;
        public bool IsBusy
        {
            get
            {
                return this._IsBusy;
            }
            set
            {
                this.Set(ref this._IsBusy, value);
            }
        }

        private string _BusyTitle;
        public string BusyTitle
        {
            get
            {
                return this._BusyTitle;
            }
            set
            {
                this.Set(ref this._BusyTitle, value);
            }
        }
        private string _BusyMessage;
        public string BusyMessage
        {
            get
            {
                return this._BusyMessage;
            }
            set
            {
                this.Set(ref this._BusyMessage, value);
            }
        }
        #endregion
    }
}
