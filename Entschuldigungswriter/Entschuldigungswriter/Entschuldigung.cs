using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entschuldigungswriter
{
    internal class Entschuldigung
    {
        string text;
        public Entschuldigung(string text)
        {
            this.text = text;
        }

        public string Text() 
        {
            return text; 
        }
        
    }
}
