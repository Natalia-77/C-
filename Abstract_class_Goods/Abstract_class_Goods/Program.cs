using System;
using System.Text;

namespace Abstract_class_Goods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Goods[] good =
             {new HouseholdChemicals("Tide",25,100,new DateTime(2020,10,10)),
             new HouseholdChemicals("Losk",37,123,new DateTime(2020,10,02)),
             new ProductFood("Snickers",16,2300,new DateTime(2019,12,25)),
             new ProductFood("Roshen",120,50,new DateTime(2020,07,07)),
             new HouseholdChemicals("Duru",12,100,new DateTime(2020,06,02))
            };
            CatalogGoods cat = new CatalogGoods(good, Stage.Came);//присвоїли всім товарам статус "Надійшло".
            cat.Print();
            cat._status = Stage.Transferred;


            //Console.WriteLine(good.Length);//довідково виводила.

            for (int i = 0; i < good.Length; i++)
            {
                if (good[i] is HouseholdChemicals)
                {
                    cat._status = Stage.Transferred;//я так і не зрозуміла,як можна поміняти статус лише потрібному елементу.
                                                    //бо як роблю так-то міняє всім.
                }

            }

            Console.WriteLine("----------------");
            cat.Print();     



        }
    }
}
