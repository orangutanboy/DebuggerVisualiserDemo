using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace VisualiserDemo
{
    [DebuggerVisualizer(typeof(DemoObjectVisualiser), Description="Jonesy's amazing visualiser")]
    [Serializable]
    public class DemoObject
    {
        static Random _random = new Random();

        public DemoObject()
        {
            Colour = Color.DarkOrange;
            //Build a large array that isn't easy to see in the debugger
            IntArray = InitialiseRandomArray(18, 7);
        }

        public int[,] IntArray { get; private set; }
        public Color Colour { get; set; }

        private int[,] InitialiseRandomArray(int index1, int index2)
        {
            var intArray = new int[index1, index2];

            foreach (var i in Enumerable.Range(0, index1))
            {
                foreach (var j in Enumerable.Range(0, index2))
                {
                    intArray[i, j] = _random.Next(0, 255);
                }
            }

            return intArray;
        }
    }
}
