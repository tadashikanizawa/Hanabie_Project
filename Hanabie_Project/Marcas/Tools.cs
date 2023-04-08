using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabie_Project.Marcas
{
    public class Tools
    {
        public string Mark { get;set; }
        public string Type { get;set; }
        public string ID { get; set; }
        public int Laminas { get; set; }
        public float Kei { get; set; }
        public float Kubushita { get; set; }
        public float Hachou { get; set; }
        public float Kado { get; set; }
        public float Zenchou { get; set; }
        public float Kataban { get;set; }

        public List<Tools> tools { get; set; } = new List<Tools>();



    }
}
