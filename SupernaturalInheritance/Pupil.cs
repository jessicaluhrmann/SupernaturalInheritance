namespace SupernaturalInheritance
{
    class Pupil
    {
        public string Title { get; protected set; }

        public Pupil(string title)
        {
            Title = title;
        }

        public Storm CastWindStorm()
        {
            var s = new Storm("wind", false, Title);
            return s;
        }
    }
}