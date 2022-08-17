// Console.WriteLine("Ingrese tu Edad");
// uint edad = uint.Parse(Console.ReadLine());
// if (edad >= 18){
//     Console.WriteLine("Es Mayor");
//     Environment.Exit(0);
// }
// Console.WriteLine("Es menor");

// -----------------------------------------------------------------------------------------


// Console.WriteLine("Ingrese la contraseña");
// string entrada = Console.ReadLine();
// string contrasena = "hjklñ" ;
// if (entrada.ToLower() == contrasena.ToLower()){
//     Console.WriteLine("Entra");
//     Environment.Exit(0);
// }
//  Console.WriteLine("No Entra");


// ------------------------------------------------------------------------------------

// Console.WriteLine("Ingrese el primer numero");
// double firstNum = double.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese el segundo numero");
// double secondNum = double.Parse(Console.ReadLine());
// if(secondNum == 0){
//     Console.WriteLine("Error");
//     Environment.Exit(0);
// }
// Console.WriteLine(firstNum/secondNum);

// ----------------------------------------------------------------------------------------


// Console.WriteLine("Escriba un numero ");
// int number = int.Parse(Console.ReadLine());
// if((number % 2)== 0){
//     Console.WriteLine("El numero es par");
//     Environment.Exit(0);
// }
// Console.WriteLine("Es impar");



// ---------------------------------------------------------------------------------------------

Console.WriteLine("Ingrese tu edad ");
uint age = uint.Parse(Console.ReadLine());

Console.WriteLine("Ingrese tu sueldo mensual");
uint salary =  uint.Parse(Console.ReadLine());


if((age>16) && (salary>1000)){
    Console.WriteLine("Puede tributar");
    Environment.Exit(0);
}
Console.WriteLine("No puede tributar");
