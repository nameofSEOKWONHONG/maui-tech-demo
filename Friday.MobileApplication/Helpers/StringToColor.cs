using Microsoft.Maui.Graphics.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication.Helpers
{
    public class StringToColor : IValueConverter
    {
        Dictionary<string, Func<string, Color>> _strToColorStates = new()
        {
            {
                "Approval", v =>
                {
                    if(v == "승인") return Colors.Green;
                    return Colors.Red;
                }
            }
        };
        Dictionary<string, Func<Color, string>> _colorToStrStates = new()
        {
            {
                "Approval", v =>
                {
                    if(v == Colors.Green) return "승인";
                    return "반려";
                }
            }
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (string)value;
            var key = (string)parameter;
            return _strToColorStates[key](v);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (Color)value;
            var key = (string)parameter;
            return _colorToStrStates[key](v);
        }
    }
}
