using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	
		public class grupoParticipanteMapping : IEntityTypeConfiguration<grupoParticipante>
		{
			public void Configure(EntityTypeBuilder<grupoParticipante> builder)
			{
				builder.HasKey(c => c.GrupoID);

				builder.HasKey(c => c.participantesID);



				builder.ToTable(name: "grupoParticipante", schema: "copadomundo");
			}
		}
	}



