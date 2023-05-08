// Llista 4 - Exercici 35
int BASE = 16;
string strBinari;
int numeroDecimal;
int residu, divisio;
Console.WriteLine($"Decimal a base {BASE}");
Console.Write("Entra un nombre enter positiu -> ");
numeroDecimal = Convert.ToInt32(Console.ReadLine());
strBinari = "";
divisio = numeroDecimal;
while (divisio != 0) {
    // Caculem el dígit
    residu = divisio % BASE;
    if (residu < 10) {
        strBinari = (char)('0' + residu) + strBinari;
    }
    else {
        strBinari = (char)('A' + (residu - 10)) + strBinari;
    }
    // Preparem la següent interació
    divisio = divisio / BASE;
}
Console.WriteLine($"{numeroDecimal} a base {BASE} és {strBinari}");

