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
        /// <summary>
        /// Сериализатор.
        /// </summary>
        private JsonSerializer _serializer;

        /// <summary>
        /// Имя файла с данными.
        /// </summary>
        private string FileName { get; set; }

        /// <summary>
        /// Директория данных.
        /// </summary>
        private string FileDirectory { get; set; }

        /// <summary>
        /// Запись текущего проекта в файл.
        /// </summary>
        /// <param name="project"></param>
        public void SaveToFile(Project project)
        {
            if (!Directory.Exists(FileDirectory))
            {
                Directory.CreateDirectory(FileDirectory);
            }
            if (!File.Exists(FileDirectory + FileName))
            {
                File.Create(FileDirectory + FileName);
            }
            using (StreamWriter sw = new StreamWriter(FileDirectory + FileName))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    //Вызываем сериализацию и передаем объект, который хотим 
                    //сериализовать
                    _serializer.Serialize(writer, project);
                }
            }
        }

        /// <summary>
        /// Загрузка проекта из файла.
        /// </summary>
        /// <returns></returns>
        public Project LoadFromFile()
        {
            if (!Directory.Exists(FileDirectory))
            {
                Directory.CreateDirectory(FileDirectory);
            }
            if (!File.Exists(FileDirectory + FileName))
            {
                File.Create(FileDirectory + FileName);
            }
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
                {
                    return project;
                }
                return new Project();
            }
            catch (Exception)
            {
                return new Project();
            }
        }

        /// <summary>
        /// Объект сериализатора
        /// </summary>
        public ProjectSerializer()
        {
            FileDirectory = GetFolderPath(SpecialFolder.ApplicationData) + "\\Goryachev\\ContactsApp";
            FileName = "\\ContactsApp.notes";
            _serializer = new JsonSerializer();
        }
    }
}