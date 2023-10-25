namespace SupernaturalInheritance
{
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        {
            this.Title = title;
        }

        public virtual Storm CastRainStorm()
        {
            var s = new Storm("rain", false, Title);
            return s;
        }
    }
}