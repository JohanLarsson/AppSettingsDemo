using System;
using System.ComponentModel;

namespace AppSettingsDummy
{
    public class RoomConverter : TypeConverter
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
                Room room = new Room();
                room.RoomNumber = Convert.ToInt32(parts[0]);
                room.Location = parts.Length > 1 ? parts[1] : null;
                return room;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(
            ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                Room room = value as Room;
                return string.Format("{0},{1}", room.RoomNumber, room.Location);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}