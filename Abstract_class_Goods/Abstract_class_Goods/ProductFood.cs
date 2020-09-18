using System;
using System.Collections.Generic;
using System.Text;


namespace Abstract_class_Goods
{
    class ProductFood:Goods
    {
        public string _group;
        public string _department;

        public ProductFood(string name,double price,int quantity,DateTime date,string group="Food",string department="Grocery"):base(name,price,quantity,date)
        {
            _group = group;
            _department = department;
        }

        public override void Show()
        {
            Console.WriteLine(" Назва: {0}\n Ціна: {1}\n Кількість: {2} \n Продуктова група: {3} \n Відділ : {4} Дата оприбуткування : {5}", _name, _price, _quantity, _group, _department, _date.ToString("D"));

        }
       

    }

    
}
