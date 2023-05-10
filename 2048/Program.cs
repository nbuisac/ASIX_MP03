namespace _2048;
class Taulell {
    private int[,] t;

    public  Taulell() {
        t = new int[4,4];
    }

    public void MouAmunt() {
        // Anirem de baix a dalt i deixarem, si n'hi ha dos iguals , el doble a baix
        for (int i = 0; i < t.GetLength(0); i++) {
            for (int j = 0; j < t.GetLength(1); j++) {
                if (t[i, j] != 0) {
                    // a partir d'una posició miro si hi ha 0s seguits i/o un numero com el meu [i,j]
                    int ii = i + 1;
                    while (ii < t.GetLength(0) - 1 && t[ii,j] == 0 ) ii++;
                    if (t[i,j] == t[ii, j]) {
                        t[i, j] *= 2;
                        t[ii, j] = 0;
                    }
                }
            }
        }
    }

    public void Mostra() {
        // Console.Clear();
        for(int i = 0; i < t.GetLength(0); i++) {
            for(int j = 0; j < t.GetLength(1); j++) {
                Console.Write($"{t[i,j], 6}");
            }
            System.Console.WriteLine();
        }
    }

    public bool PosaUn() {
        (int, int) Propera(int i, int j) {
            j = (j + 1) % t.GetLength(1);
            if (j == 0) i = (i + 1) % t.GetLength(0);
            return(i, j);
        }
        Random r = new Random();
        bool retorn = false;

        int fi, ci;
        int fn, cn;
        // Generem la posicio a omplir aleatoriament
        fn = r.Next(t.GetLength(0));
        cn = r.Next(t.GetLength(1));
        // Si  aquesta està plena...
        if (t[fn, cn] != 0) {
            fi = fn;
            ci = cn;
            do {
                (fn, cn) = Propera(fn, cn);
            } while (t[fn, cn] != 0 && (fi != fn || ci != cn));
        }
        if (t[fn, cn] == 0) {
            retorn = true;
            t[fn, cn] = 2;
        }
        return retorn;
    }
    public bool Final() {
        bool f = true;
        int i, j;
        i = 0;
        while (i < t.GetLength(0) && f) {
            j = 0;
            while (j < t.GetLength(1) && f) {
                f = (t[i, j] != 0);
                j++;
            }
            i++;
        }
        return f;
    }
}

class Program
{
    private static ConsoleKeyInfo DemanaMoviment() {
        ConsoleKeyInfo ki;
        do {
            ki = Console.ReadKey(true);
        } while (ki.Key != ConsoleKey.UpArrow && 
                 ki.Key != ConsoleKey.DownArrow && 
                 ki.Key != ConsoleKey.LeftArrow && 
                 ki.Key != ConsoleKey.RightArrow);
        return ki;
    }
    static void Main(string[] args)
    {
        Taulell taulell;
        ConsoleKeyInfo tecla;
        // bool final = false;
        
        taulell = new Taulell();

        taulell.Mostra();
        // Omplim el taulell inicial
        taulell.PosaUn();
        taulell.PosaUn();
        // Mostrem el taulell inicial
        taulell.Mostra();
        int i = 2;
        while (! taulell.Final()) {
            tecla = DemanaMoviment();
            switch (tecla.Key) {
                case ConsoleKey.UpArrow:
                    taulell.MouAmunt();
                    Console.WriteLine("Up");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("Left");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Right");
                    break;
            }
            taulell.PosaUn();
            // Mostrem el taulell inicial
            taulell.Mostra();
            Console.WriteLine(++i);

        }
        
    }
}
