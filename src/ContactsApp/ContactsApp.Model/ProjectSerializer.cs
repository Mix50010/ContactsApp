using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using Newtonsoft.Json;
using System.IO;

namespace ContactsApp.Model
{
    public class ProjectSerializer
    {
        private JsonSerializer _serializer;

        private string FileName { get; set; }

        private string FileDirectory { get; set; }

        public void SaveToFile(Project project)
        {
                using (StreamWriter sw = new StreamWriter(FileDirectory + FileName))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    //Вызываем сериализацию и передаем объект, который хотим 
                    //сериализовать
                    _serializer.Serialize(writer, project);
                }
        }

        public Project LoadFromFile()
        {
            //Создаём переменную, в которую поместим результат 
            //десериализации
            Project project = null;
            //Создаём экземпляр сериализатора
            //Открываем поток для чтения из файла с указанием пути
            try
            {
                using (StreamReader sr = new StreamReader(FileDirectory + FileName))
                {
                    //Вызываем десериализацию и явно преобразуем результат в 
                    //целевой тип данных
                    string json = sr.ReadToEnd();
                    project = JsonConvert.DeserializeObject<Project>(json);
                }
               if (project != null)
                    return project;
                return new Project();
            }
            catch (Exception)
            {
                project = new Project();
                return project;
            }
           
        }

        public ProjectSerializer()
        {
            FileDirectory = GetFolderPath(SpecialFolder.ApplicationData) + "\\Goryachev\\ContactsApp";
            FileName = "\\ContactsApp.notes";
            _serializer = new JsonSerializer();
            if (!Directory.Exists(FileDirectory))
                Directory.CreateDirectory(FileDirectory);
            if (!File.Exists(FileDirectory + FileName))
                File.Create(FileDirectory + FileName);
        }
    }
}
