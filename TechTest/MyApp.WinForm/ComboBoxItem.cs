using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.WinForm
{
    public class ComboBoxItem
    {
        public string text { get; set; }
        public object value { get; set; }

        public override string ToString()
        {
            return text;
        }
    }
}
