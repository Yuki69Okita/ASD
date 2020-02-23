using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            // 1. measure the total time
            //int[] nums1 = new int[100000];
            //BuildArray(nums1);
            //sw.Start();
            //DisplayNums(nums1);
            //sw.Stop();
            //Console.WriteLine("\n\n Duration: {0}", sw.Elapsed);
            ////Console.WriteLine("\n\n Duration: {0:hh\\:mm\\:ss}", sw.Elapsed);

            // 2. measure CPU time only
            //int[] nums2 = new int[100000];
            //BuildArray(nums2);
            //TimeSpan startTime;
            //TimeSpan duration;
            //startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            //DisplayNums(nums2);
            //duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime
            //    .Subtract(startTime);
            //Console.WriteLine("\n\n time: " + duration.TotalSeconds);

            // 3. measure CPU time only but with activate garbage collector in the beginning
            //int[] nums3 = new int[100000];
            //BuildArray(nums3);
            //TimingInfo ti = new TimingInfo();
            //ti.StartTime();
            //DisplayNums(nums3);
            //ti.StopTime();
            //Console.WriteLine("\n\n time:" + ti.Result());
        }

        static void BuildArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }
        static void DisplayNums(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
