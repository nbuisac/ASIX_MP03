// Numeros fins el 0
int numero, anterior, nombresEntrats;
bool esCreixent = true;

// llegim el primer valor
nombresEntrats = 0;
numero = Convert.ToInt32(Console.ReadLine());
if (numero != 0) {
    nombresEntrats++;
    anterior = numero;
    numero = Convert.ToInt32(Console.ReadLine());
    while (numero != 0) {
        nombresEntrats++;
        // tractem les dades
        if (anterior >= numero ) {
            esCreixent = false;
        }
        // preparem la següent interació
        anterior = numero;
        numero = Convert.ToInt32(Console.ReadLine());
    }
}
if (nombresEntrats < 2)
    Console.WriteLine("No hi ha prou nombres");
else if (esCreixent)
    Console.WriteLine("SI tota la sèrie es creixent");
else
    Console.WriteLine("NO tota la sèrie es creixent");
