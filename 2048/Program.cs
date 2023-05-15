namespace _2048;
class Taulell {
    private int[,] t;

    public  Taulell() {
        t = new int[4,4];
    }

    public bool PotsAmunt() {
        bool pots = false;
        // Es pot anar amunt quan hi ha algun 0 en les files inicials i després un valor
        int i, j;
        j = 0;
        while (! pots && j < t.GetLength(1)) {
            // Comprovem la columna
            i = 0;
            while (! pots && i < t.GetLength(0) - 1) {
                pots = (t[i,j] == 0 && t[i+1,j] != 0)  || (t[i,j] != 0 && t[i,j] == t[i + 1,j]);
                i++;
            }
            j++;
        }

        return pots;
    }
    public bool PotsAvall() {
        bool pots = false;

        int i, j;
        j = 0;
        while (! pots && j < t.GetLength(1)) {
            // Comprovem la columna
            i = t.GetLength(0) - 1;
            while (! pots && i > 0) {
                pots = (t[i,j] == 0 && t[i-1,j] != 0)  || (t[i,j] != 0 && t[i,j] == t[i -1,j]);
                i--;
            }
            j++;
        }
        return pots;
    }
    public bool PotsEsquerra() {
        bool pots = false;

        int i, j;
        i = 0;
        while (! pots && i < t.GetLength(0)) {
            // Comprovem la columna
            j = 0;
            while (! pots && j < t.GetLength(1) - 1) {
                pots = (t[i,j] == 0 && t[i,j+1] != 0) || (t[i,j] != 0 && t[i,j] == t[i,j+1]);
                j++;
            }
            i++;
        }

        return pots;
    }
    public bool PotsDreta() {
        bool pots = false;

        int i, j;
        i = 0;
        while (! pots && i < t.GetLength(0)) {
            // Comprovem la columna
            j = t.GetLength(1) - 1;
            while (! pots && j > 0) {
                pots = (t[i,j] == 0 && t[i,j-1] != 0)  || (t[i,j] != 0 && t[i,j] == t[i,j-1]);
                j--;
            }
            i++;
        }

        return pots;
    }
    public void MouAmunt() {
        int i, ii, j;
        i = ii = j = 0;
        // Anirem de baix a dalt i deixarem, si n'hi ha dos iguals , el doble a baix
        for (i = 0; i < t.GetLength(0) - 1; i++) {
            for (j = 0; j < t.GetLength(1); j++) {
                if (t[i, j] != 0) {
                    // a partir d'una posició miro si hi ha 0s seguits i/o un numero com el meu [i,j]
                    ii = i + 1;
                    while (ii < t.GetLength(0) - 1 && t[ii,j] == 0 ) ii++;
                    if (t[i,j] == t[ii, j]) {
                        t[i, j] *= 2;
                        t[ii, j] = 0;
                    }
                }
            }
        }
        // Treiem els 0s que queden en la part inferior...
        for (j = 0; j < t.GetLength(1); j++) {
            i = 0;
            ii = i + 1;
            // Cerquem el 1r lloc on hi podem posar quelcom
            do  {
                while (i < t.GetLength(0) - 1 && t[i,j] != 0) i++;
                ii = i + 1;
                while (ii < t.GetLength(0) - 1 && t[ii,j] == 0) ii++;
                if (i != ii && ii < t.GetLength(0)) {
                    t[i,j] = t[ii,j];
                    t[ii,j] = 0;
                }
                i++;
            } while (i < t.GetLength(0) - 1);
        }
    }

    public void MouAvall() {
        int i, ii, j;
        i = ii = j = 0;
        // Anirem de baix a dalt i deixarem, si n'hi ha dos iguals , el doble a dalt
        for (i = t.GetLength(0) - 1; i > 0 ; i--) {
            for (j = 0; j < t.GetLength(1); j++) {
                if (t[i, j] != 0) {
                    // a partir d'una posició miro si hi ha 0s seguits i/o un numero com el meu [i,j]
                    ii = i - 1;
                    while (ii > 0 && t[ii,j] == 0 ) ii--;
                    if (t[i,j] == t[ii, j]) {
                        t[i, j] *= 2;
                        t[ii, j] = 0;
                    }
                }
            }
        }
        // Treiem els 0s que queden en la part inferior...
        for (j = 0; j < t.GetLength(1); j++) {
            i = t.GetLength(0) - 1;
            // Cerquem el 1r lloc on hi podem posar quelcom
            do  {
                while (i > 0 && t[i,j] != 0) i--;
                ii = i - 1;
                while (ii > 0 && t[ii,j] == 0) ii--;
                if (i != ii && ii >= 0) {
                    t[i,j] = t[ii,j];
                    t[ii,j] = 0;
                }
                i--;
            } while (i > 0);
        }
    }

