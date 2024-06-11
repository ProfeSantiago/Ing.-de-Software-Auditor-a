using System;

namespace PatronFactory
{
	/// <summary>
	/// Summary description for NYPizzaStore.
	/// </summary>
    
	public class NYPizzaStore : PizzaStore
	{		
		public NYPizzaStore()//Constructor
		{}
		
		protected override Pizza CreatePizza(string type)
		{
			if(type.Equals("cheese"))
			{
				return new NYStyleCheesePizza();
			}
			else return null;
		}
		
	}
}
