using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfLaba6
{
    public class ConverterEnabledButton : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, CultureInfo culture)
        {
            string str1 = values as string;
            return str1.Length > 0;
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
