using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Models.HelperClasses
{
    public class ObservableBool : ObservableObject
    {
        public ObservableBool(bool value=false)
        {
            this.Value = value;
        }

        private bool _Value;
        public bool Value
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
