using System.ComponentModel.DataAnnotations;

namespace DndCharacterSheet.Models.Enums
{
    public enum Dice
    {
        None,
        d4,
        d6,
        d8,
        d10,
        d12,
        d20,
        d100
    };

    public enum Ability
    {
        Strength,
        Dexterity,
        Intelligence,
        Wisdom,
        Charisma
    };

    public enum Skill
    {
        Athletics,
        Acrobatics,
        AnimalHandling,
        Arcana,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        SleightofHand,
        Stealth,
        Survival
    };

    public enum Modifier
    {
        MeleeAttack,
        RangedAttack,
        SpellAttack,
        AC,
        SavingThrow,
        AbilityCheck
    };

}