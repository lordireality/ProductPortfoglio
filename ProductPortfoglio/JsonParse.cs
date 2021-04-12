using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ProductPortfoglio
{
    public class JsonParse
    {
        public JsonDataSource JDS = new JsonDataSource();
        public void ReadJsonFile()
        {
            if (isFileExist(@"./projects.json"))
            {
                string reader_data = System.IO.File.ReadAllText(@"./projects.json"); ;
                JDS = new JsonDataSource();
                JDS = JsonConvert.DeserializeObject<JsonDataSource>(reader_data);
            } else
            {
                System.Windows.Forms.MessageBox.Show("Файл с проектами не найден!");
            }


        }
        public void UpdateJsonFile()
        { 
            string updData = JsonConvert.SerializeObject(JDS);
            System.IO.File.WriteAllText(@"./projects.json", updData);
        }

        public bool isFileExist(string path)
        {
            if (File.Exists(path))
            {
                return true;
            } else
            {
                return false;
            }
            
        }
        

    }
}
