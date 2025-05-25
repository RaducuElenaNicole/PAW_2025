using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar8_05_05_2025
{
    public static class FakeDatabase
    {
        public static List<FileModel> Files = new List<FileModel>()
        {
            new FileModel()
            {
                Name = "picture",
                Extension = "png",
                ModifiedOn = DateTime.Now.AddMinutes(-5)
            },
            new FileModel()
            {
                Name = "document",
                Extension = "docx",
                ModifiedOn = DateTime.Now.AddHours(-5)
            }
        }; 
    }
}
