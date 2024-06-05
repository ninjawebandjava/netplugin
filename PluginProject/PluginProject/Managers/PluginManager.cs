using PluginProject.Interfaces;
using PluginProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginProject.Managers
{
    public class PluginManager
    {
        private List<IPlugin> plugins;

        public PluginManager()
        {
            plugins = new List<IPlugin>();
        }

        public void AddPlugin(IPlugin plugin)
        {
            plugins.Add(plugin);
        }

        public void RemovePlugin(IPlugin plugin)
        {
            plugins.Remove(plugin);
        }

        public void ApplyEffects(Image image)
        {
            foreach (var plugin in plugins)
            {
                plugin.ApplyEffect(image);
            }
        }
    }
}
