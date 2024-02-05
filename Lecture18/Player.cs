namespace Lecture18
{
	internal class Player : Character
	{
		private TextReader input;

		private TextWriter? prompt;

		public Player(string name, int maxHitPoints, int attack, int defense, TextReader input, TextWriter? prompt = null) :
			base(name, maxHitPoints, attack, defense)
		{
			this.input = input;
			this.prompt = prompt;
		}


		protected override string ChooseAction()
		{
			while (true) {
				if (prompt != null) {
					prompt.WriteLine("Choose an action:");
					prompt.WriteLine("(A)ttack (attack {0})", Attack);
					prompt.WriteLine("(W)ait");
				}

				string choice = input.ReadLine();
				if (choice == null) {
					return null;
				}

				switch (choice.ToLower()) {
					case "a":
					case "attack":
						return TURN_CHOICE_ATTACK;
					case "w":
					case "wait":
						return TURN_CHOICE_WAIT;
				}

				if (prompt != null) {
					prompt.WriteLine("Invalid choice!");
				}
			}
		}
	}
}
