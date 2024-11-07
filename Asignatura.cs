using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 4.	Crear una clase llamada Asignatura: 
1.	 Propiedades / atributos
1.	N1	int
2.	N2	int
3.	N3	int
4.	NombreAsignatura	string
5.	Horario	string
6.	NombreDocente	string
2.	En la clase Asignatura debe heredar de la clase Alumno 
3.	Invocar a la interfaz IAsignatura e implementar los métodos creados.
4.	Para el método MensajeNotaFinal debe mostrar el mensaje según rango de notas:
1.	De 0% a 59%: Reprobado
2.	De 60% a 79%: Bueno
3.	De 80% a 89%: Muy Bueno
4.	De 90% a 100% Sobresaliente
5.	Para el método Imprimir, al momento de mostrar la nota final se debe mostrar 2 veces, una invocando al método CalcularNotaFinal() y con el método CalcularNotaFinal(parámetros), esto a través del método MensajeNotaFinal

 */
namespace Examen
{
    public class Asignatura: Alumno

    {
        public int N1 {  get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }  
        public string NombreAsignatura {  get; set; }
        public string Horario {  get; set; }
        public string NombreDocente {  get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }
        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;    
        }
        
        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal < 60)
                return "Reprobado";
            else if (notaFinal < 80)
                return "Bueno";
            else if (notaFinal < 90)
                return "Muy Bueno";
            else
                return "Sobresaliente";
        }
         public void Imprimir()
        {
            Console.WriteLine($"nombre del Alumno: {NombreAlumno}");
            Console.WriteLine($"numero de cuenta:{NumeroCuenta}");
            Console.WriteLine($"correo electronico:{Email}");
            Console.WriteLine($"asignatura:{NombreAsignatura}");
            Console.WriteLine($"Docente:{NombreDocente}");

            double notaFinal1 = CalcularNotaFinal();
            double notaFinal2 = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine($"nota final:{notaFinal1}-{MensajeNotaFinal(notaFinal1)}");
            Console.WriteLine($"Nota Final {notaFinal2}-{MensajeNotaFinal(notaFinal2)}");
        




        }


    
       
    
     }

}
