using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	
		public class PoteMapping : IEntityTypeConfiguration<Pote>
		{
			public void Configure(EntityTypeBuilder<Pote> builder)
			{
				builder.HasKey(c => c.PoteID);

				builder.Property(c => c.descricao)
					.HasMaxLength(256)
					.IsRequired()
					.IsUnicode(false);


				builder.ToTable(name: "Pote", schema: "copadomundo");
			}
		}
	}



