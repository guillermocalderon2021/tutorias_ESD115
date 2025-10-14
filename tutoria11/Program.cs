using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaAlumnos listaAlumnos = new ListaAlumnos();
            listaAlumnos.IngresarAlumno(new Alumno { NumeroLista = 5, Carnet = "201041", Nota = 10 });
            listaAlumnos.IngresarAlumno(new Alumno { NumeroLista = 10, Carnet = "20185041", Nota = 8 });
            listaAlumnos.IngresarAlumno(new Alumno { NumeroLista = 3, Carnet = "20104114", Nota = 9 });
            listaAlumnos.IngresarAlumno(new Alumno { NumeroLista = 15, Carnet = "20185041", Nota = 5 });
            listaAlumnos.IngresarAlumno(new Alumno { NumeroLista = 1, Carnet = "20185041", Nota = 8 });
            listaAlumnos.IngresarAlumno(new Alumno { NumeroLista = 7, Carnet = "20185041", Nota = 3 });
            // listaAlumnos.BorrarPorNumeroLista(10);
            //listaAlumnos.BorrarPorNumeroLista(5);
            //listaAlumnos.MostrarLista();
            listaAlumnos.MostrarAprobadosDescendentes();

        }
    }
}
