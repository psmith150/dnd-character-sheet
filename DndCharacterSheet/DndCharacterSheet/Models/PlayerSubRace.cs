using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class PlayerSubRace : PlayerRace
    {
        public PlayerSubRace(PlayerRace parentRace) : base()
        {
            this.ParentRace = parentRace;
        }

        #region Public Properties

        private PlayerRace _ParentRace;
        public PlayerRace ParentRace
        {
            get
            {
                return this._ParentRace;
            }
            private set
            {
                this.Set(ref this._ParentRace, value);
            }
        }
        #endregion
    }
}
