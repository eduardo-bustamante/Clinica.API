using Clinica.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.API.Map
{
    public class MedicoMap : EntidadeMaps<Medico>
    {
        public MedicoMap() : base("tb_medico") { }

        public override void Configure(EntityTypeBuilder<Medico> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo");

            builder.HasMany(x => x.Especialidades)
                .WithMany(x => x.Medicos)
                .UsingEntity<EspecialidadeMedico>(
                    x => x.HasOne(p => p.Especialidade).WithMany().HasForeignKey(x => x.EspecialidadeId),
                    x => x.HasOne(p => p.Medicos).WithMany().HasForeignKey(x => x.MedicoId),
                    x =>
                    {
                        x.ToTable("tb_profissional_especialidade");

                        x.HasKey(p => new { p.EspecialidadeId, p.MedicoId });

                        x.Property(p => p.EspecialidadeId).HasColumnName("id_especialidade").IsRequired();
                        x.Property(p => p.MedicoId).HasColumnName("id_profissional").IsRequired();
                    }
                ); ;
        }
    }
}
