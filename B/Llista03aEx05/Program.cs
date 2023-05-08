// LLista 3a - Exercici 5
Random random = new Random();
double notaPractica, notaExamen; // notaFinal, notaQualitativa;
Console.WriteLine("Calcul nota 20% + 80%");

notaPractica = random.Next(100, 1000) / 100.0;
notaExamen = random.Next(100, 1000) / 100.0;
Console.WriteLine($"Nota Practica: {notaPractica}");
Console.WriteLine($"Nota Examen: {notaExamen}");


