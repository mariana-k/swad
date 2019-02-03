using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CD3_Kyrkosh.Converters
{
    public class AmountToBadgeConverter : IValueConverter
    {
        Brush greenBrush = new SolidColorBrush(Colors.Green);
        Brush redBrush = new SolidColorBrush(Colors.Red);
        Brush yellowBrush = new SolidColorBrush(Colors.Yellow);
        
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((int)value > 20)
            {
                return greenBrush;
            } else if ((int)value < 10)
            {
                return redBrush;
            } else {
                return yellowBrush;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
