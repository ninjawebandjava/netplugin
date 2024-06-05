using PluginProject.Interfaces;
using PluginProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginProject.Plugins
{
    public class GrayscalePlugin : IPlugin
    {
        public string Name => "Grayscale";

        public void ApplyEffect(Image image)
        {
            Console.WriteLine($"Applying Grayscale effect to {image.FileName}...");
            // Simulated grayscale conversion
        }
    }
}
