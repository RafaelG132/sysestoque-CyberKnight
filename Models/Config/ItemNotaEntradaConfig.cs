using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace sysestoque_CyberKnight.Models.Config{
	internal class ItemNotaEntradaConfig : IEntityTypeConfiguration<ItemEntrada> {
		public void Configure(EntityTypeBuilder<ItemEntrada> builder) {
			builder.HasKey(ItemNIn => new { ItemNIn.NotaEntradaId, ItemNIn.ProdutoId });

			builder.HasOne(ItemNIn => ItemNIn.NotaEntrada)
					.WithMany(NIn => NIn.ItensEntrada)
					.HasForeignKey(ItemNIn => ItemNIn.NotaEntradaId);

			builder.HasOne(ItemNIn => ItemNIn.Produto)
					.WithMany(P => P.ItensEntrada)
					.HasForeignKey(ItemNIn => ItemNIn.ProdutoId);
		}
	}
}
