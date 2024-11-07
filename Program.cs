
/*
 5.	En el main principal deberá ingresar los datos solicitados utilizando el bloque try / catch y capturar los datos por atributos N1, N2 y N3 (2%)
1.	Validar que las nota del primer parcial y segundo parcial no pasen del 30%
2.	Validar que la nota del tercer parcial no pase del 40%

 */

using Examen;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.WriteLine("Nombre del Estudiante");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.WriteLine("numero de cuenta");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.WriteLine("correo electronico");

            asignatura.Email = Console.ReadLine();

            Console.WriteLine("asignatura");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.WriteLine("docente");
            asignatura.NombreDocente = Console.ReadLine();

            Console.WriteLine("Nota 1 maximo 30%");
            asignatura.N1 = int.Parse(Console.ReadLine());
            if (asignatura.N1 > 30)
                throw new Exception("la nota debe ser menor o igual que 30%");
            Console.WriteLine("Nota 2 maximo 30%");
            asignatura.N2 = int.Parse(Console.ReadLine());
            if (asignatura.N2 > 30)
                throw new Exception("la nota debe ser menor o igual que 30%");
            Console.WriteLine("Nota 2 maximo 40%");
            asignatura.N3 = int.Parse(Console.ReadLine());
            if (asignatura.N3 > 40)
                throw new Exception("la nota debe ser menor o igual que 40%");
            asignatura.Imprimir();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:{ex.Message}");
        }

    }
}
