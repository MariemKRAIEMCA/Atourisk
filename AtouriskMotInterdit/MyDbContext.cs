using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtouriskMotInterdit
{
    class MyDbContext : DbContext
    {
        public DbSet<CommentaireAgent> CommentaireAgent { get; set; }
        public MyDbContext() : base()
        {

        }
    }
}
