Console.WriteLine("Ingrese tu nombre completo ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese tu edad");
uint edad = uint.Parse(Console.ReadLine());

int precio = 15000;
int [] age = {18,4,0};
double [] discount = {0.03,0.05,1.0};
int i = 0;
int posicion = 0;

while(i<=2){
if (edad > age[i]){
  posicion=i;
  break;   
}
i++;
}

Console.WriteLine($"Bienvenid@ {nombre}");
Console.WriteLine($"Tu precio de entrada es de ${precio-(precio*discount[posicion])}");
Console.WriteLine($"Tu descuento fue de {discount[posicion]*100}% que equivale a: ${(precio*discount[posicion])}");
