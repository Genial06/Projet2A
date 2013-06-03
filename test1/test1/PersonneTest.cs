using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
			 
namespace test1
{
	public class PersonneTest
	{
		public int Index{ get; set; }
		public string Firstname{ get; set; }
		public string Lastname{ get; set; }
		public int Age{ get; set; }
		
		public PersonneTest ()
		{
			this.Index = 0;
			this.Firstname = "";
			this.Lastname = "";
			this.Age = 0;
		}
		
		public void personneTest(int id, string fname, string lname, int age)
		{
			this.Index = id;
			this.Firstname = fname;
			this.Lastname = lname;
			this.Age = age;
		}
		
		public void Identify() 
		{
			Console.WriteLine("[{0}, {1}, {2}, {3}]", Index, Firstname, Lastname, Age);
		}
		
}

}