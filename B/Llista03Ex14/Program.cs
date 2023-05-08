int any;
bool esDeTraspas;
Console.WriteLine("Any de traspàs!");

Console.Write ("Entra un any -> ");
any = Convert.ToInt32(Console.ReadLine());

if (any % 400 == 0 || any % 4 == 0 && any % 100 != 0) {
    esDeTraspas = true;
} else {
    esDeTraspas = false;
}

esDeTraspas = (any % 400 == 0 || any % 4 == 0 && any % 100 != 0);

if (! esDeTraspas) {
    Console.WriteLine("NO");
} else {
    Console.WriteLine("SI");
}

