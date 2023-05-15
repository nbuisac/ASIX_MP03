namespace Llista09Ex07;
class Program
{
    static void Troba3Posicions(char c, string l, out int p1, out int p2, out int p3) {
        p1 = 0;
        while(l[p1] != c) p1++;
        p2 = p1 + 1;
        while(l[p2] != c) p2++;
        p3 = p2 + 1;
        while(l[p3] != c) p3++;
        
    }
    static void Main(string[] args)
    {
        StreamReader f01;
        string linia;
        string nom;
        int o1, o2, o3;
        int uid;
        f01 = new StreamReader("passwd");

        while (! f01.EndOfStream) {
            // llegir les dades
            linia = f01.ReadLine();
            // tractar les dades
            // Primera
            // Troba3Posicions(':', linia, out o1, out o2, out o3);
            // nom = linia.Substring(0, o1);
            // uid = Convert.ToInt32(linia.Substring(o2 + 1, o3 - o2 - 1));
            // Console.WriteLine($"{nom, 10} -- {uid, 4}");

            // Segona
            o1 = linia.IndexOf(":");
            o2 = linia.IndexOf(":", o1 + 1);
            o3 = linia.IndexOf(":", o2 + 1);
            nom = linia.Substring(0, o1);
            uid = Convert.ToInt32(linia.Substring(o2 + 1, o3 - o2 - 1));
            Console.WriteLine($"{nom, 10} -- {uid, 4}");
            // //Tercera
            // string[] tots;
            // tots = linia.Split(':');
            // Console.WriteLine($"{tots[0], 10} -- {int.Parse(tots[2]), 4}");


        
        }
        f01.Close();
    }
}
