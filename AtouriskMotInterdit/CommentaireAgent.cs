using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtouriskMotInterdit
{
    class CommentaireAgent
    {
        public int Id { get; set; }
        public string dCreation { get; set; }
        public string dRegularisation { get; set; }
        public string commentaire { get; set; }
        public string matricule { get; set; }
        public string fkPartenaire { get; set; }
    }
}
