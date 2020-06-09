using GalaSoft.MvvmLight;
using DndCharacterSheet.Models.Enums;
using System.CodeDom;
using System;
using System.Collections.ObjectModel;
using DndCharacterSheet.Models.HelperClasses;
using System.Windows.Documents;
using System.ComponentModel;
using System.Linq;
using System.Windows.Media.Imaging;

namespace DndCharacterSheet.Models
{
    public class Character : ObservableObject
    {
        #region Constructor
        public Character()
        {
            this.MapSkillsToAbilities();
            this.InitializeAbilities();
            this.InitializeSkills();

            this.HasInspiration = new ObservableBool(false);
            this.PersonalityTraits = new ObservableCollection<string>();
            this.Ideals = new ObservableCollection<string>();
            this.Bonds = new ObservableCollection<string>();
            this.Flaws = new ObservableCollection<string>();
            this.AlliesAndOrganizations = new ObservableCollection<string>();
            this.AdditionalFeatures = new ObservableCollectionAndMember<ObservableString>();
            this.Treasure = new ObservableCollection<string>();
            this.Languages = new ObservableCollection<string>();
            this.OtherProficiencies = new ObservableCollection<string>();
            this.Equipment = new ObservableCollectionAndMember<Item>();
            this.EquippedItems = new ObservableCollectionAndMember<Item>();
            this.EquippedWeapons = new ObservableCollectionAndMember<Weapon>();
            this.Features = new ObservableCollectionAndMember<ObservableString>();
            this.PropertyChanged += this.PropertyChangedManager;
        }

        #endregion

        #region Private Fields
        private Enums.Ability[] SkillAbility;
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

        private PlayerSubRace _SubRace;
        public PlayerSubRace SubRace
        {
            get
            {
                return this._SubRace;
            }
            set
            {
                this.Set(ref this._SubRace, value);
            }
        }
        public string RaceString
        {
            get
            {
                return this.FormatRaceString();
            }
        }

        private PlayerClass _Class;
        public PlayerClass Class
        {
            get
            {
                return this._Class;
            }
            set
            {
                this.Set(ref this._Class, value);
            }
        }

        private PlayerSubClass _SubClass;
        public PlayerSubClass SubClass
        {
            get
            {
                return this._SubClass;
            }
            set
            {
                this.Set(ref this._SubClass, value);
            }
        }
        public string ClassAndLevelString
        {
            get
            {
                return this.FormatClassAndLevelString();
            }
        }

        private Alignment _Alignment;
        public Alignment Alignment
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

        private PlayerBackground _Background;
        public PlayerBackground Background
        {
            get
            {
                return this._Background;
            }
            set
            {
                this.Set(ref this._Background, value);
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

        private int _ArmorClass;
        public int ArmorClass
        {
            get
            {
                return this._ArmorClass;
            }
            set
            {
                this.Set(ref this._ArmorClass, value);
            }
        }


        private int _Speed;
        public int Speed
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

        private int _DeathSaveSuccesses;
        public int DeathSaveSuccesses
        {
            get
            {
                return this._DeathSaveSuccesses;
            }
            set
            {
                this.Set(ref this._DeathSaveSuccesses, value);
            }
        }

        private int _DeathSaveFailures;
        public int DeathSaveFailures
        {
            get
            {
                return this._DeathSaveFailures;
            }
            set
            {
                this.Set(ref this._DeathSaveFailures, value);
            }
        }
        #endregion
        #region Character Attributes
        private ObservableCollection<string> _PersonalityTraits;
        public ObservableCollection<string> PersonalityTraits
        {
            get
            {
                return this._PersonalityTraits;
            }
            set
            {
                this.Set(ref this._PersonalityTraits, value);
            }
        }

        private ObservableCollection<string> _Ideals;
        public ObservableCollection<string> Ideals
        {
            get
            {
                return this._Ideals;
            }
            set
            {
                this.Set(ref this._Ideals, value);
            }
        }

        private ObservableCollection<string> _Bonds;
        public ObservableCollection<string> Bonds
        {
            get
            {
                return this._Bonds;
            }
            set
            {
                this.Set(ref this._Bonds, value);
            }
        }

        private ObservableCollection<string> _Flaws;
        public ObservableCollection<string> Flaws
        {
            get
            {
                return this._Flaws;
            }
            set
            {
                this.Set(ref this._Flaws, value);
            }
        }

        private int _Age;
        public int Age
        {
            get
            {
                return this._Age;
            }
            set
            {
                this.Set(ref this._Age, value);
            }
        }

        private int _Height;
        public int Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this.Set(ref this._Height, value);
            }
        }

