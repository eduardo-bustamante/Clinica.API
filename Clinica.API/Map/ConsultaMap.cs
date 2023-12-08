using Clinica.API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Map
{
    public class ConsultaMap : EntidadeMap<Consulta>
    {
        public ConsultaMap() : base("tb_consulta")
        {
        }

        public override void Configure(EntityTypeBuilder<Consulta> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.DataConsulta).HasColumnName("data_consulta");
        }
    }
}
