Console.WriteLine("Ingrese la evaluacion -(0.0)(0.4)(0.6) ");
double puntaje = double.Parse(Console.ReadLine());
string [] nivel = {"Inaceptable","Aceptable","Meritorio"};
double [] pun = {0.0,0.4,0.6};
int i = 0;
int posicion = 0;

if(puntaje!=0.0 || puntaje!=0.4 || puntaje!=0.6){
    Console.WriteLine("Ingrese una evaluacion valida");
    Environment.Exit(0);
}
else
{
while(i<=2){
if (puntaje == pun[i]){
  posicion=i;
  i=3;   
}
i++;
}
}
Console.WriteLine($"Su nivel de evaluacion es de {nivel[posicion]}");
Console.WriteLine($"La bonificacion ganada es de {puntaje*50000} ");