    public void MouEsquerra() {
        int i, j, jj;
        i = jj = j = 0;
        // Anirem de baix a dalt i deixarem, si n'hi ha dos iguals , el doble a baix
        for (j = 0; j < t.GetLength(1) - 1; j++) {
            for (i = 0; i < t.GetLength(0); i++) {
                if (t[i, j] != 0) {
                    // a partir d'una posició miro si hi ha 0s seguits i/o un numero com el meu [i,j]
                    jj = j + 1;
                    while (jj < t.GetLength(1) - 1 && t[i,jj] == 0 ) jj++;
                    if (t[i,j] == t[i, jj]) {
                        t[i, j] *= 2;
                        t[i, jj] = 0;
                    }
                }
            }
        }
        // Treiem els 0s que queden en la part inferior...
        for (i = 0; i < t.GetLength(0); i++) {
            j = 0;
            jj = j + 1;
            // Cerquem el 1r lloc on hi podem posar quelcom
            do  {
                while (j < t.GetLength(1) - 1 && t[i,j] != 0) j++;
                jj = j + 1;
                while (jj < t.GetLength(1) - 1 && t[i,jj] == 0) jj++;
                if (j != jj && jj < t.GetLength(1)) {
                    t[i,j] = t[i,jj];
                    t[i,jj] = 0;
                }
                j++;
            } while (j < t.GetLength(1) - 1);
        }
    }

    public void MouDreta() {
        int i, jj, j;
        i = jj = j = 0;
        // Anirem de baix a dalt i deixarem, si n'hi ha dos iguals , el doble a dalt
        for (j = t.GetLength(1) - 1; j > 0 ; j--) {
            for (i = 0; i < t.GetLength(0); i++) {
                if (t[i, j] != 0) {
                    // a partir d'una posició miro si hi ha 0s seguits i/o un numero com el meu [i,j]
                    jj = j - 1;
                    while (jj > 0 && t[i,jj] == 0 ) jj--;
                    if (t[i,j] == t[i, jj]) {
                        t[i, j] *= 2;
                        t[i, jj] = 0;
                    }
                }
            }
        }
        // Treiem els 0s que queden en la part inferior...
        for (i = 0; i < t.GetLength(0); i++) {
            j = t.GetLength(1) - 1;
            // Cerquem el 1r lloc on hi podem posar quelcom
            do  {
                while (j > 0 && t[i,j] != 0) j--;
                jj = j - 1;
                while (jj > 0 && t[i,jj] == 0) jj--;
                if (j != jj && jj >= 0) {
                    t[i,j] = t[i,jj];
                    t[i,jj] = 0;
                }
                j--;
            } while (j > 0);
        }
    }
    public void Mostra() {
        Console.Clear();
        for(int j = 0; j < t.GetLength(0); j++) {
            Console.Write("#--------");
        }
        Console.WriteLine("#");
        for(int i = 0; i < t.GetLength(0); i++) {
            for(int j = 0; j < t.GetLength(1); j++) {
                Console.Write($"{(j==0?"# ":"  ")}{(t[i,j]==0?"·":t[i,j]), 6} ");
            }
            Console.WriteLine("#");
        }
        for(int j = 0; j < t.GetLength(0); j++) {
            Console.Write("#--------");
        }
        Console.WriteLine("#");
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
        // Cal determinar quan s'ha acabat
        // S'acabarà quan no es pugui tirar, és a dir, quan 
        // no hi hagi cap 0 
        // no hi hagi dues cel·les contigues amb el mateix valor
        bool f = true;
        int i, j;
        i = 0;
        while (i < t.GetLength(0) && f) {
            j = 0;
            while (j < t.GetLength(1) && f) {
                f = (t[i, j] != 0); // cel·la buida
                // Comprovem les del voltant (no sempre)
                // només la de la dreta i la de baix.
                if (f) {
                    if (i < t.GetLength(0) - 1 && t[i,j] == t[i+1, j])
                        f = false;
                }
                if (f) {
                    if (j < t.GetLength(1) - 1 && t[i,j] == t[i, j+1])
                        f = false;
                }
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
        bool ok = false;
        
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
                    if (taulell.PotsAmunt()) {
                        taulell.MouAmunt();
                        taulell.PosaUn();
                        ok = true;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (taulell.PotsAvall()) {
                        taulell.MouAvall();
                        taulell.PosaUn();
                        ok = true;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (taulell.PotsEsquerra()) {
                        taulell.MouEsquerra();
                        taulell.PosaUn();
                        ok = true;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (taulell.PotsDreta()) {
                        taulell.MouDreta();
                        taulell.PosaUn();
                        ok = true;
                    }
                    break;
            }
            // Mostrem el taulell inicial
            if (ok) {
                taulell.Mostra();
                if (tecla.Key == ConsoleKey.UpArrow) Console.Write("Amunt -- ");
                else if (tecla.Key == ConsoleKey.DownArrow) Console.Write("Avall -- ");
                else if (tecla.Key == ConsoleKey.LeftArrow) Console.Write("Esquerra -- ");
                else if (tecla.Key == ConsoleKey.RightArrow) Console.Write("Dreta -- ");
                Console.WriteLine(++i);
                ok = false;
            }

        }
        
    }
}