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
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    };

    public enum Skill
    {
        Acrobatics,
        AnimalHandling,
        Arcana,
        Athletics,
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

    public enum WeaponClass
    {
        Simple,
        Martial
    };

    public enum WeaponType
    {
        Melee,
        Ranged
    };

    public enum Currency
    {
        Copper,
        Silver,
        Electrum,
        Gold,
        Platinum
    };

    public enum DamageType
    {
        Piercing,
        Slashing,
        Bludgeoning,
        Cold,
        Fire,
        Lightning,
        Psychic,
        Force,
        Necrotic,
        Thunder,
        Acid
    };
    public enum Alignment
    {
        LawfulGood,
        NeutralGood,
        ChaoticGood,
        LawfulNeutral,
        Neutral,
        ChaoticNeutral,
        LawfulEvil,
        NeutralEvil,
        ChaoticEvil
    };

    public enum Units
    {
        Imperial,
        Metric
    };
}