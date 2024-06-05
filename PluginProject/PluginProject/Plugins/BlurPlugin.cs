using PluginProject.Interfaces;
using PluginProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace PluginProject.Plugins
{
    public class BlurPlugin : IPlugin
    {
        public string Name => "Blur";

        public void ApplyEffect(Image image)
        {
            Console.WriteLine($"Applying Blur effect to {image.FileName}...");
            // Simulated blur operation
        }

    
    }
}
