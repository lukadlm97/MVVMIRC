using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MVVMMinimal.Model;
using System.Windows.Input;

namespace MVVMMinimal.ModelVIew
{
    public class Presenter:ObservableObject
    {
        private readonly TextConverter _textConverter = new TextConverter(s => s.ToUpper());
        private string _someText;

        public string SomeText
        {
            get { return _someText; }
            set
            {
                _someText = value;
                RaiseNotifyChanges("SomeText");
            }
        }
        private readonly ObservableCollection<string> _history = new ObservableCollection<string>();

        public IEnumerable<string> History
        {
            get { return _history; }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegatCommand(ConvertText); }
        }

        private void ConvertText()
        {
            if (string.IsNullOrWhiteSpace(_someText) == null) return;
            AddToHistory(_textConverter.Convert(_someText));
            SomeText = string.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }
    }
}
