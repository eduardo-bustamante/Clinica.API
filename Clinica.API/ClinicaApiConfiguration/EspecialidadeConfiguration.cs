using Clinica.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.API.Map
{
    public class EspecialidadeConfiguration : EntidadeConfiguration<Especialidade>
    {
        public EspecialidadeConfiguration() : base("tb_especialidade")
        { }

        public override void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            builder.Property(x => x.Ativa).HasColumnName("ativa");
        }
    }
}
