using System;
using System.ComponentModel;

namespace AppSettingsDummy
{
    /// <summary>
    /// http://www.blackwasp.co.uk/CustomAppSettings.aspx
    /// </summary>
    public class PersonConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertFrom(
            ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                string[] parts = ((string)value).Split(new char[] { ',' });
                ConverterPerson converterPerson = new ConverterPerson(parts[0],int.Parse(parts[1]));
                return converterPerson;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(
            ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                ConverterPerson converterPerson = value as ConverterPerson;
                return string.Format("{0},{1}", converterPerson.Name, converterPerson.Age);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}