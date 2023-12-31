﻿using CSharpTutorials.Advance.Collection;
using CSharpTutorials.Advance.Generics;
using CSharpTutorials.BasicCSharp.Abstraction;
using CSharpTutorials.BasicCSharp.ArrayFunction;
using CSharpTutorials.BasicCSharp.ClassObject;
using CSharpTutorials.BasicCSharp.ControlStatement;
using CSharpTutorials.BasicCSharp.ExceptionHandling;
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

            GenericClassDemo<int> arr = new GenericClassDemo<int>(5);

            for(int c=0;c<5;c++)
            {
                arr.SetItem(c, c * 5);
            }

            for(int c=0;c<5;c++)
            {
                Console.Write(arr.getItem(c)+"  ");
            }

            Console.WriteLine();
            GenericClassDemo<char> arr1 = new GenericClassDemo<char>(5);
            for (int c = 0; c < 5; c++)
            {
                arr1.SetItem(c, (char)(c +97));
            }

            for (int c = 0; c < 5; c++)
            {
                Console.Write(arr1.getItem(c) + "  ");
            }
            //GenericClassDemo<string> gen = new GenericClassDemo<string>("I am creating a Basic Program");
            //GenericClassDemo<int> gen1 = new GenericClassDemo<int>(1234);
            //GenericClassDemo<char> gen2 = new GenericClassDemo<char>('J');
            //  HashSetClass hashSetClass = new HashSetClass();
            ////  hashSetClass.HashSetDemo();
            //  hashSetClass.RemoveDuplicateCharacter();

            //DictionaryClass dc = new DictionaryClass();
            //dc.DictionaryDemo();

            //ListClass lc = new ListClass();

            //lc.ListDemo();

            //ExceptionDemo ed = new ExceptionDemo();
            //try
            //{
            //    ed.check();
            //}
            //catch (UserDefineException ude)
            //{
            // Console.WriteLine(ude.Message);    
            //}


            //Trycatchdemo tcd = new Trycatchdemo();
            //tcd.Progrmademo();
            //NameSpaceDemo nsd = new NameSpaceDemo();
            //nsd.Msg();
            //demo1.NameSpaceDemo dnsd = new demo1.NameSpaceDemo();
            //dnsd.Msg();

            //demo2.NameSpaceDemo  dnsd2= new demo2.NameSpaceDemo();
            //dnsd2.Msg();

            //Drawable d;
            //d = new Square();
            //d.draw();
            //d = new Cone();
            //d.draw();
            //d = new InterfaceDemo();
            //d.draw();
            //Shape s;
            //s = new Rectange();
            //s.draw();
            //s = new Circle();
            //s.draw();
            //s = new AbstractionDemo();
            //s.draw();


            //BaseClass baseClass = new BaseClass();
            //baseClass.showColor();
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