        private int _Weight;
        public int Weight
        {
            get
            {
                return this._Weight;
            }
            set
            {
                this.Set(ref this._Weight, value);
            }
        }

        private string _EyeColor;
        public string EyeColor
        {
            get
            {
                return this._EyeColor;
            }
            set
            {
                this.Set(ref this._EyeColor, value);
            }
        }

        private string _SkinTone;
        public string SkinTone
        {
            get
            {
                return this._SkinTone;
            }
            set
            {
                this.Set(ref this._SkinTone, value);
            }
        }

        private string _Hair;
        public string Hair
        {
            get
            {
                return this._Hair;
            }
            set
            {
                this.Set(ref this._Hair, value);
            }
        }

        private string _Appearance;
        public string Appearance
        {
            get
            {
                return this._Appearance;
            }
            set
            {
                this.Set(ref this._Appearance, value);
            }
        }

        private BitmapImage _Image;
        public BitmapImage Image
        {
            get
            {
                return this._Image;
            }
            set
            {
                this.Set(ref this._Image, value);
            }
        }

        private string _Backstory;
        public string Backstory
        {
            get
            {
                return this._Backstory;
            }
            set
            {
                this.Set(ref this._Backstory, value);
            }
        }

        private ObservableCollection<string> _AlliesAndOrganizations;
        public ObservableCollection<string> AlliesAndOrganizations
        {
            get
            {
                return this._AlliesAndOrganizations;
            }
            set
            {
                this.Set(ref this._AlliesAndOrganizations, value);
            }
        }

        private ObservableCollectionAndMember<ObservableString> _AdditionalFeatures;
        public ObservableCollectionAndMember<ObservableString> AdditionalFeatures
        {
            get
            {
                return this._AdditionalFeatures;
            }
            set
            {
                this.Set(ref this._AdditionalFeatures, value);
            }
        }

