int any;
bool esDeTraspas;
Console.Write("Entra un any -> ");
any = Convert.ToInt32(Console.ReadLine());

esDeTraspas =  (any % 400 == 0) || (any % 4 == 0 && any % 100 != 0);

if (! esDeTraspas) {
    Console.WriteLine("NO traspàs");
} else {
    Console.WriteLine("SI traspàs");
}