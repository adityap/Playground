﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
			////Test Changes for GIT integration
			////string val = System.Configuration.ConfigurationManager.AppSettings["test"];   
			////Console.WriteLine("Aditya    " + val);
			//// Define a delegate that prints and returns the system tick count
			//Func<object, int> action = (object obj) =>
			//{
			//	int i = (int) obj;

			//	// Make each thread sleep a different time in order to return a different tick count
			//	Thread.Sleep(i*100);

			//	// The tasks that receive an argument between 2 and 5 throw exceptions 
			//	if (2 <= i && i <= 5)
			//	{
			//		//throw new InvalidOperationException("SIMULATED EXCEPTION");
			//	   // Thread.Sleep(i*10000);
			//	}

			//	int tickCount = Environment.TickCount;
			//	Console.WriteLine("Task={0}, i={1}, TickCount={2}, Thread={3}", Task.CurrentId, i, tickCount,
			//		Thread.CurrentThread.ManagedThreadId);

			//	return tickCount;
			//};

			//const int n = 10;

			//// Construct started tasks
			//Task<int>[] tasks = new Task<int>[n];
			//for (int i = 0; i < n; i++)
			//{
			//	tasks[i] = Task<int>.Factory.StartNew(action, i);
                
			//}

			//// Exceptions thrown by tasks will be propagated to the main thread 
			//// while it waits for the tasks. The actual exceptions will be wrapped in AggregateException. 
			//try
			//{
			//	// Wait for all the tasks to finish.
			//	Task.WaitAll(tasks,10000);

			//	// We should never get to this point
			//	Console.WriteLine("WaitAll() has not thrown exceptions. THIS WAS NOT EXPECTED.");
			//} 
			//catch (AggregateException e)
			//{
			//	Console.WriteLine("\nThe following exceptions have been thrown by WaitAll(): (THIS WAS EXPECTED)");
			//	for (int j = 0; j < e.InnerExceptions.Count; j++)
			//	{
			//		Console.WriteLine("\n-------------------------------------------------\n{0}",
			//			e.InnerExceptions[j].ToString());
			//	}
			//}

			//using (var testObj = new Person() {Name = "Adi"})
			//{

			//	DoSomething(testObj);
			//}

			//Regex from config
	        string numRegex = ConfigurationManager.AppSettings["num"];
	        Regex r = new Regex(numRegex,RegexOptions.Singleline);

			//string s = "!@#$%^jdfEU123&*()-=_+[];'<>?\"|\\987kds,./{}:\"fhHG";
			string s = "1a$F567*";
			//MatchCollection mc = r.Matches(s);
			//foreach (Match m in mc)
			//{
			//	Console.WriteLine(m.Value);
			//}
			Console.WriteLine(r.IsMatch(s));
			Console.WriteLine(Regex.IsMatch(s,numRegex));

			DateTime d1 = DateTime.Now;
			d1.AddDays(1);
			Console.WriteLine(d1.ToString());
			

			DateTest d = new DateTest();
	        d.dt = DateTime.Now;
	        d.dt.AddDays(1);
			Console.WriteLine(d.dt.ToString());


            long? l = null;
            Console.WriteLine("Nullable long: " + l.ToString() + "|");

            byte[] b = null;

            var a = DBNull.Value;
            int? i = (int?)a;

	        Console.ReadKey();
        }

	    private static void DoSomething(Person p)
	    {
			System.Threading.Thread.Sleep(5000);

			Console.WriteLine(p.Name);
	    }


    }

	internal class Person
	{
		public string Name;
	}

	class DateTest
	{
		public DateTime dt { get; set; }
	}
}
