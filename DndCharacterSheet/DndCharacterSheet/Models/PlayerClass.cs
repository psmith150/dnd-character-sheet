using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class PlayerClass : ObservableObject
    {
        public PlayerClass()
        {
            this.CantripsKnown = new int[Constants.MAX_LEVEL - 1];
            this.SpellSlots = new int[Constants.MAX_LEVEL - 1, Constants.MAX_SPELL_LEVEL];
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

        private Enums.Dice _HitDice;
        public Enums.Dice HitDice
        {
            get
            {
                return this._HitDice;
            }
            set
            {
                this.Set(ref this._HitDice, value);
            }
        }

        private ObservableCollection<Enums.ArmorType> _ArmorProficiencies;
        public ObservableCollection<Enums.ArmorType> ArmorProficiencies
        {
            get
            {
                return this._ArmorProficiencies;
            }
            private set
            {
                this.Set(ref this._ArmorProficiencies, value);
            }
        }

        private ObservableCollection<Enums.WeaponCategory> _WeaponProficiencies;
        public ObservableCollection<Enums.WeaponCategory> WeaponProficiencies
        {
            get
            {
                return this._WeaponProficiencies;
            }
            private set
            {
                this.Set(ref this._WeaponProficiencies, value);
            }
        }

        private ObservableCollection<string> _ToolProficiencies;
        public ObservableCollection<string> ToolProficiencies
        {
            get
            {
                return this._ToolProficiencies;
            }
            private set
            {
                this.Set(ref this._ToolProficiencies, value);
            }
        }

        private ObservableCollection<Enums.Ability> _SavingThrowProficiencies;
        public ObservableCollection<Enums.Ability> SavingThrowProficiencies
        {
            get
            {
                return this._SavingThrowProficiencies;
            }
            private set
            {
                this.Set(ref this._SavingThrowProficiencies, value);
            }
        }

        private ObservableCollection<Enums.Skill> _SkillProficiencies;
        public ObservableCollection<Enums.Skill> SkillProficiencies
        {
            get
            {
                return this._SkillProficiencies;
            }
            private set
            {
                this.Set(ref this._SkillProficiencies, value);
            }
        }

        private ObservableCollection<Enums.Skill> _SkillProficiencyChoiceOptions;
        public ObservableCollection<Enums.Skill> SkillProficiencyChoiceOptions
        {
            get
            {
                return this._SkillProficiencyChoiceOptions;
            }
            private set
            {
                this.Set(ref this._SkillProficiencyChoiceOptions, value);
            }
        }

        private int _SkillProficiencyChoices;
        public int SkillProficiencyChoices
        {
            get
            {
                return this._SkillProficiencyChoices;
            }
            set
            {
                this.Set(ref this._SkillProficiencyChoices, value);
            }
        }
        #region Spells

        private bool _HasSpells;
        public bool HasSpells
        {
            get
            {
                return this._HasSpells;
            }
            set
            {
                this.Set(ref this._HasSpells, value);
            }
        }

        private Enums.Ability _SpellAbility;
        public Enums.Ability SpellAbility
        {
            get
            {
                return this._SpellAbility;
            }
            set
            {
                this.Set(ref this._SpellAbility, value);
            }
        }

        private ObservableCollectionAndMember<Spell> _SpellList;
        public ObservableCollectionAndMember<Spell> SpellList
        {
            get
            {
                return this._SpellList;
            }
            private set
            {
                this.Set(ref this._SpellList, value);
            }
        }

        private ObservableCollectionAndMember<Spell> _SpellsKnown;
        public ObservableCollectionAndMember<Spell> SpellsKnown
        {
            get
            {
                return this._SpellsKnown;
            }
            set
            {
                this.Set(ref this._SpellsKnown, value);
            }
        }

        private ObservableCollectionAndMember<Spell> _SpellsPrepared;
        public ObservableCollectionAndMember<Spell> SpellsPrepared
        {
            get
            {
                return this._SpellsPrepared;
            }
            set
            {
                this.Set(ref this._SpellsPrepared, value);
            }
        }

        private int[] _CantripsKnown;
        public int[] CantripsKnown
        {
            get
            {
                return this._CantripsKnown;
            }
            set
            {
                this.Set(ref this._CantripsKnown, value);
            }
        }

        private int[,] _SpellSlots;
        public int[,] SpellSlots
        {
            get
            {
                return this._SpellSlots;
            }
            set
            {
                this.Set(ref this._SpellSlots, value);
            }
        }

        private bool _SpellSlotsRegainedOnShortRest;
        public bool SpellSlotsRegainedOnShortRest
        {
            get
            {
                return this._SpellSlotsRegainedOnShortRest;
            }
            set
            {
                this.Set(ref this._SpellSlotsRegainedOnShortRest, value);
            }
        }
        #endregion
        #endregion
        #region Private Fields
        #endregion
    }
}
