// Multiplicació a abase de sumes
decimal numero1, numero2;
decimal gran, petit;
decimal resultat;
int q1, q2, i;
Console.Write("Entra el primer valor a multiplicar -> ");
numero1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Entra el segon valor a multiplicar -> ");
numero2 = Convert.ToDecimal(Console.ReadLine());
gran = numero1;
petit = numero2;

q1 = 0;
while (gran != (int) gran) {
    gran = gran * 10;
    q1++;
}
q2 = 0;
while (petit != (int) petit) {
    petit = petit * 10;
    q2++;
}
Console.WriteLine($"q1 val {q1} i q2 val {q2}");
if (Math.Abs(petit) > Math.Abs(gran)) {
    resultat = gran; // utilitzo la variable resultat com ajuda per no declarar-ne dues
    gran = Math.Abs(petit);
    petit = Math.Abs(resultat);
} else {
    gran = Math.Abs(gran);
    petit = Math.Abs(petit);
}
Console.WriteLine($"Sumo {petit} vegades el {gran}");

resultat = 0;
for(i = 0; i < petit; i++) {
    resultat = resultat + gran;
}

for(i = 0; i < (q1 + q2); i++) {
    Console.WriteLine($"Divideixo {resultat}");
    resultat = resultat / 10;

}
if (((numero1 > 0 || numero2 > 0) && (numero1 < 0 || numero2 < 0))) {
    resultat = -resultat;
}

Console.WriteLine($"{numero1} x {numero2} = {resultat}");

