using System.Threading.Channels;

namespace LinQ_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Impilicty Type Local Variable [ var - dynamic]
            //string name = "Ahmed";
            #region Var
            //var name = "Ahmed";
            // var name2;  invalid must be initialized
            //var name3 = null; 
            //name = null;
            #endregion
            #region Dynamic
            //dynamic name = "Ahmed";  like var (js)
            //name = 10;
            //name = true;
            //dynamic X;  not must be initialized
            //dynamic y = null; 
            //name = null;
            #endregion
            #endregion
            #region Extension Method
            //int x = 123;
            //Console.WriteLine(IntExtensions.Reverse(x));
            //int y = x.Reverse();
            //Console.WriteLine(y);
            //long z = y.Reverse();
            #endregion
            #region Annynmous Type
            //var employee = new 
            //{
            //    Id = 1,
            //    Name = "Test",
            //    salary = 3000
            //};
            //Console.WriteLine(employee.Id);
            //Console.WriteLine(employee.Age); invalid
            //Console.WriteLine(employee.Name);
            //Console.Write(employee.salary);
            //Console.WriteLine(employee);
            //int x =2;
            //Console.WriteLine(employee.GetType().Name);
            //employee = new { Id = 20, Name = "Ahmed" , salary =5000};
            //employee = new { Id = 20, Name = employee.Name , salary = employee.salary};
            //employee = employee with { Id = 20 }; // c#10 syntax sugar
            //var employee002 = new { Id = 20, Name = "Hamada", salary = 2000 };
            //var employee003 = new { Id = 20, name = "Hamada", salary = 2000 };
            //var employee004 = new { Id = 20, salary = 2000, Name = "Hamada" };
            //Console.WriteLine(employee002.GetType().Name);
            //Console.WriteLine(employee003.GetType().Name);
            //Console.WriteLine(employee004.GetType().Name);
            /* the same annynommus type as long as
             * same name
             * same order
             */
            #endregion
        }
    }
}
