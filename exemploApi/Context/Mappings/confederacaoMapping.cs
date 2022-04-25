using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Context.Mappings
{
	public class confederacaoMapping : IEntityTypeConfiguration<confederacao>
	{
		public void Configure(EntityTypeBuilder<confederacao> builder)
		{
			builder.HasKey(c => c.confederacaoID);

			builder.Property(c => c.nome)
				.HasMaxLength(256)
				.IsRequired()
				.IsUnicode(false);


			builder.ToTable(name: "confederacao", schema: "copadomundo");
		}
	}
}
