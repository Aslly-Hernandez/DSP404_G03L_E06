// Programa realizado por 
// Día: Agosto 29,2022
Console.WindowHeight = 25;  // alto de la ventana           
Console.WindowWidth = 75; //ancho de la ventana
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = " Cajero Automatico Soyacity.com ";
Console.Write("\nGuia#3 Ejemplo5");
Console.WriteLine("\n");
//Declaracion de variables
int SI, opc;
Double din, dan, S;
SI = 1000; // dinero actual en la cuenta
//menú principal
Console.WriteLine("\t<< Bienvenido a su cajero virtual >>");
Console.WriteLine("\t1. Ingreso en cuenta ");
Console.WriteLine("\t2. Reintegro ");
Console.WriteLine("\t3. Ver el saldo disponible ");
Console.WriteLine("\t0. Salir ");
Console.WriteLine("\n");
Console.Write("\tSeleccione una opción: ");
opc = int.Parse(Console.ReadLine());
if (opc == 1)
{
    Console.Write("\tBien, escriba el dinero que desee introducir: $ ");
    din = Double.Parse(Console.ReadLine());
    S = SI + din;
    Console.Write("\tIngreso realizado correctamente. Su saldo actual es de $ " + S);
}
else if (opc == 2)
{
    Console.Write("\tAhora, teclee la cantidad de dinero que desea retirar : $ ");
    Console.ForegroundColor = ConsoleColor.Blue;
    dan = Double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Black;
    if (dan > SI)
    {
        Console.Write("\tError. No dispone de tanto sueldo.\n");
    }
    else
    {
        S = SI - dan;
        Console.Write("\tRetiro realizado correctamente, su saldo actual es de : $ ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(S);
        Console.ForegroundColor = ConsoleColor.Black;
    }
}
else if (opc == 3)
{
    Console.Write("\tSu saldo actual es de ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Write("$" + SI);
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
}
else if (opc == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tGracias por utilizar este programa.\n\n");
    Console.ForegroundColor = ConsoleColor.Black;
}
else
{
    Console.WriteLine("\tDisculpe, se ha equivocado al marcar.\n\n");
}
Console.Write("\n\n");
//Pantalla opcional
Console.Write("\t");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine("*********************************************");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("\t*                                           *");
Console.WriteLine("\t*     Este programa fue diseñado por:       *");
Console.WriteLine("\t*                                           *");
Console.WriteLine("\t*              Michael Platini              *");
Console.WriteLine("\t*                                           *");
Console.Write("\t");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine("*********************************************");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Write("\t");
Console.WriteLine("--> Fin del Programa");
Console.Write("\t");
Console.ReadKey();



