using Clinica.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Clinica.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medico>()
               .ToTable("Medicos");

            modelBuilder.Entity<Medico>()
               .HasKey(x => x.Id);

            modelBuilder.Entity<Medico>()
               .Property(x => x.Nome)
                   .HasColumnType("varchar(150)")
                   .IsRequired();

         
        }

    }
}
