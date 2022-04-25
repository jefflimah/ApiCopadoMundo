using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	
		public class grupoMapping : IEntityTypeConfiguration<grupo>
		{
			public void Configure(EntityTypeBuilder<grupo> builder)
			{
				builder.HasKey(c => c.GrupoID);

				builder.Property(c => c.descricao)
					.HasMaxLength(256)
					.IsRequired()
					.IsUnicode(false);


				builder.ToTable(name: "grupo", schema: "copadomundo");
			}
		}
	}



