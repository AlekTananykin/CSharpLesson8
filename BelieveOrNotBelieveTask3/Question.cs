using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelieveOrNotBelieveTask3
{
    [Serializable]
    public class Question
    {
        public string _text;
        public bool _trueFalse;

        public Question()
        { 
        }

        public Question(string text, bool trueFalse)
        {
            this._text = text;
            this._trueFalse = trueFalse;
        }
    }
}
