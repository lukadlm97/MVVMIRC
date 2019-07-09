using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMMinimal.Model
{
    public class TextConverter
    {
        private readonly Func<string, string> _conversion;

        public TextConverter(Func<string,string> conversion)
        {
            _conversion = conversion;
        }

        public string Convert(string input)
        {
            return _conversion(input);
        }
    }
}
