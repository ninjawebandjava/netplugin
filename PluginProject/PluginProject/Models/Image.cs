using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginProject.Models
{
    public class Image
    {
        public string FileName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Image(string fileName, int width, int height)
        {
            FileName = fileName;
            Width = width;
            Height = height;
        }
    }
}
