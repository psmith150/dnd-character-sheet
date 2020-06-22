using DndCharacterSheet.Models.Enums;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class DamageDescription : ObservableObject
    {
        #region Constructor
        public DamageDescription(int numberOfDie=0, Dice dieType=Dice.d20, int modifier = 0, DamageType damageType = DamageType.Bludgeoning)
        {
            this.NumberOfDie = numberOfDie;
            this.DieType = dieType;
            this.StaticModifier = modifier;
            this.DamageType = damageType;
        }
        #endregion
        #region Public Properties

        private int _NumberOfDie;
        public int NumberOfDie
        {
            get
            {
                return this._NumberOfDie;
            }
            set
            {
                this.Set(ref this._NumberOfDie, value);
            }
        }

        private Dice _DieType;
        public Dice DieType
        {
            get
            {
                return this._DieType;
            }
            set
            {
                this.Set(ref this._DieType, value);
            }
        }

        private int _StaticModifier;
        public int StaticModifier
        {
            get
            {
                return this._StaticModifier;
            }
            set
            {
                this.Set(ref this._StaticModifier, value);
            }
        }

        private DamageType _DamageType;
        public DamageType DamageType
        {
            get
            {
                return this._DamageType;
            }
            set
            {
                this.Set(ref this._DamageType, value);
            }
        }
        #endregion
        #region Public Methods
        public override string ToString()
        {
            return $"{this.NumberOfDie}{this.DieType.GetDescription()}" + (this.StaticModifier == 0 ? "" : $" + {this.StaticModifier}") + $" {this.DamageType.GetDescription()} damage.";
        }
        #endregion
    }
}
