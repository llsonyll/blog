using CoreEscuela.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine(){
            
        }

        public void inicializar(){
            Escuela = new Escuela("Platzy School", 2013, "Colombia", "Bogota");
            
            CargarCursos();                      
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarCursos(){
            Escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre="101", Jornada = TiposJornada.Afternoon},
                new Curso(){Nombre="201", Jornada = TiposJornada.Afternoon},
                new Curso(){Nombre="301", Jornada = TiposJornada.Morning},
                new Curso {Nombre="102", Jornada = TiposJornada.Afternoon},
                new Curso {Nombre="202", Jornada = TiposJornada.Night}
            };    

            Random rnd = new Random();            
            foreach (var curso in Escuela.Cursos)
            {
                int random = rnd.Next(5, 20);
                curso.Alumnos = GenerandoAlumnos(random);
            }
        }

        private List<Alumno> GenerandoAlumnos(int cantidad){
            string[] nombres = {"Jesus", "Hector", "Gianella", "Alvaro"};
            string[] apellidos1 = {"Sanchez", "Rosales", "Enim", "Polant"};
            string[] nombres2 = {"Miguel", "Francisco", "Alex", "Wrigth"};

            var listAlumnos =   from n1 in nombres
                                from n2 in nombres2
                                from a1 in apellidos1
                                select new Alumno{ Nombre= $"{n1} {n2}, {a1}"};
            
            return listAlumnos.OrderBy( (al)=> al.UniqueId ).Take(cantidad).ToList();
        }

        private void CargarAsignaturas(){
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre = "Matematicas"},
                    new Asignatura{Nombre = "Educacion Fisica"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"},
                    new Asignatura{Nombre = "Fisica"}
                };                
                curso.Asignaturas = listaAsignaturas;
            }

            foreach (var asignatura in Curso.Asignaturas)
            {
                asignatura.Evaluaciones = CargarEvaluaciones();
            }
        }

        private List<Evaluaciones> CargarEvaluaciones(){
            string[] ciclo = {"Primer", "Segundo", "Tercer"};            
            string[] tipo = {"Examen"};
            int[] nt = {1, 2, 3, 4, 5};            
            var lstEvaluaciones =   from c1 in ciclo
                                    from t1 in tipo
                                    from a1 in listaAsignaturas
                                    from n in nt
                                    select new Evaluaciones{Nombre = $"{c1} {t1} de {a1}", Nota = n};            
            return lstEvaluaciones.OrderBy( (ev)=> ev.UniqueId).Take(5).ToList();
        }
    }
}