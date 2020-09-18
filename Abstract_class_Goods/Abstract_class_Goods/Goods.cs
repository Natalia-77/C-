using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class_Goods
{
    class Goods
    {
        protected double _price { get; set; }
        protected string _name { get; set; }
        protected int _quantity { get; set; }
        protected  DateTime _date { get; set; }//дата оприбуткування товару на склад.

        public Goods(string name, double price, int quantity,DateTime date)
        {
            _price=price;
            _name=name;
            _quantity = quantity;
            _date = date;
        }
        
        public virtual void Show()
        {
            Console.WriteLine(" Назва: {0}\n Ціна: {1}\n Кількість: {2} \n Дата оприбуткування: {3} {4} ", _name, _price, _quantity, _date.ToString("D"));
        }

    }
}
