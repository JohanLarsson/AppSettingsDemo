using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppSettingsDummy.Annotations;

namespace AppSettingsDummy
{
    public class DummyVm : INotifyPropertyChanged
    {
        public DummyVm()
        {
            XmlPerson = Properties.Settings.Default.JohanXml;
            ConverterPerson = Properties.Settings.Default.JohanConvert;
        }
        private XmlPerson _xmlPerson;
        public XmlPerson XmlPerson
        {
            get { return _xmlPerson; }
            set
            {
                if (Equals(value, _xmlPerson)) return;
                _xmlPerson = value;
                OnPropertyChanged();
            }
        }

        private ConverterPerson _converterPerson;
        public ConverterPerson ConverterPerson
        {
            get { return _converterPerson; }
            set
            {
                if (Equals(value, _converterPerson)) return;
                _converterPerson = value;
                OnPropertyChanged();
            }
        }

        public void SaveXmlPerson()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var section = config.GetSection("appSettings") as AppSettingsSection;
            section.Settings["DummyString"].Value = "New";
            config.Save();
            Properties.Settings.Default.SetValue(x => x.JohanXml, XmlPerson);
            Properties.Settings.Default.Save();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
