namespace Redaiora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            jatek j1 = new();

            j1.Termek = "Uno";
            j1.Kategoria = "kártyajáték";
            j1.Ar = 6890;
            j1.Keszlet = 500;

            Console.WriteLine(j1.Termek);

            Console.WriteLine(j1);


            List<jatek> jatekok = new();
            {
                new jatek("Uno", "Kártyajáték", 6890, 500);
                new jatek("Monopoly", "Társasjáték", 9990, 100);

            }
            Console.WriteLine("Raktár tartalma:");
            jatekok.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Foreachel végig iterálva az elemeken:");
            jatekok.ForEach(Console.WriteLine);

            Console.WriteLine("Társasjátékok:");
            var tarsasjatekok=jatekok.Where(j => j.Kategoria == "Társasjáték").ToList();
            tarsasjatekok.ForEach(jatekok => Console.WriteLine(jatekok.Termek));
            Console.WriteLine("Kártyajátékok");
            var kartyajatekok=jatekok.Where(j=>j.Kategoria=="Kártyajáték").ToList();
            tarsasjatekok.ForEach(jatekok => Console.WriteLine("/t-" + jatekok.Termek));

            Console.WriteLine("n Legdrágább játék:");
            var legdragabb= jatekok.OrderByDescending(j=> j.Ar).First();
            Console.WriteLine(legdragabb.Termek+ " " + legdragabb.Ar + "HUF");

            Console.WriteLine("/n Kevesebb drab van raktáron mint 200 db:");
            var kevesebb=jatekok.Where(j=> j.Keszlet> 200).ToList();
            tarsasjatekok.ForEach(j => Console.WriteLine("/t-" + j.Termek + " " + j.Keszlet + "db"));






        }
    }
}
