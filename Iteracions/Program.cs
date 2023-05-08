// Proves iteracions
// const int MINIM = 100, MAXIM = 1000, MAX_INTENTS = 5;
// Random random = new Random();
// int numeroInventat, numeroUsuari;
// int comptador;
// numeroInventat = random.Next(MINIM, MAXIM + 1);
// Console.WriteLine(numeroInventat);

// Console.WriteLine($"Encerta el numero {MINIM}..{MAXIM}");
// numeroUsuari = Convert.ToInt32(Console.ReadLine());
// comptador = 1;
// // A
// while (numeroInventat != numeroUsuari && comptador < MAX_INTENTS) { // No s'ha encertat
//     // B
//     if (numeroInventat < numeroUsuari) {
//         Console.WriteLine("Menor!!!");
//     } else {
//         Console.WriteLine("Major!!!");
//     }
//     Console.WriteLine($"Encerta el numero {MINIM}..{MAXIM}");
//     numeroUsuari = Convert.ToInt32(Console.ReadLine());
//     comptador = comptador + 1;
//     // C
// }
// // D
// if (numeroInventat == numeroUsuari) {
//     Console.WriteLine($"L'has encertat en {comptador} intents");
// } else {
//     Console.WriteLine($"En {comptador} intents no l'has encertat, era el {numeroInventat}");
// }





















int nota1, nota2;
do {
    Console.Write("Entra una nota 1..10 -> ");
    nota1= Convert.ToInt32(Console.ReadLine());
    if (nota1 < 1 || nota1 > 10) {
        Console.Write("ERROR: ");
    }
} while (nota1 < 0 || nota1 > 10);






Console.Write("Entra una altra nota 1..10 -> ");
nota2= Convert.ToInt32(Console.ReadLine());
while (nota2 < 0 || nota2 > 10) {
    Console.Write("ERROR: Entra una altra nota 1..10 -> ");
    nota2 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Has tret un {nota1} i un {nota2}");
double mitjana = (nota1 + nota2) / 2;
Console.WriteLine($"La mitjana es {mitjana}");












// char siono;
// Console.Write("Vols continuar (s/n)?");
// do {
//     siono = Console.ReadKey(true).KeyChar;
// } while (siono != 's' && siono != 'n');
// Console.WriteLine(siono);
// if (siono == 's') {
//     Console.WriteLine("Has dit Si");
// } else {
//     Console.WriteLine("Has dit No");
// }








