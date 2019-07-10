using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace AtouriskMotInterdit
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            MyDbContext db = new MyDbContext();

            string matricule = "L036307";
            string fkPatnaire = "00000001460355";
            string dCreation = "123";
            string motInterdit = "blabla";

            var cmt = db.CommentaireAgent.SqlQuery("SELECT *  FROM CommentaireAgent WHERE matricule=",matricule," and fkPartenaire =", fkPatnaire,"and dCreation = "+dCreation).FirstOrDefault();
            String commentaire = cmt.commentaire;
            if (commentaire.Contains(motInterdit))
            {
                commentaire = commentaire.Replace(motInterdit, "XXX"); 
            }

        }
    }
}
