Console.WriteLine("Bienvenid@ a pizzeria el Fercho ");
Console.WriteLine("Que tipo de pizza desea ");
Console.WriteLine(@"Opcion 1:
                    Pizza Vegetarian-
                    Ingredientes:
                    -Pimiento 
                    -Champiñones
                    -Mozzarella 
                    -Tomate ");

Console.WriteLine(@"Opcion 2:
                    Pizza no Vegetarian-
                    Ingredientes:
                    -Pepperoni 
                    -Salami 
                    -Pollo
                    -Mozzarella 
                    -Tomate ");

Console.WriteLine("Inserte opcion aqui"); uint respon = uint.Parse(Console.ReadLine());

if (respon ==1){
    Console.WriteLine("La pizza es vegetariana y lleva los siguientes Ingredientes:");
    Console.WriteLine(@"
   -Pimiento 
   -Champiñones
   -Mozzarella 
   -Tomate ");
}
Console.WriteLine("La pizza no es vegetariana y lleva los siguientes Ingredientes:");
Console.WriteLine(@"
  -Pepperoni 
  -Salami 
  -Pollo
  -Mozzarella 
  -Tomate ");