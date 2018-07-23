using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_mvvm.MvvmFramework;
using wpf_mvvm.Modules;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace wpf_mvvm.ViewModels
{
    public class PresenterViewModel : ObservableObject
    {
        private readonly TextConverter _textConverter = new TextConverter(s => s.ToUpper());
        private string _text;
        private readonly ObservableCollection<string> _history = new ObservableCollection<string>();

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                base.RaisePropertyChangedEvent("Text");
            }

        }

        public IEnumerable<string> History
        {
            get { return _history; }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(this.ConvertText); }
        }

        private void ConvertText()
        {
            if (string.IsNullOrWhiteSpace(Text)) return;
            AddToHistory(_textConverter.ConvertText(Text));
            Text = String.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }
    }
}
