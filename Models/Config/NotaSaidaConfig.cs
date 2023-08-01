using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace sysestoque_CyberKnight.Models.Config {
	public class NotaSaidaConfig : IEntityTypeConfiguration<NotaSaida> {
		public void Configure(EntityTypeBuilder<NotaSaida> builder) {

			builder.HasMany(NOut => NOut.Produtos)
				.WithMany(Produto => Produto.NotasSaida)
				.UsingEntity<ItemSaida>();
		}
	}
}
