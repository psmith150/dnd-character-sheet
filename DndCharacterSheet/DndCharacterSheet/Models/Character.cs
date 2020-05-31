using GalaSoft.MvvmLight;

namespace DndCharacterSheet.Models
{
    public class Character : ObservableObject
    {
        #region Constructor
        public Character()
        {

        }

        #endregion

        #region Public Properties
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
        #region Abilities

        #endregion
        #region Skills

        #endregion
        #region Equipment

        #endregion
        #endregion

        #region Public Methods

        #endregion
    }
}
