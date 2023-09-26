//2. Utilizando la constante matemática de E: Math.E conocido en ocasiones como
//número de Euler o constante de Napier, utilizar ese valor para hacer los siguientes
//cálculos utilizando las funciones en C# y mostrarlas en consola.
//● Redondear los valores decimales del número hasta la 10 posición
public class Ejercicio2
{
    public static void Main()
    {
        double Euler = Math.E;
        int Posicion_Decimal = 10;
        //Valor general
        Console.WriteLine("Valor de Euler: " + Euler);
        //Redondear los valores decimales del número hasta la 10 posición
        double redondeo_numero = Math.Round(Euler, Posicion_Decimal);
        Console.WriteLine("El numnero " + " redondeado a " + Posicion_Decimal + " decimal es: " + redondeo_numero);
    }
}

//Hecho por Josue Bryan Hernandez Zelaya