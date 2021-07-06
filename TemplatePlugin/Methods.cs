using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePlugin
{
    public class Methods
    {
        public string Reverse(string message)
        {
            return string.Join("", message.Reverse());
        }
    }
}
