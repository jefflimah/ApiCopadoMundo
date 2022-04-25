using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	
		public class ParticipanteMapping : IEntityTypeConfiguration<participante>
		{
			public void Configure(EntityTypeBuilder<participante> builder)
			{
				builder.HasKey(c => c.participantesID);

				builder.Property(c => c.nome)
					.HasMaxLength(256)
					.IsRequired()
					.IsUnicode(false);


				builder.ToTable(name: "partipantes", schema: "copadomundo");
			}
		}
	}



