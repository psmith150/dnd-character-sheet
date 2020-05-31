using DndCharacterSheet.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacterSheet.ViewModels
{
    public abstract class ScreenViewModel : BaseViewModel
    {
        public ScreenViewModel(SessionService session) : base(session) { }

        public abstract void Initialize();

        public abstract void Deinitialize();
    }
}
