using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace WpfApplication
{
    public class RowStateConverter : MarkupExtension, IValueConverter
    {
        public RowStateConverter()
        {
            
        }


        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool state =(bool)value;
            if (object.Equals(parameter, "Background"))
                return new SolidColorBrush(state ? Colors.White : Colors.LightGray);
            if (object.Equals(parameter, "Foreground"))
                return new SolidColorBrush(state ? Colors.Black : Colors.DarkGray);
            if (object.Equals(parameter, "IsEnabled"))
                return state;
            return null;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

    }
}
