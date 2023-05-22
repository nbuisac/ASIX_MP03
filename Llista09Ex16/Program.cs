namespace Llista09Ex16;
class Program
{
        // iniciPartida = DateTime.Now;
        // finalPartida = DateTime.Now;

        // Console.WriteLine(finalPartida - iniciPartida);

    static void EscriuTitol(string t) {
        Console.Clear();
        Console.WriteLine(t);
        Console.WriteLine("".PadLeft(t.Length, '='));
    }
    static string DemanaNom() {
        string nom;
        Console.Write("Entra el teu nom -> ");
        nom = Console.ReadLine();
        return nom;
    }
    static int InventaNumero(int m) {
        Random r;
        r = new Random();
        return(r.Next(1, m + 1));
        
    }
    static int DemanaNumero(int maxim) {
        int n;
        bool ok;
        
        do {
            Console.Write($"Entra un número de l'1 al {maxim} -> ");
            ok = int.TryParse(Console.ReadLine(), out n);
        } while (!ok || (n < 1 || n > maxim));
        return n;

    }
    static void EscriureResultats( string nom, int numeroAEncertar, bool encertat, int tirades, TimeSpan temps) {
        StreamWriter f01;
        string quePoso = encertat?"SI":"NO";

        Console.WriteLine($"{nom}:{numeroAEncertar}:{quePoso}:{tirades}:{temps}");  
        try {
            f01 = new StreamWriter("resultats.txt", true);
            f01.WriteLine($"{nom}:{numeroAEncertar}:{quePoso}:{tirades}:{temps}");
            f01.Close();
        }
        catch (Exception e) {
            Console.WriteLine("No s'ha guardat el fitxer de resultats.");
        }
    }

    static bool TornaHi() {
        char siNo;
        Console.Write("Una altra partida? ");
        do {
            siNo = Console.ReadKey(true).KeyChar;
            siNo = Char.ToUpper(siNo);
        } while (siNo != 'S' && siNo != 'N');
        Console.WriteLine(siNo);

        return (siNo == 'S');


    }
    static void Main(string[] args)
    {
        const int MAX_TIRADES = 3;
        const int NUMERO_MAXIM = 50;
        string nomJugador, nomFitxer;
        DateTime iniciPartida, finalPartida;
        
        int numeroAEncertar, numero, tirades;
        EscriuTitol("Encerta el numero!");
        nomJugador = DemanaNom();
        do {
            numeroAEncertar = InventaNumero(NUMERO_MAXIM);
            System.Console.WriteLine(numeroAEncertar);
            // Anem a jugar
            iniciPartida = DateTime.Now;
            numero = DemanaNumero(NUMERO_MAXIM);
            tirades = 1;
            while (numero != numeroAEncertar && tirades < MAX_TIRADES) {
                Console.WriteLine("No....");
                numero = DemanaNumero(NUMERO_MAXIM);
                tirades++;
            }
            finalPartida = DateTime.Now;
            if (numero == numeroAEncertar) {
                Console.WriteLine($"Molt bé! L'has encertat en {tirades} tirades");
            } else {
                Console.WriteLine($"Llastima! El número era el {numeroAEncertar}");
            }
            EscriureResultats(nomJugador, numeroAEncertar, numero == numeroAEncertar, tirades, finalPartida - iniciPartida);
        } while (TornaHi());
    }
}
