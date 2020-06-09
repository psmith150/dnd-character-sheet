using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using DndCharacterSheet.Models;
using System.Collections.ObjectModel;

namespace DndCharacterSheet.Services
{
    public class SessionService : ObservableObject
    {
        public SessionService()
        {
            this.PlayerRaces = new ObservableCollection<PlayerRace>();
            this.PlayerSubRaces = new ObservableCollection<PlayerSubRace>();
            this.PlayerCharacters = new ObservableCollection<Character>();
            this.PlayerClasses = new ObservableCollection<PlayerClass>();
            this.PlayerSubClasses = new ObservableCollection<PlayerSubClass>();
            this.PlayerBackgrounds = new ObservableCollection<PlayerBackground>();
            this.Spells = new ObservableCollection<Spell>();
            this.Feats = new ObservableCollection<PlayerFeat>();
            this.Items = new ObservableCollection<Item>();
        }
        #region Public Properties

        #region Busy Window
        private bool _IsBusy;
        public bool IsBusy
        {
            get
            {
                return this._IsBusy;
            }
            set
            {
                this.Set(ref this._IsBusy, value);
            }
        }

        private string _BusyTitle;
        public string BusyTitle
        {
            get
            {
                return this._BusyTitle;
            }
            set
            {
                this.Set(ref this._BusyTitle, value);
            }
        }
        private string _BusyMessage;
        public string BusyMessage
        {
            get
            {
                return this._BusyMessage;
            }
            set
            {
                this.Set(ref this._BusyMessage, value);
            }
        }
        #endregion
        #region Stored Data
        private ObservableCollection<PlayerRace> _PlayerRaces;
        public ObservableCollection<PlayerRace> PlayerRaces
        {
            get
            {
                return this._PlayerRaces;
            }
            private set
            {
                this.Set(ref this._PlayerRaces, value);
            }
        }

        private ObservableCollection<PlayerSubRace> _PlayerSubRaces;
        public ObservableCollection<PlayerSubRace> PlayerSubRaces
        {
            get
            {
                return this._PlayerSubRaces;
            }
            set
            {
                this.Set(ref this._PlayerSubRaces, value);
            }
        }

        private ObservableCollection<Character> _PlayerCharacters;
        public ObservableCollection<Character> PlayerCharacters
        {
            get
            {
                return this._PlayerCharacters;
            }
            set
            {
                this.Set(ref this._PlayerCharacters, value);
            }
        }

        private ObservableCollection<PlayerClass> _PlayerClasses;
        public ObservableCollection<PlayerClass> PlayerClasses
        {
            get
            {
                return this._PlayerClasses;
            }
            set
            {
                this.Set(ref this._PlayerClasses, value);
            }
        }

        private ObservableCollection<PlayerSubClass> _PlayerSubClasses;
        public ObservableCollection<PlayerSubClass> PlayerSubClasses
        {
            get
            {
                return this._PlayerSubClasses;
            }
            set
            {
                this.Set(ref this._PlayerSubClasses, value);
            }
        }

        private ObservableCollection<PlayerBackground> _PlayerBackgrounds;
        public ObservableCollection<PlayerBackground> PlayerBackgrounds
        {
            get
            {
                return this._PlayerBackgrounds;
            }
            set
            {
                this.Set(ref this._PlayerBackgrounds, value);
            }
        }

        private ObservableCollection<Spell> _Spells;
        public ObservableCollection<Spell> Spells
        {
            get
            {
                return this._Spells;
            }
            set
            {
                this.Set(ref this._Spells, value);
            }
        }

        private ObservableCollection<PlayerFeat> _Feats;
        public ObservableCollection<PlayerFeat> Feats
        {
            get
            {
                return this._Feats;
            }
            set
            {
                this.Set(ref this._Feats, value);
            }
        }

        private ObservableCollection<Item> _Items;
        public ObservableCollection<Item> Items
        {
            get
            {
                return this._Items;
            }
            set
            {
                this.Set(ref this._Items, value);
            }
        }
        #endregion
        #endregion
    }
}
