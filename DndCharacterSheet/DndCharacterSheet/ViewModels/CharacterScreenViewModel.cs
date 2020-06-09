using DndCharacterSheet.Models;
using DndCharacterSheet.Models.Enums;
using DndCharacterSheet.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using DndCharacterSheet.Models.HelperClasses;

namespace DndCharacterSheet.ViewModels
{
    public class CharacterScreenViewModel : ScreenViewModel
    {
        #region Constants
        private const int SUBSCREEN_OVERVIEW = 1;
        private const int SUBSCREEN_CHARACTERDETAILS = 2;
        private const int SUBSCREEN_INVENTORY = 3;
        private const int SUBSCREEN_SPELLS = 4;
        private const int SUBSCREEN_COMBAT = 5;
        #endregion
        public CharacterScreenViewModel(SessionService session, NavigationService navigation) : base(session)
        {
            this.Navigation = navigation;
            // Initialize Commands
            this.ShowOverviewCommand = new RelayCommand(() => this.ShowSubscreen(SUBSCREEN_OVERVIEW));
            this.ShowCharacterDetailsCommand = new RelayCommand(() => this.ShowSubscreen(SUBSCREEN_CHARACTERDETAILS));
            this.ShowInventoryCommand = new RelayCommand(() => this.ShowSubscreen(SUBSCREEN_INVENTORY));
            this.ShowSpellsCommand = new RelayCommand(() => this.ShowSubscreen(SUBSCREEN_SPELLS));
            this.ShowCombatCommand = new RelayCommand(() => this.ShowSubscreen(SUBSCREEN_COMBAT));
            this.ShowTextListEditPopupCommand = new RelayCommand<ICollection<string>>((textList) => this.ShowTextListEditPopup(textList));

            this.CreateTestCharacter(); // TODO remove
        }
        #region Commands
        public ICommand ShowOverviewCommand { get; private set; }
        public ICommand ShowCharacterDetailsCommand { get; private set; }
        public ICommand ShowInventoryCommand { get; private set; }
        public ICommand ShowSpellsCommand { get; private set; }
        public ICommand ShowCombatCommand { get; private set; }
        public ICommand ShowTextListEditPopupCommand { get; private set; }
        #endregion
        #region Private Fields
        private NavigationService Navigation;
        #endregion
        public override void Deinitialize()
        {
        }
        public override void Initialize()
        {
            this.ShowSubscreen(SUBSCREEN_OVERVIEW);
        }

        #region Public Properties
        private Character _ActiveCharacter;
        public Character ActiveCharacter
        {
            get
            {
                return this._ActiveCharacter;
            }
            set
            {
                this.Set(ref this._ActiveCharacter, value);
            }
        }

        private bool _OverviewViewActive;
        public bool OverviewViewActive
        {
            get
            {
                return this._OverviewViewActive;
            }
            set
            {
                this.Set(ref this._OverviewViewActive, value);
            }
        }

        private bool _CharacterDetailsViewActive;
        public bool CharacterDetailsViewActive
        {
            get
            {
                return this._CharacterDetailsViewActive;
            }
            set
            {
                this.Set(ref this._CharacterDetailsViewActive, value);
            }
        }
        private bool _CombatViewActive;
        public bool CombatViewActive
        {
            get
            {
                return this._CombatViewActive;
            }
            set
            {
                this.Set(ref this._CombatViewActive, value);
            }
        }

        private bool _InventoryViewActive;
        public bool InventoryViewActive
        {
            get
            {
                return this._InventoryViewActive;
            }
            set
            {
                this.Set(ref this._InventoryViewActive, value);
            }
        }

        private bool _SpellViewActive;
        public bool SpellViewActive
        {
            get
            {
                return this._SpellViewActive;
            }
            set
            {
                this.Set(ref this._SpellViewActive, value);
            }
        }

        private bool _EditModeActive;
        public bool EditModeActive
        {
            get
            {
                return this._EditModeActive;
            }
            set
            {
                this.Set(ref this._EditModeActive, value);
            }
        }

        public Array Abilities
        {
            get
            {
                return Enum.GetValues(typeof(Models.Enums.Ability));
            }
        }
        public Array Skills
        {
            get
            {
                return Enum.GetValues(typeof(Models.Enums.Skill));
            }
        }
        public Array Alignments
        {
            get
            {
                return Enum.GetValues(typeof(Models.Enums.Alignment));
            }
        }
        #endregion
        #region Private Methods
        private void CreateTestCharacter()
        {
            Character character = new Character();
            for (int i=0; i<5; i++)
            {
                character.OtherProficiencies.Add("Test proficiency");
            }
            for (int i = 0; i < 5; i++)
            {
                character.Ideals.Add("Test ideal");
            }
            for (int i = 0; i < 5; i++)
            {
                character.Bonds.Add("Test bond");
            }
            for (int i = 0; i < 5; i++)
            {
                character.PersonalityTraits.Add("Test trait");
            }
            for (int i = 0; i < 5; i++)
            {
                character.Flaws.Add("Test flaw");
            }
            for (int i = 0; i < 5; i++)
            {
                character.Languages.Add("Test language");
            }
            for (int i = 0; i < 5; i++)
            {
                character.Features.Add(new ObservableString("Test feature"));
            }
            this.ActiveCharacter = character;
        }
        private void ShowSubscreen(int screen)
        {
            switch(screen)
            {
                case SUBSCREEN_OVERVIEW:
                    this.OverviewViewActive = true;
                    this.SpellViewActive = false;
                    this.InventoryViewActive = false;
                    this.CombatViewActive = false;
                    break;
                case SUBSCREEN_CHARACTERDETAILS:
                    this.OverviewViewActive = false;
                    this.SpellViewActive = false;
                    this.InventoryViewActive = false;
                    this.CombatViewActive = false;
                    break;
                case SUBSCREEN_INVENTORY:
                    this.OverviewViewActive = false;
                    this.SpellViewActive = false;
                    this.InventoryViewActive = true;
                    this.CombatViewActive = false;
                    break;
                case SUBSCREEN_SPELLS:
                    this.OverviewViewActive = false;
                    this.SpellViewActive = true;
                    this.InventoryViewActive = false;
                    this.CombatViewActive = false;
                    break;
                case SUBSCREEN_COMBAT:
                    this.OverviewViewActive = false;
                    this.SpellViewActive = false;
                    this.InventoryViewActive = false;
                    this.CombatViewActive = true;
                    break;
                default:
                    this.OverviewViewActive = true;
                    this.SpellViewActive = false;
                    this.InventoryViewActive = false;
                    this.CombatViewActive = false;
                    break;
            }
        }
        private void ShowTextListEditPopup(ICollection<string> textList)
        {
            this.Navigation.OpenPopup<TextListEditViewModel>(textList);
        }
        #endregion
    }
}
