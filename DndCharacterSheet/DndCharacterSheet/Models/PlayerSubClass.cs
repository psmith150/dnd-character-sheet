using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class PlayerSubClass : ObservableObject
    {
        public PlayerSubClass(PlayerClass parentClass)
        {
            this.ParentClass = parentClass;
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

        private PlayerClass _ParentClass;
        public PlayerClass ParentClass
        {
            get
            {
                return this._ParentClass;
            }
            private set
            {
                this.Set(ref this._ParentClass, value);
            }
        }
        #endregion
    }
}
