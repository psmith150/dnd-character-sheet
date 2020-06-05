﻿using GalaSoft.MvvmLight;
using DndCharacterSheet.Models.Enums;
using System.CodeDom;
using System;
using System.Collections.ObjectModel;
using DndCharacterSheet.Models.HelperClasses;
using System.Windows.Documents;
using System.ComponentModel;
using System.Linq;

namespace DndCharacterSheet.Models
{
    public class Character : ObservableObject
    {
        #region Constructor
        public Character()
        {
            this.HasInspiration = new ObservableBool(false);
            this.InitializeAbilities();
            this.InitializeSkills();
            this.MapSkillsToAbilities();
            this.PropertyChanged += this.PropertyChangedManager;
        }

        #endregion

        #region Private Fields
        private Ability[] SkillAbility;
        #endregion

        #region Public Properties
        #region General
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
        private int _ExperiencePoints;
        public int ExperiencePoints
        {
            get
            {
                return this._ExperiencePoints;
            }
            set
            {
                this.Set(ref this._ExperiencePoints, value);
            }
        }
        private PlayerRace _Race;
        public PlayerRace Race
        {
            get
            {
                return this._Race;
            }
            set
            {
                this.Set(ref this._Race, value);
            }
        }

        private ObservableBool _HasInspiration;
        public ObservableBool HasInspiration
        {
            get
            {
                return this._HasInspiration;
            }
            set
            {
                this.Set(ref this._HasInspiration, value);
            }
        }
        #endregion
        #region Hit Points
        private int _MaxHitPoints;
        public int MaxHitPoints
        {
            get
            {
                return this._MaxHitPoints;
            }
            private set
            {
                this.Set(ref this._MaxHitPoints, value);
            }
        }

        private int _CurrentHitPoints;
        public int CurrentHitPoints
        {
            get
            {
                return this._CurrentHitPoints;
            }
            set
            {
                this.Set(ref this._CurrentHitPoints, value);
            }
        }

        private int _EffectiveMaxHitpoints;
        public int EffectiveMaxHitpoints
        {
            get
            {
                return this._EffectiveMaxHitpoints;
            }
            private set
            {
                this.Set(ref this._EffectiveMaxHitpoints, value);
            }
        }

        private int _TemporaryHitPoints;
        public int TemporaryHitPoints
        {
            get
            {
                return this._TemporaryHitPoints;
            }
            set
            {
                this.Set(ref this._TemporaryHitPoints, value);
            }
        }
        #endregion
        #region Levelling
        public int ProficiencyBonus
        {
            get
            {
                return this.CalculateProficiencyBonus();
            }
        }
        public int TotalLevel
        {
            get
            {
                return this.CalculateTotalLevel();
            }
        }
        #endregion
        #region Abilities
        private ObservableCollectionAndMember<ObservableInt> _AbilityScores;
        public ObservableCollectionAndMember<ObservableInt> AbilityScores
        {
            get
            {
                return this._AbilityScores;
            }
            private set
            {
                this.Set(ref this._AbilityScores, value);
            }
        }

        private ObservableCollectionAndMember<ObservableInt> _AbilityModifiers;
        public ObservableCollectionAndMember<ObservableInt> AbilityModifiers
        {
            get
            {
                return this._AbilityModifiers;
            }
            private set
            {
                this.Set(ref this._AbilityModifiers, value);
            }
        }
        #endregion
        #region Skills
        private ObservableCollectionAndMember<ObservableInt> _SkillModifiers;
        public ObservableCollectionAndMember<ObservableInt> SkillModifiers
        {
            get
            {
                return this._SkillModifiers;
            }
            private set
            {
                this.Set(ref this._SkillModifiers, value);
            }
        }
        private ObservableCollectionAndMember<ObservableBool> _SkillProficiencies;
        public ObservableCollectionAndMember<ObservableBool> SkillProficiencies
        {
            get
            {
                return this._SkillProficiencies;
            }
            set
            {
                this.Set(ref this._SkillProficiencies, value);
            }
        }
        public int PassivePerception
        {
            get
            {
                return 10 + this.SkillModifiers[(int)Skill.Perception].Value;
            }
        }
        public int PassiveInvestigation
        {
            get
            {
                return 10 + this.SkillModifiers[(int)Skill.Investigation].Value;
            }
        }
        #endregion
        #region Saving Throws
        private ObservableCollectionAndMember<ObservableInt> _SavingThrowModifiers;
        public ObservableCollectionAndMember<ObservableInt> SavingThrowModifiers
        {
            get
            {
                return this._SavingThrowModifiers;
            }
            private set
            {
                this.Set(ref this._SavingThrowModifiers, value);
            }
        }
        private ObservableCollectionAndMember<ObservableBool> _SavingThrowProficiencies;
        public ObservableCollectionAndMember<ObservableBool> SavingThrowProficiencies
        {
            get
            {
                return this._SavingThrowProficiencies;
            }
            set
            {
                this.Set(ref this._SavingThrowProficiencies, value);
            }
        }
        #endregion
        #region Equipment

        #endregion
        #endregion

        #region Public Methods
        public void TakeShortRest()
        {

        }
        public void TakeLongRest()
        {

        }
        #endregion

