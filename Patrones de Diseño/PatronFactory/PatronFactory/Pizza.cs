using System;
using System.Collections;
using System.Text;

namespace PatronFactory
{
	public abstract class Pizza
	{
		//Members
		protected string name;
		protected string dough;
		protected string sauce;
		protected ArrayList toppings = new ArrayList();
			
		public Pizza()//Constructor
		{}
		
		public string Prepare()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Preparing " + name + "\n");
			sb.Append("Tossing " + dough + "\n");
			sb.Append("Adding " + sauce + "\n");
			sb.Append("Adding toppings:" + "\n");

			foreach(string topping in toppings)
			{
				sb.Append("\t" + topping + "\n");
			}

			return sb.ToString();
		}
		
		public virtual string Bake()
		{
			return "Bake for 25 minutes at 350 \n";
		}
		
		public virtual string Cut()
		{
			return "Cutting the pizza into diagonal slices \n";
		}

		public virtual string Box()
		{
			return "Place pizza in official PizzaStore box \n";
		}

		public string GetName()
		{
			return name;
		}
	}
}
