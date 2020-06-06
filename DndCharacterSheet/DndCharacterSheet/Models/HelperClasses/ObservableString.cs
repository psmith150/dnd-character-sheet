using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Models.HelperClasses
{
    public class ObservableString : ObservableObject
    {
        public ObservableString(string value = "")
        {
            this.Value = value;
        }

        private string _Value;
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.Set(ref this._Value, value);
            }
        }
    }
}
