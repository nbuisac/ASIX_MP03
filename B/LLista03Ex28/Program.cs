string LLETRES_DNI = "TRWAGMYFPDXBNJZSQVHLCKE";
int dni;
int residu;
char lletra;
Console.WriteLine("Entra un DNI (sense lletra) -> ");
dni = Convert.ToInt32(Console.ReadLine());
residu = dni % 23;
// etc
lletra = LLETRES_DNI[residu];
Console.WriteLine(dni + "" + lletra);

switch (residu) {
    case  0: lletra = 'T'; break;
    case  1: lletra = 'R'; break;
    case  2: lletra = 'W'; break;
    case  3: lletra = 'A'; break;
    case  4: lletra = 'G'; break;
    case  5: lletra = 'M'; break;
    case  6: lletra = 'Y'; break;
    case  7: lletra = 'F'; break;
    case  8: lletra = 'P'; break;
    case  9: lletra = 'D'; break;
    case 10: lletra = 'X'; break;
    case 11: lletra = 'B'; break;
    case 12: lletra = 'N'; break;
    case 13: lletra = 'J'; break;
    case 14: lletra = 'Z'; break;
    case 15: lletra = 'S'; break;
    case 16: lletra = 'Q'; break;
    case 17: lletra = 'V'; break;
    case 18: lletra = 'H'; break;
    case 19: lletra = 'L'; break;
    case 20: lletra = 'C'; break;
    case 21: lletra = 'K'; break;
    default: lletra = 'E'; break;
}
Console.WriteLine(dni + "" + lletra);
