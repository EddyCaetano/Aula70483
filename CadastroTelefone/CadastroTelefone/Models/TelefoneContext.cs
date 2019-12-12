namespace CadastroTelefone.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TelefoneContext : DbContext
    {
        // Your context has been configured to use a 'TelefoneContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CadastroTelefone.Models.TelefoneContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TelefoneContext' 
        // connection string in the application configuration file.
        public TelefoneContext()
            : base("name=TelefoneContext")
        {
        }

        public virtual DbSet<Telefone> Telefones { get; set; }

    }
}