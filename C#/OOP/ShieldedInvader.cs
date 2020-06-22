namespace TreehouseDefense
{
	class ShieldedInvader : Invader
	{
	
		public ShieldedInvader(Path path) : base(path)
        {}

		public override void TakeDamage(int factor)
        {
			if (Random.NextDouble() < .5)
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
