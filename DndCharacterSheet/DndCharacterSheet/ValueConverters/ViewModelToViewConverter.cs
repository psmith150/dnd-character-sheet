using DndCharacterSheet.IOC;
using DndCharacterSheet.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;

namespace DndCharacterSheet.ValueConverters
{
    [ValueConversion(typeof(BaseViewModel), typeof(UserControl))]
    public class ViewModelToViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var viewModel = value as BaseViewModel;
            return viewModel != null ? IocContainer.ResolveScreen(viewModel.GetType()) : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
