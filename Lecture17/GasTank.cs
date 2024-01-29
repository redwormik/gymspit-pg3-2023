namespace Lecture17
{
	internal class GasTank
	{
		private double amount = 0;
		private double capacity;


		public GasTank(double capacity)
		{
			this.capacity = capacity;
		}


		public double Amount
		{
			get => amount;
		}


		public void Add(double amount)
		{
			if (this.amount + amount > capacity) {
				this.amount = capacity;
				throw new ArgumentException();
			}

			this.amount += amount;
		}


		public void Use(double amount)
		{
			if (this.amount < amount) {
				this.amount = 0;
				throw new ArgumentException();
			}

			this.amount -= amount;
		}
	}
}
