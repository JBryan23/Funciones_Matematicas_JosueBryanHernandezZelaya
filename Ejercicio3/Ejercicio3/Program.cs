//3.Realice un programa que calcule la suma acumulada de los cuadrados de los
//primeros 20 dígitos.
//Ejemplo suma = (1x1) +(2x2) +(3x3) +..(18 * 18) + (19x19) +(20 * 20)

public class Ejercicio3
{
    public static void Main()
    {
        int Digitos = 20;
        double Suma_Acumulada = 0;

        for (int i = 1; i <= Digitos; i++)
        {
            //Suma acumulada de los cuadrados de los 20 digitos
            double cuadrado = Math.Pow(i, 2);
            Suma_Acumulada += cuadrado;
            Console.WriteLine($"({i}x{i}) = {cuadrado}");
        }
    }
}

// Hecho por Josue Bryan Hernandez Zelaya