namespace TreehouseDefense
{
	class ShieldedInvader : Invader
	{
		private static System.Random _random = new System.Random();
		
		public ShieldedInvader(Path path) : base(path)
        {}

		public override void TakeDamage(int factor)
        {
			if (_random.NextDouble() < .5)
            {
				base.TakeDamage(factor);
            }
			else
            {
				System.Console.WriteLine("Shot at a shielded invader, however sustained no damage");
            }
        }
	}
}
