using PluginProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginProject.Models;

namespace PluginProject.Plugins
{
    public class ResizePlugin : IPlugin
    {
        public string Name => "Resize";

        public void ApplyEffect(Image image)
        {
            Console.WriteLine($"Applying Resize effect to {image.FileName}...");
            // Simulated resize operation
            image.Width /= 2;
            image.Height /= 2;
        }
    }
}
