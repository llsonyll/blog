using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.App;
using CoreEscuela.Util;

namespace etap1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.inicializar();            
            Printer.WriteTitle("Cursos Escuela");
            //Printer.Beep(2000, 5000, 3);     
            ImprimirCursosEscuela(engine.Escuela);

            Printer.WriteTitle("Alumnos Escuela");

            ImprimirDatosAlumno(engine.Escuela);
            /* var escuela = new Escuela("Platzy School", 2013, "Colombia", "Bogota");
            var escuela2 = new Escuela("SanPancho", 1850, TiposEscuela.Secundaria, ciudad:"Cusco");
            escuela.TipoEscuela = TiposEscuela.Primaria; */

            //REVISAR APP/ENGINE.CS
            //colecciones
            //var listaCursos = new List<Curso>(){

            /* 
            //Curso tmp = new Curso{Nombre="101-Vacacional", Jornada = TiposJornada.Night};
            //otraColeccion.Clear();
            escuela.Cursos.AddRange(otraColeccion);
            //escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            //System.Console.WriteLine("Curso.Hash: " + tmp.GetHashCode());

            //*Predicate<Curso> miAlgorito = predicado;

            escuela.Cursos.RemoveAll(delegate(Curso cur){
                return cur.Nombre == "301";
            });
            //Expresion Lambda
            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "501"
            && cur.Jornada == TiposJornada.Morning);
 */
            //COMENTAR CTRL + K + C DESCOMENTAR CTRL+K+U
            //COMENTAR  /* */

            //escuela.Cursos.Remove(tmp);
            
          /*   //arreglos
            var arregloCursos = new Curso[3]{
                new Curso(){Nombre = "101"},
                new Curso(){Nombre="201"},
                new Curso(){Nombre="301"}
            };

            //creando arreglo de forma diferente
            Curso[] arregloCursos2 = {
                new Curso(){Nombre="101"},
                new Curso(){Nombre="201"},
                new Curso(){Nombre="301"}
            };

            //Asignacion a un cuerpo q ya existe (Escuela)
            escuela.Cursos = new Curso[]{
                new Curso(){Nombre="101"},
                new Curso(){Nombre="201"},
                new Curso(){Nombre="301"}
            };     */

            /* Console.WriteLine(escuela);
            Console.WriteLine(escuela2); */
            // cw HOTKEY
            /* Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
            Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
            Console.WriteLine(curso3);  */
            /* ImprimirCursosWhile(arregloCursos);
            ImprimirCursosDoWhile(arregloCursos);
            ImprimirCursosFor(arregloCursos);
            ImprimirCursosForEach(arregloCursos);          */
            //ImprimirCursosEscuela(escuela);
            // alt + 124 = ||
        }

        private static bool predicado(Curso curobj){
            return curobj.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela){          
            //if (escuela != null && escuela.Cursos != null)
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    System.Console.WriteLine($"Nombre: {curso.Nombre}, ID {curso.UniqueId}");
                }
            }
        }

        private static void ImprimirDatosAlumno(Escuela escuela){

             if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    foreach (var asignatura in curso.Asignaturas)
                    {
                        foreach (var Alumno in curso.Alumnos)
                        {
                                System.Console.WriteLine($"Nombre: {Alumno.Nombre}, Evaluacion: {Alumno.Evaluacion}");
                        }
                    }
                }
            }
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos){
            int contador = 0;
            while(contador < arregloCursos.Length){
                System.Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, ID {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos){
            int contador = 0;
            do{
                System.Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, ID {arregloCursos[contador].UniqueId}");
                contador++;
            } while(contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos){
            int contador;
            for(contador = 0; contador<arregloCursos.Length; contador++){
                System.Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, ID {arregloCursos[contador].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos){
            //A nivel de memoria ??
            foreach (var curso in arregloCursos)
            {
                System.Console.WriteLine($"Nombre: {curso.Nombre}, ID {curso.UniqueId}");
            }
        }
    }
}
