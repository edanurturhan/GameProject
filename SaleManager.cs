using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void Buy(Sale sale, Gamer gamer)
        {
            Console.WriteLine(gamer.Firstname + " " + gamer.Lastname + " isimli kişi" + sale.GameName + " oyununu " + sale.Price + " TL'ye satın almıştır ");
        }

        internal void Buy(Sale sale, object gamer)
        {
            throw new NotImplementedException();
        }
    }
}
