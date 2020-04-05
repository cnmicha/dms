using System.ComponentModel;
using System.Runtime.CompilerServices;
using docsort.Annotations;

namespace docsort
{
    public class Document : INotifyPropertyChanged
    {
        private string _path;
        private Correspondent _detectedCorrespondent = null;
        private string _statusText;

        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("Path");
            }
        }

        public Correspondent DetectedCorrespondent
        {
            get { return _detectedCorrespondent; }
            set
            {
                _detectedCorrespondent = value;
                OnPropertyChanged("DetectedCorrespondent");
            }
        }

        public string StatusText
        {
            get { return _statusText; }
            set
            {
                _statusText = value;
                OnPropertyChanged("StatusText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"Document {Path}";
        }
    }
}