using System.ComponentModel;
using System.Runtime.CompilerServices;
using docsort.Annotations;

namespace docsort.Models
{
    public class Document : INotifyPropertyChanged
    {
        private string _path;
        private Correspondent _detectedCorrespondent;
        private string _date;
        private string _subject;
        private string _statusText;

        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }

        public string FileName
        {
            get { return System.IO.Path.GetFileName(_path); }
        }

        public Correspondent DetectedCorrespondent
        {
            get { return _detectedCorrespondent; }
            set
            {
                _detectedCorrespondent = value;
                OnPropertyChanged(nameof(DetectedCorrespondent));
            }
        }

        public string Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        public string StatusText
        {
            get { return _statusText; }
            set
            {
                _statusText = value;
                OnPropertyChanged(nameof(StatusText));
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