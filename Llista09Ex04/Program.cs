namespace Llista09Ex04;
class Program
{
    static bool ValorExistent(int n, int[] combi, int posicioMaxima) {
        bool hiEs = false;
        int i = 0;
        while (! hiEs && i <= posicioMaxima && i < combi.Length) {
            hiEs = (combi[i] == n);
            i++;
        }
        return hiEs;

    }
    static void GeneraCombinacio(int[] combinacio) {
        Random r = new Random();
        bool hiEs;
        int n;
        for (int i = 0; i < 6; i++) {
            do {
                n = r.Next(1, 50);
                hiEs = ValorExistent(n, combinacio, i -1);
            } while (hiEs);
            combinacio[i] = n;
        }
    }
    static void EscriuCombinacio(int[] combi, StreamWriter f) {
        for(int i = 0; i < combi.Length; i++) {
            f.Write($"{combi[i],2} ");
        }
        f.WriteLine();
    }
    static void Main(string[] args)
    {
        StreamWriter f01;
        int[] combinacio;
        combinacio = new int[6];
        f01 = new StreamWriter("./f04.txt");
        for(int i = 0; i < 1000000; i++) {
            GeneraCombinacio(combinacio);
            EscriuCombinacio(combinacio, f01);
        }
        f01.Close();
    }
}
