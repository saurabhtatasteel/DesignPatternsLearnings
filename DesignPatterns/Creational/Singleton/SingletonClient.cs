using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class SingletonClient
    {

        public void TestMethod()
        {
            //var testObj = Singleton.Instance;
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
            );

        }


        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.Instance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.Instance;
            fromStudent.PrintDetails("From Student");
        }

    }
}
