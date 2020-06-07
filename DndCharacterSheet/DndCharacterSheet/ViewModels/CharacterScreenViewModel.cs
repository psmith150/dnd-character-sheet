using DndCharacterSheet.Models;
using DndCharacterSheet.Models.Enums;
using DndCharacterSheet.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.ViewModels
{
    public class CharacterScreenViewModel : ScreenViewModel
    {
        public CharacterScreenViewModel(SessionService session) : base(session)
        {
            this.ActiveCharacter = new Character();
            this.EditModeActive = true;
        }
        public override void Deinitialize()
        {
        }
        public override void Initialize()
        {
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
        #endregion
    }
}
