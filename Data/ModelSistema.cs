namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelSistema : DbContext
    {
        public ModelSistema()
            : base("name=ModelSistema")
        {
        }

        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<Categoria> categorias { get; set; }
        public virtual DbSet<Produto> produtos { get; set; }
        public virtual DbSet<Venda> vendas { get; set; }
        public virtual DbSet<ItensVenda> itensVenda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
