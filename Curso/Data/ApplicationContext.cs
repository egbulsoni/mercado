namespace Curso.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)       
        {
            //montar a string de conexão
            // optionsBuilder.UseSqlServer("User ID=root;Password=dadada;Host=localhost;Port=5432;Database=LojaDeItens;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=20000;")
        }
    }
}