        #region Private Methods
        private void MapSkillsToAbilities()
        {
            this.SkillAbility = new Ability[Enum.GetNames(typeof(Skill)).Length];
            this.SkillAbility[(int)Skill.Acrobatics] = Ability.Dexterity;
            this.SkillAbility[(int)Skill.AnimalHandling] = Ability.Wisdom;
            this.SkillAbility[(int)Skill.Arcana] = Ability.Intelligence;
            this.SkillAbility[(int)Skill.Athletics] = Ability.Strength;
            this.SkillAbility[(int)Skill.Deception] = Ability.Charisma;
            this.SkillAbility[(int)Skill.History] = Ability.Intelligence;
            this.SkillAbility[(int)Skill.Insight] = Ability.Wisdom;
            this.SkillAbility[(int)Skill.Intimidation] = Ability.Charisma;
            this.SkillAbility[(int)Skill.Investigation] = Ability.Intelligence;
            this.SkillAbility[(int)Skill.Medicine] = Ability.Wisdom;
            this.SkillAbility[(int)Skill.Nature] = Ability.Wisdom;
            this.SkillAbility[(int)Skill.Perception] = Ability.Wisdom;
            this.SkillAbility[(int)Skill.Performance] = Ability.Charisma;
            this.SkillAbility[(int)Skill.Persuasion] = Ability.Charisma;
            this.SkillAbility[(int)Skill.Religion] = Ability.Intelligence;
            this.SkillAbility[(int)Skill.SleightofHand] = Ability.Dexterity;
            this.SkillAbility[(int)Skill.Stealth] = Ability.Dexterity;
            this.SkillAbility[(int)Skill.Survival] = Ability.Wisdom;
        }
        private void InitializeAbilities()
        {
            this.AbilityScores = new ObservableCollectionAndMember<ObservableInt>();
            this.AbilityModifiers = new ObservableCollectionAndMember<ObservableInt>();
            this.SavingThrowModifiers = new ObservableCollectionAndMember<ObservableInt>();
            this.SavingThrowProficiencies = new ObservableCollectionAndMember<ObservableBool>();
            foreach (Ability ability in Enum.GetValues(typeof(Ability)))
            {
                ObservableInt abilityScore = new ObservableInt();
                abilityScore.PropertyChanged += this.AbilityScoreChanged;
                this.AbilityScores.Add(abilityScore);

                ObservableInt abilityModifier = new ObservableInt();
                abilityModifier.PropertyChanged += this.AbilityModifierChanged;
                this.AbilityModifiers.Add(abilityModifier);

                ObservableInt savingThrowModifier = new ObservableInt();
                this.SavingThrowModifiers.Add(savingThrowModifier);

                ObservableBool savingThrowProficiency = new ObservableBool();
                this.SavingThrowProficiencies.Add(savingThrowProficiency);
            }
        }
        private void InitializeSkills()
        {
            this.SkillProficiencies = new ObservableCollectionAndMember<ObservableBool>();
            this.SkillModifiers = new ObservableCollectionAndMember<ObservableInt>();
            foreach (Skill skill in Enum.GetValues(typeof(Skill)))
            {
                ObservableBool skillProficiency = new ObservableBool();
                this.SkillProficiencies.Add(skillProficiency);
                ObservableInt skillModifier = new ObservableInt();
                this.SkillModifiers.Add(skillModifier);
            }
        }
        private void SetAbilityModifier(Ability ability)
        {
            this.AbilityModifiers[(int)ability].Value = (int)Math.Floor((this.AbilityScores[(int)ability].Value - 10) / 2.0);
        }
        private void SetSkillModifier(Skill skill)
        {
            int modifier = this.AbilityModifiers[(int)this.SkillAbility[(int)skill]].Value;
            if (this.SkillProficiencies[(int)skill].Value)
                modifier += this.ProficiencyBonus;
            this.SkillModifiers[(int)skill].Value = modifier;
        }
        private void SetSavingThrowModifier(Ability ability)
        {
            int modifier = this.AbilityModifiers[(int)ability].Value;
            if (this.SavingThrowProficiencies[(int)ability].Value)
                modifier += this.ProficiencyBonus;
            this.SavingThrowModifiers[(int)ability].Value = modifier;
        }
        private int CalculateProficiencyBonus()
        {
            int bonus = 0;
            switch(this.TotalLevel)
            {
                case int level when (level > 0 && level <= 4):
                    bonus = 2;
                    break;
                case int level when (level > 4 && level <= 8):
                    bonus = 3;
                    break;
                case int level when (level > 8 && level <= 12):
                    bonus = 4;
                    break;
                case int level when (level > 12 && level <= 16):
                    bonus = 5;
                    break;
                case int level when (level > 16 && level <= 20):
                    bonus = 6;
                    break;
                default:
                    bonus = 0;
                    break;
            }
            return bonus;
        }
        private int CalculateTotalLevel()
        {
            int level = 0;
            return level;
        }
        private void UpdateProficiencyBonus()
        {
            this.RaisePropertyChanged(nameof(this.ProficiencyBonus));
        }
        private void UpdateProficiencies()
        {
            foreach (Skill skill in Enum.GetValues(typeof(Skill)).OfType<Skill>().Where(x => this.SkillProficiencies[(int)x].Value))
            {
                this.SetSkillModifier(skill);
            }
            foreach (Ability ability in Enum.GetValues(typeof(Ability)).OfType<Ability>().Where(x => this.SavingThrowProficiencies[(int)x].Value))
            {
                this.SetSavingThrowModifier(ability);
            }
        }
        private void PropertyChangedManager(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(this.ProficiencyBonus):
                    this.UpdateProficiencies();
                    break;
                default:
                    return;
            }
        }
        private void AbilityScoreChanged(object sender, PropertyChangedEventArgs e)
        {
            int index = this.AbilityScores.IndexOf(sender as ObservableInt);
            if (index == -1)
                return;
            this.SetAbilityModifier((Ability)index);
        }
        private void AbilityModifierChanged(object sender, PropertyChangedEventArgs e)
        {
            int index = this.AbilityModifiers.IndexOf(sender as ObservableInt);
            if (index == -1)
                return;
            foreach (Skill skill in this.SkillAbility.Where(x => x == (Ability)index))
            {
                this.SetSkillModifier(skill);
            }
        }
        #endregion
    }
}