        private ObservableCollection<string> _Treasure;
        public ObservableCollection<string> Treasure
        {
            get
            {
                return this._Treasure;
            }
            set
            {
                this.Set(ref this._Treasure, value);
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
        private ObservableCollectionAndMember<Ability> _Abilities;
        public ObservableCollectionAndMember<Ability> Abilities
        {
            get
            {
                return this._Abilities;
            }
            private set
            {
                this.Set(ref this._Abilities, value);
            }
        }
        #endregion
        #region Skills
        private ObservableCollectionAndMember<Skill> _Skills;
        public ObservableCollectionAndMember<Skill> Skills
        {
            get
            {
                return this._Skills;
            }
            private set
            {
                this.Set(ref this._Skills, value);
            }
        }
        public int PassivePerception
        {
            get
            {
                return 10 + this.Skills[(int)Enums.Skill.Perception].Modifier;
            }
        }
        public int PassiveInvestigation
        {
            get
            {
                return 10 + this.Skills[(int)Enums.Skill.Investigation].Modifier;
            }
        }

        public int Initiative
        {
            get
            {
                return this.Abilities[(int)Enums.Ability.Dexterity].Modifier;
            }
        }
        #endregion
        #region Saving Throws
        private ObservableCollectionAndMember<SavingThrow> _SavingThrows;
        public ObservableCollectionAndMember<SavingThrow> SavingThrows
        {
            get
            {
                return this._SavingThrows;
            }
            private set
            {
                this.Set(ref this._SavingThrows, value);
            }
        }
        #endregion
        #region Other Proficiencies
        private ObservableCollection<string> _Languages;
        public ObservableCollection<string> Languages
        {
            get
            {
                return this._Languages;
            }
            private set
            {
                this.Set(ref this._Languages, value);
                this.Languages.CollectionChanged += (sender, args) => this.RaisePropertyChanged(nameof(this.LanguagesString));
            }
        }
        public string LanguagesString
        {
            get
            {
                return this.FormatLanguageString();
            }
        }

        private ObservableCollection<string> _OtherProficiencies;
        public ObservableCollection<string> OtherProficiencies
        {
            get
            {
                return this._OtherProficiencies;
            }
            private set
            {
                this.Set(ref this._OtherProficiencies, value);
            }
        }
        #endregion
        #region Equipment

        private ObservableCollectionAndMember<Item> _Equipment;
        public ObservableCollectionAndMember<Item> Equipment
        {
            get
            {
                return this._Equipment;
            }
            set
            {
                this.Set(ref this._Equipment, value);
            }
        }

        private ObservableCollectionAndMember<Item> _EquippedItems;
        public ObservableCollectionAndMember<Item> EquippedItems
        {
            get
            {
                return this._EquippedItems;
            }
            set
            {
                this.Set(ref this._EquippedItems, value);
            }
        }

        private ObservableCollectionAndMember<Weapon> _EquippedWeapons;
        public ObservableCollectionAndMember<Weapon> EquippedWeapons
        {
            get
            {
                return this._EquippedWeapons;
            }
            set
            {
                this.Set(ref this._EquippedWeapons, value);
            }
        }

        private int _CopperPieces;
        public int CopperPieces
        {
            get
            {
                return this._CopperPieces;
            }
            set
            {
                this.Set(ref this._CopperPieces, value);
            }
        }

        private int _SilverPieces;
        public int SilverPieces
        {
            get
            {
                return this._SilverPieces;
            }
            set
            {
                this.Set(ref this._SilverPieces, value);
            }
        }

        private int _ElectrumPieces;
        public int ElectrumPieces
        {
            get
            {
                return this._ElectrumPieces;
            }
            set
            {
                this.Set(ref this._ElectrumPieces, value);
            }
        }

        private int _GoldPieces;
        public int GoldPieces
        {
            get
            {
                return this._GoldPieces;
            }
            set
            {
                this.Set(ref this._GoldPieces, value);
            }
        }

        private int _PlatinumPieces;
        public int PlatinumPieces
        {
            get
            {
                return this._PlatinumPieces;
            }
            set
            {
                this.Set(ref this._PlatinumPieces, value);
            }
        }
        #endregion
        #region Features and Traits

        private ObservableCollectionAndMember<ObservableString> _Features;
        public ObservableCollectionAndMember<ObservableString> Features
        {
            get
            {
                return this._Features;
            }
            set
            {
                this.Set(ref this._Features, value);
            }
        }
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
            this.SkillAbility = new Enums.Ability[Enum.GetNames(typeof(Enums.Skill)).Length];
            this.SkillAbility[(int)Enums.Skill.Acrobatics] = Enums.Ability.Dexterity;
            this.SkillAbility[(int)Enums.Skill.AnimalHandling] = Enums.Ability.Wisdom;
            this.SkillAbility[(int)Enums.Skill.Arcana] = Enums.Ability.Intelligence;
            this.SkillAbility[(int)Enums.Skill.Athletics] = Enums.Ability.Strength;
            this.SkillAbility[(int)Enums.Skill.Deception] = Enums.Ability.Charisma;
            this.SkillAbility[(int)Enums.Skill.History] = Enums.Ability.Intelligence;
            this.SkillAbility[(int)Enums.Skill.Insight] = Enums.Ability.Wisdom;
            this.SkillAbility[(int)Enums.Skill.Intimidation] = Enums.Ability.Charisma;
            this.SkillAbility[(int)Enums.Skill.Investigation] = Enums.Ability.Intelligence;
            this.SkillAbility[(int)Enums.Skill.Medicine] = Enums.Ability.Wisdom;
            this.SkillAbility[(int)Enums.Skill.Nature] = Enums.Ability.Wisdom;
            this.SkillAbility[(int)Enums.Skill.Perception] = Enums.Ability.Wisdom;
            this.SkillAbility[(int)Enums.Skill.Performance] = Enums.Ability.Charisma;
            this.SkillAbility[(int)Enums.Skill.Persuasion] = Enums.Ability.Charisma;
            this.SkillAbility[(int)Enums.Skill.Religion] = Enums.Ability.Intelligence;
            this.SkillAbility[(int)Enums.Skill.SleightofHand] = Enums.Ability.Dexterity;
            this.SkillAbility[(int)Enums.Skill.Stealth] = Enums.Ability.Dexterity;
            this.SkillAbility[(int)Enums.Skill.Survival] = Enums.Ability.Wisdom;
        }
        private void InitializeAbilities()
        {
            this.Abilities = new ObservableCollectionAndMember<Ability>();
            this.SavingThrows = new ObservableCollectionAndMember<SavingThrow>();
            foreach (Enums.Ability ability in Enum.GetValues(typeof(Enums.Ability)))
            {
                Ability newAbility = new Ability(ability.GetDescription());
                if (ability == Enums.Ability.Dexterity)
                {
                    newAbility.PropertyChanged += this.DexterityChanged;
                }
                this.Abilities.Add(newAbility);

                SavingThrow savingThrow = new SavingThrow(newAbility);
                savingThrow.ProficiencyBonus = this.ProficiencyBonus;
                this.SavingThrows.Add(savingThrow);
            }
        }
        private void InitializeSkills()
        {
            this.Skills = new ObservableCollectionAndMember<Skill>();
            foreach (Enums.Skill skill in Enum.GetValues(typeof(Enums.Skill)))
            {
                int index = (int)this.SkillAbility[(int)skill];
                Skill newSkill = new Skill(this.Abilities[index], skill.GetDescription());
                if (skill == Enums.Skill.Investigation)
                {
                    newSkill.PropertyChanged += this.InvestigationChanged;
                }
                else if (skill == Enums.Skill.Perception)
                {
                    newSkill.PropertyChanged += this.PerceptionChanged;
                }
                newSkill.ProficiencyBonus = this.ProficiencyBonus;
                this.Skills.Add(newSkill);
            }
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
        //TODO: implement CalculateTotalLevel()
        private int CalculateTotalLevel()
        {
            int level = 0;
            return level;
        }
        //TODO: Call on level up
        private void UpdateProficiencyBonus()
        {
            this.RaisePropertyChanged(nameof(this.ProficiencyBonus));
            this.UpdateProficiencies();
        }
        private void UpdateProficiencies()
        {
            int bonus = this.CalculateProficiencyBonus();
            // Update saving throws
            foreach (SavingThrow savingThrow in this.SavingThrows)
            {
                savingThrow.ProficiencyBonus = bonus;
            }
            // Update skills
            foreach (Skill skill in this.Skills)
            {
                skill.ProficiencyBonus = bonus;
            }
        }
        private void PerceptionChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Skill skill)
            {
                if (e.PropertyName.Equals(nameof(Skill.Modifier)))
                {
                    this.RaisePropertyChanged(nameof(this.PassivePerception));

                }
            }
        }
        private void InvestigationChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(nameof(Skill.Modifier)))
            {
                this.RaisePropertyChanged(nameof(this.PassiveInvestigation));

            }
        }
        private void DexterityChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Ability ability)
            {
                this.RaisePropertyChanged(nameof(this.Initiative));
            }
        }
        private string FormatRaceString()
        {
            if (this.Race is null)
                return "None";
            string race = this.Race.Name;
            if (!(this.SubRace is null))
                race += ", " + this.SubRace.Name;
            return race;
        }
        private string FormatClassAndLevelString()
        {
            if (this.Class is null)
                return "None";
            string classAndLevel = this.Class.Name;
            if (!(this.SubClass is null))
                classAndLevel += "(" + this.SubRace.Name + ")";
            return classAndLevel;
        }
        private string FormatLanguageString()
        {
            string languages = "Languages: ";
            if (this.Languages is null || this.Languages.Count <= 0)
            {
                languages += "None";
            }
            else
            {
                for(int index = 0; index < this.Languages.Count; index++)
                {
                    languages += this.Languages[index];
                    if (index < this.Languages.Count - 1)
                    {
                        languages += ", ";
                    }
                }
            }
            return languages;
        }
        private void PropertyChangedManager(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(this.ProficiencyBonus):
                    this.UpdateProficiencies();
                    break;
                case nameof(this.Race):
                case nameof(this.SubRace):
                    if (e.PropertyName.Equals(nameof(Race.Name)) || e.PropertyName.Equals(nameof(SubRace.Name)))
                    {
                        this.RaisePropertyChanged(nameof(this.RaceString));
                    }
                    break;
                case nameof(this.Class):
                case nameof(this.SubClass):
                    if (e.PropertyName.Equals(nameof(Class.Name)) || e.PropertyName.Equals(nameof(SubClass.Name)))
                    {
                        this.RaisePropertyChanged(nameof(this.ClassAndLevelString));
                    }
                    break;
                default:
                    return;
            }
        }
        #endregion
    }
}
