namespace Lecture17
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


		public double Run(Car car, double distance, GasTank tank)
		{
			double litersPerKm = this.litersPerKm + car.LitersPerKm;
			double needed = distance * litersPerKm;
			tank.Use(needed);
			return distance / kmPerHour;
		}
	}
}
