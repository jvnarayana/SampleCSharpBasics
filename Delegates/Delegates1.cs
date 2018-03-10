using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public enum WorkType
    {
        Reports,
        Meetings
    }
    //Step1: Creating a Delegate
    public delegate void WorkFromDelegate(int hours, WorkType worktype);

    class Delegate1
    {
        static void Main(string[] args)
        {
            //Step 3: Invoke the delegate in the Main method
            WorkFromDelegate del1 = new WorkFromDelegate(WorkFromHandlerMethod1);
            WorkFromDelegate del2 = new WorkFromDelegate(WorkFromHandlerMethod2);
            del1.Invoke(1, WorkType.Meetings);
            del2.Invoke(12, WorkType.Reports);
            Console.Read();
        }

        // Step 2: Creating a Handler method
        static void WorkFromHandlerMethod1(int NumOfHours, WorkType workerType)
        {

            Console.WriteLine("Handler method1 :" + NumOfHours.ToString());
        }
        static void WorkFromHandlerMethod2(int hours, WorkType worktype)
        {

            Console.WriteLine("Handler method2 :" + hours.ToString());
        }

     
    }

}
