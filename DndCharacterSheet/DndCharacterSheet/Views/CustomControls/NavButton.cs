using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DndCharacterSheet.Views.CustomControls
{
    class NavButton : Button
    {
        public Brush HoverBackgroundBrush
        {
            get { return (Brush)GetValue(HoverBackgroundBrushProperty); }
            set { SetValue(HoverBackgroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBackgroundBrushProperty =
            DependencyProperty.Register("HoverBackgroundBrush", typeof(Brush), typeof(NavButton), new PropertyMetadata(default(Brush)));

        public Brush HoverForegroundBrush
        {
            get { return (Brush)GetValue(HoverForegroundBrushProperty); }
            set { SetValue(HoverForegroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverForegroundBrushProperty =
            DependencyProperty.Register("HoverForegroundBrush", typeof(Brush), typeof(NavButton), new PropertyMetadata(default(Brush)));

        public Brush DisabledBackgroundBrush
        {
            get { return (Brush)GetValue(DisabledBackgroundBrushProperty); }
            set { SetValue(DisabledBackgroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledForegroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledForegroundBrushProperty =
            DependencyProperty.Register("DisabledForegroundBrush", typeof(Brush), typeof(NavButton), new PropertyMetadata(default(Brush)));

        public Brush DisabledForegroundBrush
        {
            get { return (Brush)GetValue(DisabledForegroundBrushProperty); }
            set { SetValue(DisabledForegroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledBackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledBackgroundBrushProperty =
            DependencyProperty.Register("DisabledBackgroundBrush", typeof(Brush), typeof(NavButton), new PropertyMetadata(default(Brush)));

        public Image ButtonDisabledImage
        {
            get { return (Image)GetValue(ButtonDisabledImageProperty); }
            set { SetValue(ButtonDisabledImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonDisabledImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonDisabledImageProperty =
            DependencyProperty.Register("ButtonDisabledImage", typeof(Image), typeof(NavButton), new PropertyMetadata(default(Image)));

        public Image ButtonHoverImage
        {
            get { return (Image)GetValue(ButtonHoverImageProperty); }
            set { SetValue(ButtonHoverImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonHoverImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonHoverImageProperty =
            DependencyProperty.Register("ButtonHoverImage", typeof(Image), typeof(NavButton), new PropertyMetadata(default(Image)));

        public Image ButtonImage
        {
            get { return (Image)GetValue(ButtonImageProperty); }
            set { SetValue(ButtonImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonImageProperty =
            DependencyProperty.Register("ButtonImage", typeof(Image), typeof(NavButton), new PropertyMetadata(default(Image)));

        public Thickness ButtonImageMargin
        {
            get { return (Thickness)GetValue(ButtonImageMarginProperty); }
            set { SetValue(ButtonImageMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonImageMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonImageMarginProperty =
            DependencyProperty.Register("ButtonImageMargin", typeof(Thickness), typeof(NavButton), new PropertyMetadata(default(Thickness)));

        public Double ButtonImageWidth
        {
            get { return (Double)GetValue(ButtonImageWidthProperty); }
            set { SetValue(ButtonImageWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonImageWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonImageWidthProperty =
            DependencyProperty.Register("ButtonImageWidth", typeof(Double), typeof(NavButton), new PropertyMetadata(default(Double)));
    }
}
