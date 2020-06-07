using DndCharacterSheet.Views.CustomControls;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class Ability : ObservableObject
    {
        #region Constructor
        public Ability(string name = "", int baseScore=0)
        {
            this.ScoreModifiers = new List<AbilityModifier>();
            this.Name = name;
            this.BaseScore = baseScore;          
            this.AddModifier(this.BaseScore, this.GetBaseScoreModiferSource());
            this.ScoreUpdated();
        }
        #endregion
        #region Private Fields
        List<AbilityModifier> ScoreModifiers;
        #endregion
        #region Public Properties
        private string _Name;
        public string Name
        {
            get
            {
                return this._Name;
            }
            private set
            {
                this.Set(ref this._Name, value);
            }
        }

        private int _BaseScore;
        public int BaseScore
        {
            get
            {
                return this._BaseScore;
            }
            set
            {
                this.Set(ref this._BaseScore, value);
                this.UpdateBaseScore();
            }
        }
        public int TotalScore
        {
            get
            {
                return this.CalculateAbilityScore();
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
            AbilityModifier modifier = new AbilityModifier(value, source);
            this.ScoreModifiers.Add(modifier);
            this.ScoreUpdated();
            return success;
        }
        public bool RemoveModifier(string source)
        {
            AbilityModifier modifier = this.ScoreModifiers.FirstOrDefault(x => x.Source.Equals(source));
            if (modifier is null)
            {
                return false;
            }
            bool result = this.ScoreModifiers.Remove(modifier);
            this.ScoreUpdated();
            return result;
        }

        public bool UpdateModifier(int newValue, string source)
        {
            AbilityModifier modifier = this.ScoreModifiers.FirstOrDefault(x => x.Source.Equals(source));
            if (modifier is null)
            {
                return false;
            }
            modifier.Modifier = newValue;
            this.ScoreUpdated();
            return true;
        }
        #endregion
        #region Private Methods
        private int CalculateModifier()
        {
            return (int)Math.Floor((this.TotalScore - 10) / 2.0);
        }
        private int CalculateAbilityScore()
        {
            int totalScore = 0;
            foreach (AbilityModifier modifier in this.ScoreModifiers)
            {
                totalScore += modifier.Modifier;
            }
            return totalScore;
        }
        private string GetBaseScoreModiferSource()
        {
            return $"{this.Name} base score";
        }
        private void UpdateBaseScore()
        {
            AbilityModifier modifier = this.ScoreModifiers.FirstOrDefault(x => x.Source.Equals(this.GetBaseScoreModiferSource()));
            if (modifier is null)
            {
                return;
            }
            else
            {
                modifier.Modifier = this.BaseScore;
                this.ScoreUpdated();
            }
        }
        private void ScoreUpdated()
        {
            this.RaisePropertyChanged(nameof(this.TotalScore));
            this.RaisePropertyChanged(nameof(this.Modifier));
            this.RaisePropertyChanged(nameof(this.Description));
        }
        private string GetDescription()
        {
            string description = "";
            foreach (AbilityModifier modifier in this.ScoreModifiers)
            {
                description += $"{modifier.Modifier:+0;-0} from {modifier.Source}\n";
            }
            return description;
        }
        #endregion
        private class AbilityModifier : ObservableObject
        {
            public AbilityModifier(int value=0, string source="")
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
