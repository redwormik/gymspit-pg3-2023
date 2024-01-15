namespace Lecture15
{
	internal class Engine
	{
		private double kmPerHour;
		private double litersPerKm;


		public Engine(double kmPerHour, double litersPerKm)
		{
			this.kmPerHour = kmPerHour;
			this.litersPerKm = litersPerKm;
		}


		public double Run(double distance, GasTank tank)
		{
			double needed = distance * litersPerKm;
			tank.Use(needed);
			return distance / kmPerHour;
		}
	}
}
