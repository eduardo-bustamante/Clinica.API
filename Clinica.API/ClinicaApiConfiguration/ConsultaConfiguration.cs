using Clinica.API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Map
{
    public class ConsultaConfiguration : EntidadeConfiguration<Consulta>
    {
        public ConsultaConfiguration() : base("tb_consulta")
        {
        }

        public override void Configure(EntityTypeBuilder<Consulta> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.DataConsulta).HasColumnName("data_consulta");

            builder.Property(x => x.DataConsulta).HasColumnName("data_consulta").IsRequired();

            builder.Property(x => x.PacienteId).HasColumnName("id_paciente").IsRequired();
            builder.HasOne(x => x.Paciente).WithMany(x => x.Consultas).HasForeignKey(x => x.PacienteId);

            builder.Property(x => x.MedicoId).HasColumnName("id_medico").IsRequired();
            builder.HasOne(x => x.Medico).WithMany(x => x.Consultas).HasForeignKey(x => x.MedicoId);

            builder.Property(x => x.EspecialidadeId).HasColumnName("id_especialidade").IsRequired();
            builder.HasOne(x => x.Especialidade).WithMany(x => x.Consultas).HasForeignKey(x => x.EspecialidadeId);
        }
    }
}
