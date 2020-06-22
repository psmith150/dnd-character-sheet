using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class Spell : ObservableObject
    {
        #region Constructor
        public Spell(string name)
        {
            this.Damage = new ObservableCollectionAndMember<DamageDescription>();
        }
        #endregion
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
        private int _Level;
        public int Level
        {
            get
            {
                return this._Level;
            }
            set
            {
                this.Set(ref this._Level, value);
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.Set(ref this._Description, value);
            }
        }

        private bool _HasSavingThrow;
        public bool HasSavingThrow
        {
            get
            {
                return this._HasSavingThrow;
            }
            set
            {
                this.Set(ref this._HasSavingThrow, value);
            }
        }

        private Enums.Ability _SavingThrow;
        public Enums.Ability SavingThrow
        {
            get
            {
                return this._SavingThrow;
            }
            set
            {
                this.Set(ref this._SavingThrow, value);
            }
        }
        private bool _IsSpellAttack;
        public bool IsSpellAttack
        {
            get
            {
                return this._IsSpellAttack;
            }
            set
            {
                this.Set(ref this._IsSpellAttack, value);
            }
        }
        private ObservableCollectionAndMember<DamageDescription> _Damage;
        public ObservableCollectionAndMember<DamageDescription> Damage
        {
            get
            {
                return this._Damage;
            }
            private set
            {
                this.Set(ref this._Damage, value);
            }
        }
        public bool HasDamage
        {
            get
            {
                return this.Damage.Count > 0;
            }
        }

        private bool _HasVerbalComponent;
        public bool HasVerbalComponent
        {
            get
            {
                return this._HasVerbalComponent;
            }
            set
            {
                this.Set(ref this._HasVerbalComponent, value);
            }
        }

        private bool _HasSomaticComponent;
        public bool HasSomaticComponent
        {
            get
            {
                return this._HasSomaticComponent;
            }
            set
            {
                this.Set(ref this._HasSomaticComponent, value);
            }
        }

        private bool _HasMaterialComponent;
        public bool HasMaterialComponent
        {
            get
            {
                return this._HasMaterialComponent;
            }
            set
            {
                this.Set(ref this._HasMaterialComponent, value);
            }
        }

        private string _MaterialComponent;
        public string MaterialComponent
        {
            get
            {
                return this._MaterialComponent;
            }
            set
            {
                this.Set(ref this._MaterialComponent, value);
            }
        }

        private string _CastTime;
        public string CastTime
        {
            get
            {
                return this._CastTime;
            }
            set
            {
                this.Set(ref this._CastTime, value);
            }
        }

        private string _Range;
        public string Range
        {
            get
            {
                return this._Range;
            }
            set
            {
                this.Set(ref this._Range, value);
            }
        }

        private string _Duration;
        public string Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this.Set(ref this._Duration, value);
            }
        }
        #endregion
        #region Public Methods
        public override string ToString()
        {
            return this.Name;
        }
        #endregion
        #region Private Methods

        #endregion
    }

}
