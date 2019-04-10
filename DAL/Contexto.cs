using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        /*
        public Contexto()
        {
            this.Database.Connection.ConnectionString ="tcp:sistemawebcelebracionserver.database.windows.net,1433; Initial Catalog = SistemaWebCelebracionLOCAL; Persist Security Info = False; User ID = elias; Password = Ferrari2010; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; \" 4providerName=\"System.Data.SqlClient\"";
        }
        */
            public DbSet<Canto> cantos { get; set; }
            public DbSet<Celebracion> celebraciones { get; set; }
            public DbSet<Hermano> hermanos { get; set; }
            public DbSet<Tema> temas { get; set; }
            public DbSet<Usuario> usuarios { get; set; }
        }
    
}
