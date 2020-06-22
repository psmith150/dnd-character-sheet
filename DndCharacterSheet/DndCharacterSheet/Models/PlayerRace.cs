using DndCharacterSheet.Models.Enums;
using DndCharacterSheet.Models.HelperClasses;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Permissions;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class PlayerRace : ObservableObject
    {
        public PlayerRace()
        {

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
        private ObservableCollectionAndMember<ObservableInt> _AbilityScoreModifiers;
        public ObservableCollectionAndMember<ObservableInt> AbilityScoreModifiers
        {
            get
            {
                return this._AbilityScoreModifiers;
            }
            set
            {
                this.Set(ref this._AbilityScoreModifiers, value);
            }
        }

        private ObservableInt _Speed;
        public ObservableInt Speed
        {
            get
            {
                return this._Speed;
            }
            set
            {
                this.Set(ref this._Speed, value);
            }
        }

        private ObservableCollectionAndMember<ObservableString> _Languages;
        public ObservableCollectionAndMember<ObservableString> Languages
        {
            get
            {
                return this._Languages;
            }
            set
            {
                this.Set(ref this._Languages, value);
            }
        }

        private ObservableCollection<Enums.WeaponCategory> _WeaponProficiencies;
        public ObservableCollection<Enums.WeaponCategory> WeaponProficiencies
        {
            get
            {
                return this._WeaponProficiencies;
            }
            set
            {
                this.Set(ref this._WeaponProficiencies, value);
            }
        }

        private ObservableCollection<Enums.ArmorType> _ArmorProficiencies;
        public ObservableCollection<Enums.ArmorType> ArmorProficiencies
        {
            get
            {
                return this._ArmorProficiencies;
            }
            set
            {
                this.Set(ref this._ArmorProficiencies, value);
            }
        }

        private ObservableCollection<Enums.Skill> _Proficiencies;
        public ObservableCollection<Enums.Skill> Proficiencies
        {
            get
            {
                return this._Proficiencies;
            }
            set
            {
                this.Set(ref this._Proficiencies, value);
            }
        }


        private Size _Size;
        public Size Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this.Set(ref this._Size, value);
            }
        }

        private string _Aging;
        public string Aging
        {
            get
            {
                return this._Aging;
            }
            set
            {
                this.Set(ref this._Aging, value);
            }
        }

        private string _Alignment;
        public string Alignment
        {
            get
            {
                return this._Alignment;
            }
            set
            {
                this.Set(ref this._Alignment, value);
            }
        }
        #endregion
    }
}
