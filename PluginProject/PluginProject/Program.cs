// Create image objects (simulated data)
using PluginProject.Managers;
using PluginProject.Models;
using PluginProject.Plugins;

Image image1 = new Image("image1.jpg", 100, 100);
Image image2 = new Image("image2.jpg", 200, 150);

// Create plugin manager
PluginManager pluginManager = new PluginManager();

// Add sample plugins (simulated)
pluginManager.AddPlugin(new ResizePlugin());
pluginManager.AddPlugin(new BlurPlugin());
pluginManager.AddPlugin(new GrayscalePlugin());

// Apply effects to images
pluginManager.ApplyEffects(image1);
pluginManager.ApplyEffects(image2);