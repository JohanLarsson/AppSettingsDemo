using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppSettingsDummy.Annotations;
using AppSettingsDummy.Properties;

namespace AppSettingsDummy
{
    public class DummyVm :INotifyPropertyChanged
    {


        public DummyVm()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Properties.Settings.Default.SetValue(x=>x.DefaultEmployee,new Employee{Name = "Erik", Position = "Bottom"});
            Properties.Settings.Default.Save();
            var employee = Properties.Settings.Default.DefaultEmployee;

            //var s = config.AppSettings["DefaultEmployee"];
//            config.Save(ConfigurationSaveMode.Full);
            Name = employee.Name;
            Pos = employee.Position;
        }
        private string _name;
        public string Name
        {
            get { return Properties.Settings.Default.DefaultEmployee.Name; }
            set
            {
                if (value == Properties.Settings.Default.DefaultEmployee.Name) return;
                Properties.Settings.Default.DefaultEmployee.Name = value;
                Properties.Settings.Default.Save();
                OnPropertyChanged();
            }
        }

        public string Pos { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    internal static class SettingsExt
    {
        public static void SetValue<T>(this Settings settings, Expression<Func<Settings,T>> property, T value)
        {
            string name = ((MemberExpression) property.Body).Member.Name;
            settings[name] = value;
        }
    }
}
