//4.Aplicar las funciones matemáticas vistas en clases para la codificación de un
//programa que calcule las raíces de una ecuación de segundo grado utilizando la
//fórmula cuadrática. El usuario deberá ingresar los valores de las constantes a, b y c
//para resolver las raíces.
public class Ejercicio4
{
    public static void Main()
    {
        // Usuario ingresando los valores de las contantes de a,b y c
        Console.WriteLine("Porfavor ingrese los valores de las constantes a, b y c para resolver la ecuación cuadrática ax^2 + bx + c = 0: (Que es por formula)");
        Console.WriteLine();
        Console.Write("Valor para constante a -> ");
        double Constante_a = double.Parse(Console.ReadLine());

        Console.Write("Valor para constante b -> ");
        double Constante_b = double.Parse(Console.ReadLine());

        Console.Write("Valor para constante c -> ");
        double Constante_c = double.Parse(Console.ReadLine());

        // Calculo con el discrimiante en usar
        double Discriminante_Usar = Math.Pow(Constante_b, 2) - 4 * Constante_a * Constante_c;

        if (Discriminante_Usar >= 0)
        {
            //calculo las raíces de una ecuación de segundo grado utilizando la fórmula cuadrática.
            double raiz1 = (-Constante_b + Math.Sqrt(Discriminante_Usar)) / (2 * Constante_a);
            double raiz2 = (-Constante_b - Math.Sqrt(Discriminante_Usar)) / (2 * Constante_a);

            Console.WriteLine("Las raíces de la ecuación son las siguientes:");
            Console.WriteLine("Raíz 1: " + raiz1);
            Console.WriteLine("Raíz 2: " + raiz2);
        }
        else
        {
            Console.WriteLine("Importante: La ecuación no tiene raíces reales.");
        }
    }
}

//Hecho por Josue Bryan Hernandez Zelaya