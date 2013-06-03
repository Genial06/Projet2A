using System;

namespace reflex
{
public class Personne_ : Attribute
{
private int index;
private string firstname;
private string lastname;
private int age;

public Personne_ ()
{
this.index = 0;
this.firstname = "";
this.lastname = "";
this.age = 0;
}

public void personne_(int id, string fname, string lname, int age)
{
this.index = id;
this.firstname = fname;
this.lastname = lname;
this.age = age;
}

public void setIndex(int id)
{
this.index = id;
}
public int getIndex()
{
return this.index;
}
public void setFName(string f)
{
this.firstname = f;
}
public string getFName()
{
return this.firstname;
}

public void setLName(string l)
{
this.lastname = l;
}
public string getLName()
{
return this.lastname;
}
public void setAge(int age)
{
this.age = age;
}
public int getAge()
{
return this.age;
}
public string toString(){
	 string s = age.ToString();
     return "Personne: " + firstname +" "+ lastname + " " + s;
		}		

	
}}