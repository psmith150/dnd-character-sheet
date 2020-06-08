using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class SavingThrow : ObservableObject
    {
        #region Constructor
        public SavingThrow(Ability parentAbility)
        {
            this.Modifiers = new List<SavingThrowModifier>();
            this.Name = parentAbility.Name;
            this.ParentAbility = parentAbility;
            this.IsProficient = false;
            this.ProficiencyBonus = 0;
            this.ParentAbility.PropertyChanged += this.AbilityPropertyChanged;
        }
        #endregion
        #region Private Fields
        List<SavingThrowModifier> Modifiers;
        Ability ParentAbility;
        #endregion
        #region Public Properties
        private bool _IsProficient;
        public bool IsProficient
        {
            get
            {
                return this._IsProficient;
            }
            set
            {
                this.Set(ref this._IsProficient, value);
                this.ModifierUpdated();
            }
        }

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

        private int _ProficiencyBonus;
        public int ProficiencyBonus
        {
            get
            {
                return this._ProficiencyBonus;
            }
            set
            {
                this.Set(ref this._ProficiencyBonus, value);
                this.ModifierUpdated();
            }
        }
        public int Modifier
        {
            get
            {
                return this.CalculateModifier();
            }
        }
        public string Description
        {
            get
            {
                return this.GetDescription();
            }
        }
        #endregion
        #region Public Methods
        public bool AddModifier(int value, string source)
        {
            bool success = true;
            SavingThrowModifier modifier = new SavingThrowModifier(value, source);
            this.Modifiers.Add(modifier);
            this.ModifierUpdated();
            return success;
        }
        public bool RemoveModifier(string source)
        {
            SavingThrowModifier modifier = this.Modifiers.FirstOrDefault(x => x.Source.Equals(source));
            if (modifier is null)
            {
                return false;
            }
            bool result = this.Modifiers.Remove(modifier);
            this.ModifierUpdated();
            return result;
        }

        public bool UpdateModifier(int newValue, string source)
        {
            SavingThrowModifier modifier = this.Modifiers.FirstOrDefault(x => x.Source.Equals(source));
            if (modifier is null)
            {
                return false;
            }
            modifier.Modifier = newValue;
            this.ModifierUpdated();
            return true;
        }
        public void SetProficiencyBonus(int bonus)
        {

        }

        public void AbilityPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Ability ability)
            {
                if (e.PropertyName.Equals(nameof(Ability.Modifier)))
                {
                    this.ModifierUpdated();
                }
            }
        }
        #endregion
        #region Private Methods
        private int CalculateModifier()
        {
            int totalModifier = this.ParentAbility.Modifier;
            totalModifier += this.IsProficient ? this.ProficiencyBonus : 0;
            foreach (SavingThrowModifier modifier in this.Modifiers)
            {
                totalModifier += modifier.Modifier;
            }
            return totalModifier;
        }
        private string GetDescription()
        {
            string description = $"{this.ParentAbility.Modifier:+0;-0} from {this.ParentAbility.Name} ability\n";
            description += this.IsProficient ? $"{this.ProficiencyBonus:+0;-0} from {this.GetProficiencyBonusSource()}\n" : "";
            foreach (SavingThrowModifier modifier in this.Modifiers)
            {
                description += $"{modifier.Modifier:+0;-0} from {modifier.Source}\n";
            }
            description = description.Trim();
            return description;
        }
        private string GetProficiencyBonusSource()
        {
            return $"proficiency bonus";
        }
        private void ModifierUpdated()
        {
            this.RaisePropertyChanged(nameof(this.Modifier));
            this.RaisePropertyChanged(nameof(this.Description));
        }
        #endregion
        private class SavingThrowModifier : ObservableObject
        {
            public SavingThrowModifier(int value = 0, string source = "")
            {
                this.Modifier = value;
                this.Source = source;
            }
            private int _Modifier;
            public int Modifier
            {
                get
                {
                    return this._Modifier;
                }
                set
                {
                    this.Set(ref this._Modifier, value);
                }
            }

            private string _Source;
            public string Source
            {
                get
                {
                    return this._Source;
                }
                set
                {
                    this.Set(ref this._Source, value);
                }
            }
        }
    }
}
