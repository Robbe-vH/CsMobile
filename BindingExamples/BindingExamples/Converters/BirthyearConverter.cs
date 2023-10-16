using System.Globalization;

namespace BindingExamples.Converters
{
    public class BirthyearConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int year = (int)value;
            int age = DateTime.Now.Year - year;
            if (age > 55) return Colors.Red;
            return Colors.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}