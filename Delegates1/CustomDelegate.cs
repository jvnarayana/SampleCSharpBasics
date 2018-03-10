using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{

    public enum WorkType
    {
        Reports,
        Meetings
    }
    //Step1: Creating a Delegate
    public delegate void WorkFromDelegate(int hours, WorkType worktype);

    class CustomDelegate
    {
        static void Main(string[] args)
        {
            WorkFromDelegate del1 = new WorkFromDelegate(WorkFromHandlerMethod1);
            WorkFromDelegate del2 = new WorkFromDelegate(WorkFromHandlerMethod2);
            Work(del1);
            Work(del2);
            Console.Read();

        }

        // Step 2: Creating a Handler method
static void WorkFromHandlerMethod1(int NumOfHours,WorkType workerType)
        {

            Console.WriteLine("Handler method1 :"+NumOfHours.ToString());
        }
        static void WorkFromHandlerMethod2(int hours, WorkType worktype)
        {

            Console.WriteLine("Handler method2 :" + hours.ToString());
        }

        //Step 3: Creating a common method 
        static void Work(WorkFromDelegate del)
        {
            del(5,WorkType.Reports);
        }

    }



}
