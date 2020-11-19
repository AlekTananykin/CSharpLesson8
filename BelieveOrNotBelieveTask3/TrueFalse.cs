using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BelieveOrNotBelieveTask3
{
    class TrueFalse
    {
        private List<Question> _list;

        public string Filename
        {
            get;
            set;
        }

        public TrueFalse(string filename)
        {
            Filename = filename;
            _list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            _list.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (_list != null && index < _list.Count() && index >= 0)
                _list.RemoveAt(index);
        }

        public Question this[int index]
        {
            get { return _list[index]; }
        }

        public void Save()
        {
            using (FileStream fStream = new FileStream(
                Filename, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xmlFormat =
                    new XmlSerializer(typeof(List<Question>));

                xmlFormat.Serialize(fStream, _list);
            }
        }

        public void Load()
        {
            using (FileStream fStream = new FileStream(
                Filename, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xmlFormat = new XmlSerializer(
                    typeof(List<Question>));

                _list = (List<Question>)xmlFormat.Deserialize(fStream);
            }
        }

        public int Count
        {
            get {
                if (null == _list)
                    return 0;
                return _list.Count;
            }
        }

    }
}
