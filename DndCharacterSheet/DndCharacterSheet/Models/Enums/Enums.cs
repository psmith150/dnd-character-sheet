using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

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
        [Display(Description = "Acrobatics")] Acrobatics,
        [Display(Description = "Animal Handling")] AnimalHandling,
        [Display(Description = "Arcana")] Arcana,
        [Display(Description = "Athletics")] Athletics,
        [Display(Description = "Deception")] Deception,
        [Display(Description = "History")] History,
        [Display(Description = "Insight")] Insight,
        [Display(Description = "Intimidation")] Intimidation,
        [Display(Description = "Investigation")] Investigation,
        [Display(Description = "Medicine")] Medicine,
        [Display(Description = "Nature")] Nature,
        [Display(Description = "Perception")] Perception,
        [Display(Description = "Performance")] Performance,
        [Display(Description = "Persuasion")] Persuasion,
        [Display(Description = "Religion")] Religion,
        [Display(Description = "Sleight of Hand")] SleightofHand,
        [Display(Description = "Stealth")] Stealth,
        [Display(Description = "Survival")] Survival
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
        [Display(Description = "Lawful Good")] LawfulGood,
        [Display(Description = "Neutral Good")] NeutralGood,
        [Display(Description = "Chaotic Good")] ChaoticGood,
        [Display(Description = "Lawful Neutral")] LawfulNeutral,
        [Display(Description = "Neutral")] Neutral,
        [Display(Description = "Chaotic Neutral")] ChaoticNeutral,
        [Display(Description = "Lawful Evil")] LawfulEvil,
        [Display(Description = "Neutral Evil")] NeutralEvil,
        [Display(Description = "Chaotic Evil")] ChaoticEvil
    };

    public enum Units
    {
        Imperial,
        Metric
    };

    public enum Size
    {
        Small,
        Medium,
        Large,
        Giant,
        Huge,
        Gargantuan
    };

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            MemberInfo[] memInfo = type.GetMember(value.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DisplayAttribute), false);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((DisplayAttribute)attrs[0]).Description;
                }
            }
            return value.ToString();
        }
    }
    
}