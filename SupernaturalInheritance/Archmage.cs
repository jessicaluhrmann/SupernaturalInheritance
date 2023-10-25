namespace SupernaturalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        {
            Title = title;
        }

        public override Storm CastRainStorm()
        {
            var s = new Storm("rain", true, Title);
            return s;
        }

        public Storm CastLightningStorm()
        {
            var s = new Storm("lightning", true, Title);
            return s;
        }
    }
}