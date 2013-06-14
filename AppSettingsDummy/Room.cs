using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace AppSettingsDummy
{
    [TypeConverter(typeof(RoomConverter))]
    [SettingsSerializeAs(SettingsSerializeAs.String)]
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Location { get; set; }
    }
}
