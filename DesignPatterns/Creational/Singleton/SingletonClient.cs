using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
	public static class SingletonClient
    {

        public static void TestMethod()
        {
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
