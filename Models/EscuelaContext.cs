using System;
using Microsoft.EntityFrameworkCore;

namespace asp.net_core_MVC.Models
{
    public class EscuelaContext: DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }


        public EscuelaContext (DbContextOptions<EscuelaContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela();                        
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Julián's SChool";
            escuela.Ciudad= "València";
            escuela.Pais= "España";
            escuela.Dirección = "C/ Sin número";

            modelBuilder.Entity<Escuela>().HasData(
                escuela
            );

        }
    }
}