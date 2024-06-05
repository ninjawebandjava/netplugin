using PluginProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PluginProject.Interfaces
{
    public interface IPlugin
    {
        string Name { get; }
        void ApplyEffect(Image image);
    }
}
