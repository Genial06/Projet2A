// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2013-05-15 11:32:54Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//



using System;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using Gtk;

namespace reflex
{
	
public partial class Main : DataContext
{
	
	#region Extensibility Method Declarations
			partial void OnCreated();
		#endregion
	
	public Main(string connectionString) : base(connectionString)
	{
		this.OnCreated();
	}
	
	public Main(IDbConnection connection) : 
			base(connection)
	{
		this.OnCreated();
	}
	
	public Main(string connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public Main(IDbConnection connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public Table<Personne> Personne
	{
		get
		{
			return this.GetTable <Personne>();
		}
	}
}

[Table(Name="main.personne")]
public partial class Personne
{
	
	private System.Nullable<int> _four;
	
	private System.Nullable<int> _one;
	
	private string _three;
	
	private string _two;
	
	#region Extensibility Method Declarations
			partial void OnCreated();
		
			partial void OnFourChanged();
		
			partial void OnFourChanging(System.Nullable<int> value);
		
			partial void OnOneChanged();
		
			partial void OnOneChanging(System.Nullable<int> value);
		
			partial void OnThreeChanged();
		
			partial void OnThreeChanging(string value);
		
			partial void OnTwoChanged();
		
			partial void OnTwoChanging(string value);
		#endregion
	
	public Personne()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_four", Name="four", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> Four
	{
		get
		{
			return this._four;
		}
		set
		{
			if ((_four != value))
			{
				this.OnFourChanging(value);
				this._four = value;
				this.OnFourChanged();
			}
		}
	}
	
	[Column(Storage="_one", Name="one", DbType="integer", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public System.Nullable<int> One
	{
		get
		{
			return this._one;
		}
		set
		{
			if ((_one != value))
			{
				this.OnOneChanging(value);
				this._one = value;
				this.OnOneChanged();
			}
		}
	}
	
	[Column(Storage="_three", Name="three", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Three
	{
		get
		{
			return this._three;
		}
		set
		{
			if (((_three == value) == false))
			{
				this.OnThreeChanging(value);
				this._three = value;
				this.OnThreeChanged();
			}
		}
	}
	
	[Column(Storage="_two", Name="two", DbType="varchar", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Two
	{
		get
		{
			return this._two;
		}
		set
		{
			if (((_two == value) == false))
			{
				this.OnTwoChanging(value);
				this._two = value;
				this.OnTwoChanged();
			}
		}
	}
}
}