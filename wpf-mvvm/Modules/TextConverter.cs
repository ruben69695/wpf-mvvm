using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_mvvm.Modules
{
    public class TextConverter
    {
        private readonly Func<string, string> _convertion;

        public TextConverter(Func<string, string> convertion)
        {
            _convertion = convertion ?? throw new ArgumentNullException(nameof(convertion), "can't be null");
        }

        public string ConvertText(string inputText)
        {
            return _convertion(inputText);
        }
    }
}
