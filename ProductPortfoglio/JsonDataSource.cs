using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace ProductPortfoglio
{
    public class JsonDataSource
    {
        public List<Projects> project = new List<Projects>();
    }

    public class Projects
    {
        public string name { get; set; }
        public string desc { get; set; }
        public bool hasLink { get; set; }
        public string link { get; set; }
        public bool hasPath { get; set; }
        public string path { get; set; }

        public List<ProjectImg> img = new List<ProjectImg>();
    }
    public class ProjectImg
    {
        
        public string path { get; set; } = "imgNotFound.png";
    }
}
