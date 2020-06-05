using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Models.HelperClasses
{
    public class ObservableInt : ObservableObject
    {
        public ObservableInt(int value=0)
        {
            this.Value = value;
        }

        private int _Value;
        public int Value
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
