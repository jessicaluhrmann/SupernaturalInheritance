namespace SupernaturalInheritance
{
    class Storm
    {
        public string Essence { get; private set; }
        public bool IsStrong { get; private set; }
        public string Caster { get; private set; }

        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            Caster = caster;
            IsStrong = isStrong;
        }

        public string Announce()
        {
            if (IsStrong == true)
            {
                var description = $"{Caster} cast a strong {Essence} storm!";
                return description;
            }
            else
            {
                var description = $"{Caster} cast a weak {Essence} storm!";
                return description;
            }
        }
    }
}