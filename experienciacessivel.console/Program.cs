using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using experienciacessivel.infrastructure;
using experienciacessivel.domain;

namespace experienciacessivel.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ExperienciacessivelContext();
            db.Database.CreateIfNotExists();


            var a1 = new AccessibleAttributes("Cardápio Braille");
            var a2 = new AccessibleAttributes("Rampas de Acesso");
            var a3 = new AccessibleAttributes("Banheiro Adaptado");
            var a4 = new AccessibleAttributes("Atendimento Especializado");

            db.AccessibleAttributes.Add(a1);
            db.AccessibleAttributes.Add(a2);
            db.AccessibleAttributes.Add(a3);
            db.AccessibleAttributes.Add(a4);


            List<AccessibleAttributes> l1 = new List<AccessibleAttributes>();
            List<AccessibleAttributes> l2 = new List<AccessibleAttributes>();
            List<AccessibleAttributes> l3 = new List<AccessibleAttributes>();
            List<AccessibleAttributes> l4 = new List<AccessibleAttributes>();

            l1.Add(a1);
            l1.Add(a2);
            l1.Add(a3);

            l2.Add(a2);
            l2.Add(a3);
            l2.Add(a4);

            var lo1 = new Local("Bar Brahma", l1);
            var lo2 = new Local("RM pet shop", l1);
            var lo3 = new Local("Itaquerão", l2);
            var lo4 = new Local("Aeroporto de Congonhas", l2);

            db.Locais.Add(lo1);
            db.Locais.Add(lo2);
            db.Locais.Add(lo3);
            db.Locais.Add(lo4);


            db.SaveChanges();

        }
    }
}
