using Microsoft.VisualStudio.DebuggerVisualizers;
using VisualiserDemo;

namespace DevelopmentHostDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectToVisualise = new DemoObject();
            var host = new VisualizerDevelopmentHost(objectToVisualise, typeof(DemoObjectVisualiser));
            host.ShowVisualizer();
        }
    }
}
