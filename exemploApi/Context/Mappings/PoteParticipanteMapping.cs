using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	
		public class PoteParticipanteMapping : IEntityTypeConfiguration<PoteParticipante>
		{
			public void Configure(EntityTypeBuilder<PoteParticipante> builder)
			{
				builder.HasKey(c => c.PoteID);

				builder.HasKey(c => c.participantesID);



				builder.ToTable(name: "PoteParticipante", schema: "copadomundo");
			}
		}
	}



