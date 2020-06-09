using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class PlayerBackground : ObservableObject
    {
        public PlayerBackground()
        {

        }
        #region Public Properties

        private string _Name;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.Set(ref this._Name, value);
            }
        }
        #endregion
    }
}
