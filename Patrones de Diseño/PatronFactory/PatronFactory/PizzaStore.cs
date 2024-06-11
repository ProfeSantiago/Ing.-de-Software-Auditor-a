using System;

namespace PatronFactory
{
	/// <summary>
	/// Summary description for PizzaStore.
	/// </summary>


	public abstract class PizzaStore
	{
		public PizzaStore()//Constructor
		{}
		
		public Pizza OrderPizza(string type)
		{
			Pizza pizza;			
			pizza = CreatePizza(type);
			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();
			return pizza;
		}
				
		protected abstract Pizza CreatePizza(string type);

    }//End PizzaStore

}
