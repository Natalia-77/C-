using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class_Goods
{
    enum Stage{Came, Implemented, Writtenoff, Transferred}

    class CatalogGoods
    {
        public Goods[] _good { get; set; }
        public Stage _status { get; set; }


        public CatalogGoods(Goods[] good, Stage status)
        {
            _good = good;
            _status= status;
        }
       

        public void Print()
        {
            foreach (Goods el in _good)
            {
                el.Show();
                Console.WriteLine("Статус товару: "+_status);
                Console.WriteLine();
            }
        }

    }


}
