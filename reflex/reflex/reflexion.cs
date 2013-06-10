using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace test1
{
	public class reflexion
	{
		public static string projetName;
		public static string className;
		
		private static Type t = Assembly.GetExecutingAssembly().GetType();
		
		public static Type setGetType(string s1, string s2)
		{
			t = Assembly.GetExecutingAssembly().GetType(s1+"."+s2);
				return t;
		
		}
		
		public static List<string> GetClasses(string nameSpace)
		{
		
			Assembly asm = Assembly.GetExecutingAssembly();
			
			List<string> namespacelist = new List<string>();
			List<string> classlist = new List<string>();
			
			foreach (Type type in asm.GetTypes())
			{
				if (type.Namespace == nameSpace)
				namespacelist.Add(type.Name);
			}
			
			foreach (string classname in namespacelist)
			classlist.Add(classname);
			
			return classlist;
			
		}
			
		public static string NomClasse() 
		{
			string className = t.Name;
			return className;
		}
		
		public static List<string> listAttributes(){
		
		List<string> list = t.GetFields(BindingFlags.Instance
                            	|BindingFlags.NonPublic|BindingFlags.Public)
									.Select(field => field.Name).ToList();
		List<string> cleanedList = new List<string>();
		Regex  myRegex = new Regex(@"<([\w]+)>");
			
			foreach (string j in list)
				{
				Match m = myRegex.Match(j);
				if(myRegex.IsMatch(j))
					cleanedList.Add(m.Groups[1].Value);
				}	
			return cleanedList;
		}
		public static List<string> listMethods() {
			List<string> l = new List<string>();
			foreach(MemberInfo Mi in t.GetMembers())
		    {
	             if (Mi.MemberType == MemberTypes.Method)
				 l.Add(Mi.ToString());
			}
			return l;
		}
		public static List<string> listChamps() {
			List<string> l = new List<string>();
			foreach(MemberInfo Mi in t.GetMembers())
		    {
	             if (Mi.MemberType == MemberTypes.Field)
				 l.Add(Mi.ToString());
			}
			return l;
		}
		public static List<string> listConstructor() {
			List<string> l = new List<string>();
			foreach(MemberInfo Mi in t.GetMembers())
		    {
	             if (Mi.MemberType == MemberTypes.Constructor)
				 l.Add(Mi.ToString());
			}
			return l;
		}
	}
	
		}
	

