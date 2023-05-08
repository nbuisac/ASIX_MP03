// Renta Tipus impositiu
// Fins a 12450 19%
// De més de l’anterior i fins a 20200 24%
// De més de l’anterior i fins a 35200 30%
// De més de l’anterior i fins a 60000 37%
// De més de l’anterior i fins a 300000 45%
// De més de 300000 47%
const double PCT_A = 0.19, PCT_B = 0.24, PCT_C = 0.30, PCT_D = 0.37, PCT_E = 0.45, PCT_F = 0.47;
const double IMPORT_A = 12450, IMPORT_B = 20200, IMPORT_C = 35200, IMPORT_D = 60000, IMPORT_E = 300000;
double sou, aPagar, percentatge;
Console.Write("Entra el teu sou -> ");
sou = Convert.ToDouble(Console.ReadLine());
aPagar = 0;
if (sou <= IMPORT_A) {
    aPagar = sou * PCT_A; //Primer pct
} else {
    aPagar = aPagar + (IMPORT_A * PCT_A); 
    if (sou <= IMPORT_B) {
        aPagar = aPagar + (sou - IMPORT_A) * PCT_B; //Segon pct
    } else {
        aPagar = aPagar + ((IMPORT_B - IMPORT_A) * PCT_B);
        if (sou <= IMPORT_C) {
            aPagar = aPagar + (sou - IMPORT_B) * PCT_C; //Tercer pct
        } else {
            aPagar = aPagar + ((IMPORT_C - IMPORT_B) * PCT_C);
            if (sou <= IMPORT_D) {
                aPagar = aPagar + (sou - IMPORT_C) * PCT_D; // Quart pct
            } else {
                aPagar = aPagar + ((IMPORT_D - IMPORT_C) * PCT_D);
                if (sou <= IMPORT_E) {
                    aPagar = aPagar + (sou - IMPORT_D) * PCT_E; // Quart pct
                } else {
                    aPagar = aPagar + ((IMPORT_E - IMPORT_D) * PCT_E);
                    aPagar = aPagar + (sou - IMPORT_E) * PCT_F;
                }
            }
        }
    }

}
percentatge = aPagar * 100 / sou;
Console.WriteLine($"Has de pagar {aPagar} Euros ({percentatge} % de {sou})");
