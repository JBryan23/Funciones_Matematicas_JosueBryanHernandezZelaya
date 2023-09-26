//1.Utilizando la constante matemática de PI: Math.PI utilizar ese valor para hacer los
//siguientes cálculos utilizando las funciones en C# y mostrarlas en consola.
//● Truncar el valor de PI
//● Redondear hacia arriba
//● Redondear hacia abajo


public class Ejercicio1
{
    public static void Main()
    {
        double PI = Math.PI;
        double Truncar = Math.Truncate(PI);
        //Valor general
        Console.WriteLine("Valor de PI: " + PI);
        //Truncar el valor PI
        Console.WriteLine("El valor truncado de PI: " + Truncar);
        // Redondear hacia arriba
        Console.WriteLine("El valor redondeado de PI hacia arriba es: " + Math.Ceiling(PI));
        //Redondear hacia abajo
        Console.WriteLine("El valor redondeado  de PI hacia abajo es: " + Math.Floor(PI));
    }
}

// Hecho por Josue Bryan Hernandez Zelaya

 