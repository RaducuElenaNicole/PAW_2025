using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar8_05_05_2025
{
    [Serializable]
    public class FileModel
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public DateTime ModifiedOn { get; set; }


    }
}
