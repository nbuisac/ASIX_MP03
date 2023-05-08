// Llista 3 - Exercici 9
int angle;
Console.WriteLine("Quadrant d'una circumferència");
Console.Write("Entra l'angle -> ");
angle = Convert.ToInt32(Console.ReadLine());

if (angle < 0) {
    Console.WriteLine(angle % 360 );
    angle = 360 + angle % 360 ;
} else {
    angle = angle % 360;
}

if (angle < 90) {
    Console.WriteLine("Primer quadrant");
} else if (angle < 180) {
    Console.WriteLine("Segon quadrant");
} else if (angle < 270) {
    Console.WriteLine("Tercer quadrant");
} else {
    Console.WriteLine("Quart quadrant");
}