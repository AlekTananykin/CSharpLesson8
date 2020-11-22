using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task5
{
    public static class StudentsTools
    {
        
        public static void SaveStudentsAsXml(List<Student> list, string filepath)
        {
            if (string.IsNullOrEmpty(filepath))
                throw new StudentsToolsException(
                    "Не задан файл сохранения базы данных. ");

            try
            {
                using (FileStream fStream = new FileStream(
                    filepath, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer xmlFormat =
                        new XmlSerializer(typeof(List<Student>));

                    xmlFormat.Serialize(fStream, list);
                }
            }
            catch (Exception e)
            {
                throw new StudentsToolsException("Ошибка при чтении " +
                   "базы данных из файла. ", e);
            }
        }

        public static List<Student> ReadStudentsAsCsv(string filepath)
        {
            List<Student> students = new List<Student>();
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        students.Add(CreateStudent(line));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new StudentsToolsException(
                    "Ошибка считывания студентов из файла. ", ex);
            }

            return students;
        }

        private static Student CreateStudent(string line)
        {
            string[] columns = line.Split(';');

            if (9 != columns.Length)
                throw new StudentsToolsException(
                    "Колличество колонок в считываемом файле не равно 9.");

            return new Student()
            {
                FirstName = columns[0],
                SecondName = columns[1],
                Univercity = columns[2],
                Faculty = columns[3],
                Department = columns[4],
                Age = int.Parse(columns[5]),
                Course = int.Parse(columns[6]),
                Group = int.Parse(columns[7]),
                City = columns[8]
            };
        }

    }
}
