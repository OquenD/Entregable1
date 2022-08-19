Console.WriteLine("Bienvenid@ a pizzeria el Fercho ");
Console.WriteLine("Que tipo de pizza desea ");
Console.WriteLine(@"Opcion 1: Pizza Vegetariana-
Opcion 2: Pizza no Vegetariana-");
int opcion = int.Parse(Console.ReadLine());

if (opcion != 1 && opcion!=2){Console.WriteLine("Opcion no Valida"); Environment.Exit(0);} 

string [,] vegetariana = new string[2,3] {{"Pimiento","Mozzarella","Tomate"},{"Champiñones","Mozzarella","Tomate"}};
string [,] noVegetariana = new string[3,3] {{"Pepperoni","Mozzarella","Tomate"},{"Salami","Mozzarella","Tomate"},{"Pollo","Mozzarella","Tomate"}};

int i=0;
int response =0;

if (opcion ==1){
    Console.WriteLine("Elige el ingrediente principal");
    Console.WriteLine("1)Pimiento - 2)Champiñones");
    response = int.Parse(Console.ReadLine());
    if (response != 1 && response!=2){Console.WriteLine("Opcion no Valida"); Environment.Exit(0);} 
    Console.WriteLine("La pizza es vegetariana y lleva los siguientes Ingredientes:");
    while(i<3){
      Console.WriteLine(vegetariana[response-1,i]);
      i++;
    }
}
else{
Console.WriteLine("Elige el ingrediente principal");
    Console.WriteLine("1)Pepperoni - 2)Salami  - 3)Pollo");
    response = int.Parse(Console.ReadLine());
    if (response != 1 && response!=2){Console.WriteLine("Opcion no Valida"); Environment.Exit(0);} 
    Console.WriteLine("La pizza no es vegetariana y lleva los siguientes Ingredientes:");
    while(i<3){
      Console.WriteLine(noVegetariana[response-1,i]);
      i++;
    }
  }
