using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        //public string name; MALA PRACTICA
        //EMCAPSULAMIENTO       
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int YearCreation { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }     
        public TiposEscuela TipoEscuela {get; set; }
        //public Curso[] Cursos { get; set; }
        public List<Curso> Cursos { get; set; }
        //constructor
        public Escuela(string name, int year, string pais, string ciudad){
            this.Name = name;
            this.YearCreation = year;
            this.Pais = pais;
            this.Ciudad = ciudad;
        }

        public Escuela(string name, int year, TiposEscuela tipo,
                        string pais = "", string ciudad= ""){
            (Name, YearCreation) = (name, year);
            TipoEscuela = tipo;
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString(){
            return $"Nombre: {Name}, Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }  
    }
}