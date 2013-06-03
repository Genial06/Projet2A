using System;
using System.Reflection;

namespace test1
{
	public class ProgramReflex
	{
		public ProgramReflex ()
		{
		}
		static void Main(string[] args)
		{
			new Attributs().Demo();
		}
	}
			
			public class Attributs
			{
				public void Demo()
				{
				Personne pers = new Personne();
				
				VoirDescription(Personne);
				
				}
			
				public void VoirDescription<T>(T obj)
				{
					System.Type type = typeof(T);
					if (!type.IsClass)
					return;
				
					Attribute[] Attrib = Attribute.GetCustomAttributes(type, typeof(DescriptionClasseAttribute));
					
					if (Attrib.Length == 0)
						Console.WriteLine("Pas de description pour la classe " + type.Name + "\n");
					else
					{
						Console.WriteLine("Description pour la classe " + type.Name);
						foreach (DescriptionClasseAttribute attribut in Attrib)
						{
							Console.WriteLine("\t" + attribut.Description);
						}
					}
			
				}
			}
}

