using DndCharacterSheet.Models.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DndCharacterSheet.Models
{
    public class UserSettings
    {
        public UserSettings()
        {
            this.Theme = "";
            this.Units = Units.Imperial;
        }

        public string Theme { get; set; }
        public Units Units { get; set; }
    }
}
