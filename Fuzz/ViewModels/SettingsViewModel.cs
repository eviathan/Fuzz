using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzz.ViewModels
{
    public class SettingsViewModel : ViewModelBase<SettingsViewModel>
    {
        private int _majorVersion;
        public int MajorVersion
        {
            get => _majorVersion;
            set
            {
                _majorVersion = value;
                OnPropertyChanged(x => x.MajorVersion);
            }
        }

        private string _minorVersion;
        public string MinorVersion
        {
            get => _minorVersion;
            set
            {
                _minorVersion = value;
                OnPropertyChanged(x => x.MinorVersion);
            }
        }

        private int _schemaChangeCount;
        public int SchemaChangeCount
        {
            get => _schemaChangeCount;
            set
            {
                _schemaChangeCount = value;
                OnPropertyChanged(x => x.SchemaChangeCount);
            }
        }

        private string _creator;
        public string Creator
        {
            get => _creator;
            set
            {
                _creator = value;
                OnPropertyChanged(x => x.Creator);
            }
        }

        private string _revision;
        public string Revision
        {
            get => _revision;
            set
            {
                _revision = value;
                OnPropertyChanged(x => x.Revision);
            }
        }

        public SettingsViewModel(Theme theme)
        {
            MajorVersion = theme.MajorVersion;
            MinorVersion = theme.minorVersion;
            SchemaChangeCount = theme.SchemaChangeCount;
            Creator = theme.Creator;
            Revision = theme.Revision;
        }
    }
}
