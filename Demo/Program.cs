using Demo.Company;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent parent = new Parent(5, 10);
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.MultiplyMethod());

            //Child child  = new Child(4, 5, 3);
            //Console.WriteLine(child);
            //Console.WriteLine(child.MultiplyMethod());

            //parent.Name = "Ahmed";
            //Console.WriteLine(parent.Name);

            //Test tst = new Test() { Number = 1 };

            Departement DP1 = new Departement() { DepId = 1, Name = "Programming" };
            Employee Emp1 = new Employee() { Name = "Ahmed", Id = 0, departement = DP1 };
            Employee Emp2 = new Employee() { Name = "Mahmoud", Id = 1, departement = DP1 };
            //if (DP1.Employees is not null)
            //{
            //    DP1.Employees.Add(Emp1);
            //    Console.WriteLine(DP1.Employees[0]);

            //    DP1.Employees[0] = Emp2;

            //    Console.WriteLine(DP1.Employees[0]);
            //}

            //DP1.employees.Add(Emp1);
            //Console.WriteLine(DP1.employees[0]);

            //Test2 test2 = new Test2();
            //test2.Method() = 5;

            //Console.WriteLine(test2.getMethod());

            //string obj = new string(string.Empty);

            //Console.WriteLine(Test2.RetString1());

            //Console.WriteLine(Test2.RetString3());

            //obj = Test2.RetString3();

            //Console.WriteLine(obj);

            //obj = "Mahmoud";

            //Console.WriteLine(obj);
            //Console.WriteLine(Test2.RetString3());


        }
    }

    public class Parent
    {
        #region Proprites

        public int X { get; set; }
        public int Y { get; set; }

        public string? Name { get; set; }

        #endregion

        #region Constructors

        public Parent(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region Methods

        public virtual int MultiplyMethod()
        {
            return this.X * this.Y;
        }

        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }

        #endregion

    }

    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"X = {X} , Y = {Y}, Z = {Z}";
        }

        //public override int MultiplyMethod()
        //{
        //    return Z * X * Y;
        //}

        public new int MultiplyMethod()
        {
            return X * Y * Z;
        }
    }

    public class Test
    {
        public required int Number { get; set; }
    }
}
