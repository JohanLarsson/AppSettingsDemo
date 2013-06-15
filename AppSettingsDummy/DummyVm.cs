using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppSettingsDummy.Annotations;
using AppSettingsDummy.Properties;

namespace AppSettingsDummy
{
    public class DummyVm : INotifyPropertyChanged
    {
        public DummyVm()
        {
            XmlPerson = Properties.Settings.Default.JohanXml;
            ConverterPerson = Properties.Settings.Default.JohanConvert;
            Persons = new ObservableCollection<XmlPerson>(Settings.Default.ListOfPersons);
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

        public ObservableCollection<XmlPerson> Persons { get; private set; }

        public string AppSettings
        {
            get
            {
                return File.ReadAllText(FilePath);
            }
        }

        public DateTime LastSavedTime
        {
            get
            {
                return File.GetLastWriteTime(FilePath);
            }
        }

        public string FilePath
        {
            get
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                return config.FilePath;
            }
        }

        public void SaveXmlPerson()
        {
            Properties.Settings.Default.SetValue(x => x.JohanXml, XmlPerson);
            Properties.Settings.Default.Save(); //This does not save anything for application scoped settings :(
            SaveTest();
            OnPropertyChanged("AppSettings");
            OnPropertyChanged("LastSavedTime");
        }

        /// <summary>
        /// Temp method for trying to figure out how to save
        /// </summary>
        private void SaveTest()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettingsSection = config.AppSettings;

            Settings settings = Properties.Settings.Default;
            string settingsKey = settings.SettingsKey;

            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var section = config.GetSection("appSettings") as AppSettingsSection;
            //section.Settings["DummyString"].Value = "New";
            //config.Save();
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
