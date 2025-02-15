Console.WriteLine("iNTRODUCE EL PRIMER NUMERO ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("iNTRODUCE EL SEGUNDO  NUMERO ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n QUE OPERACION DESEA REALIZAR");

Console.WriteLine("1) sumar");
Console.WriteLine("2) Restar");
Console.WriteLine("3) Multiplicacion");
Console.WriteLine("4) Division");

int operacion = Convert.ToInt32(Console.ReadLine());
double resultado = 0;

switch (operacion)
{
    case 1:
        resultado = num1 + num2;
        Console.WriteLine($"El Resultado de la Suma es: {resultado}");
        break;

    case 2:
        resultado = num1 - num2;
        Console.WriteLine($"El Resultado de la Resta es: { resultado}");
        break;

    case 3:
        resultado = num1 * num2;
        Console.WriteLine($"El Resultado de la Multiplicacion es:{resultado}");
        break;

    case 4:
        resultado = num1 / num2;
        Console.WriteLine($"El Resultado de la Division es: {resultado}");
        break;

}
