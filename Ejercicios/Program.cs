Console.WriteLine("Ingrese la evaluacion (0.0)(0.4)(0.6) ");
double puntaje = double.Parse(Console.ReadLine());

switch (puntaje){
  case 0.0:
    Console.WriteLine("Su nivel de evaluacion es de Inaceptable");
    Console.WriteLine($"La bonificacion ganada es de {0.0*50000}");
  break;
  case 0.4:
    Console.WriteLine("Su nivel de evaluacion es de Aceptable");
    Console.WriteLine($"La bonificacion ganada es de {0.4*50000}");
  break;
  case 0.6:
    Console.WriteLine("Su nivel de evaluacion es de Meritorio");
    Console.WriteLine($"La bonificacion ganada es de {0.6*50000}");
  break;
  default:
    Console.WriteLine("Evaluacion no valida");
  break;
}
