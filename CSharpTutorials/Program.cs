using CSharpTutorials.BasicCSharp.ArrayFunction;
using CSharpTutorials.BasicCSharp.ClassObject;
using CSharpTutorials.BasicCSharp.ControlStatement;
using CSharpTutorials.BasicCSharp.Function;
using CSharpTutorials.BasicCSharp.Inheritance;
using CSharpTutorials.BasicCSharp.Looping;
using CSharpTutorials.BasicCSharp.Operators;
using CSharpTutorials.BasicCSharp.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.showColor();
            //Party p=new Party();
            //p.Msg();

            //MemberOverloading mol=new MemberOverloading();
            //mol.Sum(51.52d,154.87d);

            //Bonus b = new Bonus();
            //b.BasicDetails();
            //b.EmployeeDetails();
            //b.BonusDetails();

            //Employee emp = new Employee();
            //emp.EmployeeSalaryDetails();
            //PropertyExample pe = new PropertyExample();
            //pe.EmployeeDetails();
            //Enumeration en = new Enumeration();
            //en.CallEnum();

            //Constructor.roi = 847.52f;
            //Constructor con = new Constructor();
            //Constructor con1 = new Constructor(15, 25);
            //Constructor con2 = new Constructor(151, 215);
            //int num = 45;
            //ValueandReftype vr = new ValueandReftype();
            //vr.Showdataref(ref num);
            //Console.WriteLine("Orignal number is {0}", num);
            //FunctionAll functionall = new FunctionAll();
            //functionall
            //int num=functionall.Add(52,98);

            //Console.WriteLine("Sum of two number is {0}", num);//    
            //_2DArray _2d = new _2DArray();
            //_2d.ArrayProgram1();
            //_1DArray _1d = new _1DArray();
            //_1d.BinarySearch();
            //NestedLoop nl = new NestedLoop();
            //nl.Pattern7();
            //FoorLoop dwl = new FoorLoop();
            //    dwl.CheckPrimeNo();
            //WhileLoop wl = new WhileLoop();
            //wl.ReverseNumber();


            //SwitchCase sc = new SwitchCase();
            //sc.SimpleCalculator();
            //ElseifLadder eil = new ElseifLadder();
            //eil.SimpleCalculator();
            //NestedIfElse.SimpleCalculator();

            //SimpleIfElse.VotingAge();

            //SimpleIf sif = new SimpleIf();
            //sif.VotingAge();

            //Ternary_Relational_Logical TRL = new Ternary_Relational_Logical();
            //TRL.ValidAge();

            //Assignment assign = new Assignment();
            //assign.Assignment_Addtion();

            //Unary un = new Unary();
            //un.Incremental();

            //Arithmatic am = new Arithmatic();
            //am.Addition();

            //// for static method we can't call that method using Object(instance)
            //Arithmatic.Subtraction();

            Console.ReadKey();
        }
    }
}
