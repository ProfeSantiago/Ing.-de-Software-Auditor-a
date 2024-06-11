using System;

namespace PatronObserver
{
	/// <summary>
	/// IObserver
	/// </summary>

	public interface IObserver
	{
		void Update(float temperature, float humidity,
			float pressure);
	}
}
