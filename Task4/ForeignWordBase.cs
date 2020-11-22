using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task4
{
    class ForeignWordBase
    {
        private List<Word> _list;

        public string Filename
        {
            get;
            set;
        }

        public ForeignWordBase()
        {
            _list = new List<Word>();
        }

        public void Add(string native, string foreign)
        {
            _list.Add(new Word() { Native = native, Foreign = foreign});
        }

        public void Remove(int index)
        {
            if (_list != null && index < _list.Count() && index >= 0)
                _list.RemoveAt(index);
        }

        public Word this[int index]
        {
            get { return _list[index]; }
        }

        public void Save()
        {
            if (string.IsNullOrEmpty(Filename))
                throw new ForeignWordBaseException(
                    "Не задан файл сохранения базы данных. ");

            try
            {
                using (FileStream fStream = new FileStream(
                    Filename, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer xmlFormat =
                        new XmlSerializer(typeof(List<Word>));

                    xmlFormat.Serialize(fStream, _list);
                }
            }
            catch (Exception e)
            {
                throw new ForeignWordBaseException("Ошибка при чтении " +
                   "базы данных из файла. ", e);
            }
        }

        public void Load()
        {
            if (string.IsNullOrEmpty(Filename))
                throw new ForeignWordBaseException(
                    "Не задан файл сохранения базы данных. ");

            try
            {
                using (FileStream fStream = new FileStream(
                    Filename, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer xmlFormat = new XmlSerializer(
                        typeof(List<Word>));

                    _list = (List<Word>)xmlFormat.Deserialize(fStream);
                }
            }
            catch (Exception e)
            {
                throw new ForeignWordBaseException("Ошибка при загрузке " +
                    "базы данных из файла. ", e);
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
