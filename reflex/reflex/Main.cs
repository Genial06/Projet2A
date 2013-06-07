
using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.IO;



namespace reflex
{


	class MainClass  {
		
		/*public static Type GetType(string typeName)
	        {
	            var type = Type.GetType(typeName);
	            if (type != null) return type;
	            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
	            {
	                type = a.GetType(typeName);
	                if (type != null)
	                    return type;
	            }
	            return null ;
	        }*/


	
		
		static List<string> GetClasses(string nameSpace)
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
			
	public static void Main (string[] args){
			
			Console.WriteLine("saisir le nom d'un projet  ");
			string s1 = Console.ReadLine();
				
			
				List<string> l = GetClasses(s1);
				
				foreach (string j  in l)
				{
						
				   Console.WriteLine("Classe : {0}",j);
				}	
			
				
			//string str = "Personne_" ;	
			Type t = typeof(Type);
			//Type t = typeof(Personne_);	
			Console.WriteLine("saisir le nom de la classe  ");		
			string  s = Console.ReadLine();
			if (GetClasses("reflex").Contains(s) == true){	
					
			 t = Assembly.GetExecutingAssembly().GetType(s1+"."+s);
			Console.WriteLine(t.FullName);}
			
			else {
			Console.WriteLine("cette classe n'existe pas ");
				}
			//string className =t.Name;
			//Console.WriteLine("Nom de la classe : {0}", className.ToString());
			
			if (t.IsInterface == true)	
					Console.WriteLine(" c'est une interface ");
			else if (t.IsClass == true )	
				    Console.WriteLine(" c'est une classe  ");
				
			List<string> list = t.GetFields(BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public).Select(field => field.Name).ToList();
			    foreach (string i in list)
					{
				     Console.WriteLine("Attributs : {0}",i);
					}	
						
			foreach(MemberInfo Mi in t.GetMembers())
					
	          {
		             if (Mi.MemberType == MemberTypes.Method)
				      Console.WriteLine("Méthode : {0}", Mi.ToString());
					 else if (Mi.MemberType == MemberTypes.Field)
		              Console.WriteLine("Champs : {0}", Mi.ToString());
					 else if (Mi.MemberType == MemberTypes.Constructor)
					 Console.WriteLine("Constructeur : {0}", Mi.ToString());
	        
					}
				
			
			//PropertyInfo numberPropertyInfo = t.GetProperty("index");
			
			//	Console.WriteLine("propriété :", numberPropertyInfo.ToString());
				//private static List<string> list = new ArrayList();
				//MainClass.list.Add(this);
				
			
				
				
				Console.WriteLine(" voulez vous créer une instance de cette classe ? Y/N");
				string  s2 = Console.ReadLine();
				if( s2 == "N")
					Console.WriteLine("Merci de votre visite ");
				else if (s2 == "Y"){
							
			     System.Type objType = System.Type.GetType("reflex."+s);
	
	            // Vérification si le type a bien été retrouvé
	            if (objType != null)
	            {
	                
	             
					
					Console.WriteLine("Veuillez choisir l'une de ces méthodes");
					string str = Console.ReadLine();
					//objType.GetMethods(str);
					 object objInstanceDynamique = System.Activator.CreateInstance(objType);
					 // Casting de l'objet
	                Personne_ objPersonne = objInstanceDynamique as Personne_;
														
					objPersonne.personne_(1,"ryad","kacimi",24);
						
			foreach(MemberInfo Mi in t.GetMembers())
					
	          {	
					if (Mi.MemberType == MemberTypes.Method){
					    Console.WriteLine("Méthode : {0}", Mi.ToString());
						}
						
					   if (Mi.ToString().Contains(Console.ReadLine()) == true)
									
						 Console.WriteLine(	objPersonne.getAge().ToString());
			
	            else
	            {
	                System.Console.WriteLine("Le type semble être incorrect!");
								}
							}
						}
					}
				}
			}
		}
							