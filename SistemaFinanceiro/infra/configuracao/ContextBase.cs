using Entidades.entidades;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

public class ContextBase : DbContext
{
    public ContextBase(DbContextOptions<DbContext> options) : base()
    {

    }

    public DbSet<SistemaFinanceiro> SistemaFinanceiro { set; get; }
    public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro { set; get; }
    public DbSet<Categoria> Categoria { set; get; }
    public DbSet<Despesa> Despesa { set; get; }


    // Conexao com o banco - ConnectionString
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ObterStringConexao());
        }
    }

    // Fluent Api - Especificações das tabelas
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var ApplicationUser = modelBuilder.Entity<ApplicationUser>();
            ApplicationUser.ToTable("AspnetUsers").HasKey(t => t.Id);
     
        base.OnModelCreating(modelBuilder);
    }


    // Connection String
    public string ObterStringConexao()
    {
        //return "Data Source=NBQSP-FC693;Initial Catalog=FINANCEIRO_2023;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        return "Data Source=DESKTOP-FS2K7LU;Initial Catalog=FINANCEIRO_2023;Integrated Security=True"; // Evitar
    }


}