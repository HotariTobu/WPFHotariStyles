using System;
using System.Globalization;
using System.Windows.Data;

namespace WPF_Test
{
    public class DoubleDivisionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (double)value / (double)parameter == 0 ? 1 : (double)parameter;
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => (double)value * (double)parameter == 0 ? 1 : (double)parameter;
    }
}
