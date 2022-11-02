using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Third_Lesson
{
    internal class AlgorithmQueue
    {
        private int num = 0;

        static public Queue<double> outputLast5Results = new Queue<double>();
        public double AddToQueue(double result)
        {
            var input = result;
            outputLast5Results.Enqueue(input);
            if (outputLast5Results.Count > 5)
            {
                outputLast5Results.Dequeue();
            }
            return input;
        }

        public void OutputLast5Results()
        {
            Console.WriteLine("Records of last 5 results: ");
            foreach (var item in outputLast5Results)
            {
                ++num;
                Console.WriteLine($"Result {num}: {item}");
            }
        }
    }
}
