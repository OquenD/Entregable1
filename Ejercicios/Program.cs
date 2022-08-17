Console.WriteLine("Ingrese los valores del primer semestre ");
uint semestre1 = uint.Parse(Console.ReadLine());
Console.WriteLine("Ingrese los valores del Segundo semestre ");
uint semestre2 = uint.Parse(Console.ReadLine());

uint anual = semestre1 + semestre2;

int [] renta = {45000,35000,20000,10000,0};
double [] impuesto = {0.3,0.20,0.15,0.10,0.05};
int i = 0;
int posicion = 0;

while(i<=4){
if (anual > renta[i]){
  posicion=i;
  i=5;   
}
i++;
}

Console.WriteLine($"Su renta anual es de {anual}");
Console.WriteLine($"Tiene que pagar un impuesto de {impuesto[posicion]*100}% que equivale a ${anual*impuesto[posicion]} ");
Console.WriteLine($"Para un total de ${anual+(anual*impuesto[posicion])}");