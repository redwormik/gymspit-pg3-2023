namespace Lecture18
{
	internal abstract class Character
	{
		protected const string TURN_CHOICE_ATTACK = "attack";
		protected const string TURN_CHOICE_WAIT = "wait";

		private string name;

		private int hitPoints;

		private int maxHitPoints;

		private int attack;

		private int defense;

		public string Name => name;

		public int HitPoints => hitPoints;

		public int MaxHitPoints => maxHitPoints;

		public bool Alive => hitPoints > 0;

		public int Attack => attack;

		public int Defense => defense;


		public Character(string name, int maxHitPoints, int attack, int defense)
		{
			this.name = name;
			this.maxHitPoints = maxHitPoints;
			this.attack = attack;
			this.defense = defense;
			Reset();
		}


		public void Reset()
		{
			hitPoints = maxHitPoints;
		}


		protected abstract string ChooseAction();


		public void TakeTurn(TextWriter output, Character enemy, Die die)
		{
			string action = ChooseAction();

			switch (action) {
				case TURN_CHOICE_ATTACK:
					AttackEnemy(output, enemy, die);
					break;

				case TURN_CHOICE_WAIT:
					Wait(output, die);
					break;

				default:
					output.WriteLine("{0} does nothing...", name);
					break;
			}
		}


		private void AttackEnemy(TextWriter output, Character enemy, Die die)
		{
			int attackRoll = attack + die.Roll();
			enemy.ReceiveAttack(output, attackRoll, die);
		}


		private void ReceiveAttack(TextWriter output, int attackRoll, Die die)
		{
			int defenseRoll = defense + die.Roll();
			int damage = attackRoll - defenseRoll;

			if (damage > 0) {
				hitPoints -= damage;
				output.WriteLine("{0} takes {1} damage!", name, damage);
			} else {
				output.WriteLine("{0} takes no damage!", name);
			}
		}


		private void Wait(TextWriter output, Die die)
		{
			output.WriteLine("{0} waits and rolls a die...", name);
			output.WriteLine("They rolled a {0}!", die.Roll());
		}
	}
}
