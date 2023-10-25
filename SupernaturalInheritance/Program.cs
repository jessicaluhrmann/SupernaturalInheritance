namespace SupernaturalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Storm("wind", false, "Zul'rajas");
            var p = new Pupil("Mezil-kree");
            var m = new Mage("Gul’dan");
            var a = new Archmage("Nielas Aran");

            var ms = p.CastWindStorm();
            var gs = m.CastRainStorm();
            var nsr = a.CastRainStorm();
            var nsl = a.CastLightningStorm();

            Console.WriteLine(s.Announce());
            Console.WriteLine(ms.Announce());
            Console.WriteLine(gs.Announce());
            Console.WriteLine(nsr.Announce());
            Console.WriteLine(nsl.Announce());
        }
    }
}