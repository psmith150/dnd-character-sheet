using DndCharacterSheet.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DndCharacterSheet.Views.CustomControls
{
    /// <summary>
    /// Interaction logic for AbilityDisplay.xaml
    /// </summary>
    public partial class AbilityDisplay : UserControl
    {
        public AbilityDisplay()
        {
            InitializeComponent();
        }

        #region Properties
        public static readonly DependencyProperty AbilityProperty = DependencyProperty.Register(nameof(Ability), typeof(Ability), typeof(AbilityDisplay), new FrameworkPropertyMetadata
        {
            BindsTwoWayByDefault = true,
            DefaultValue= new Ability("Unknown", 0),
        });   
        public Ability Ability
        {
            get
            {
                return (Ability)GetValue(AbilityProperty);
            }
            set
            {
                SetValue(AbilityProperty, value);
            }
        }
        public static readonly DependencyProperty AbilityModifierProperty = DependencyProperty.Register(nameof(AbilityModifier), typeof(int), typeof(AbilityDisplay), new FrameworkPropertyMetadata(0));
        public int AbilityModifier
        {
            get
            {
                return (int)GetValue(AbilityModifierProperty);
            }
            set
            {
                SetValue(AbilityModifierProperty, value);
            }
        }
        public static readonly DependencyProperty AbilityNameProperty = DependencyProperty.Register(nameof(AbilityName), typeof(string), typeof(AbilityDisplay), new FrameworkPropertyMetadata(""));
        public string AbilityName
        {
            get
            {
                return (string)GetValue(AbilityNameProperty);
            }
            set
            {
                SetValue(AbilityNameProperty, value);
            }
        }
        public static readonly DependencyProperty EditEnabledProperty = DependencyProperty.Register(nameof(EditEnabled), typeof(bool), typeof(AbilityDisplay), new FrameworkPropertyMetadata(false));
        public bool EditEnabled
        {
            get
            {
                return (bool)GetValue(EditEnabledProperty);
            }
            set
            {
                SetValue(EditEnabledProperty, value);
            }
        }
        #endregion
    }
}
