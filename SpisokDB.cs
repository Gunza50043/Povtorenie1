using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Povtorenie1
{
    internal class SpisokDB
    {
        internal List<Spisok> SpisokLIST { get; set; }
        public void InitializeDB()
        {
            SpisokLIST = new List<Spisok>
            {
                new Spisok ("Часы", 11234, "Мои часы"),
                new Spisok ("Подик", 11231, "Вкусная жижа"),
                new Spisok ("Винигрет", 14123, "Красный"),
                new Spisok ("Бутылка", 41211, "Vulcanica")
            };

        }
    }
}
