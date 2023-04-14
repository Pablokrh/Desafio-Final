using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Model
{
    public class Store
    {
        private string name;
        private string adress;
        private ArrayList clothesList = new ArrayList();
        public Store()
        {
            name = "TodoRopa Tiendas";
            adress = "Venezuela 3558";
            clothesList = new ArrayList();
            FillClothesList();
        }

        public string Name { get => name; }
        public string Adress { get => adress; }
        public ArrayList ClothesList { get => clothesList; }
               
        private void FillClothesList()
        {
            clothesList.Add(new Pants("Normal", 250,"Premium",100));
            clothesList.Add(new Pants("Normal", 250,"Standard", 100));
            clothesList.Add(new Pants("Skinny", 750,"Premium", 100));
            clothesList.Add(new Pants("Skinny", 750,"Standard", 100));
            clothesList.Add(new Shirt("Long", "Mao",75, "Premium", 100));
            clothesList.Add(new Shirt("Long", "Mao",75, "Standard", 100));
            clothesList.Add(new Shirt("Long", "Normal",150, "Premium", 100));
            clothesList.Add(new Shirt("Long", "Normal",150, "Standard", 100));
            clothesList.Add(new Shirt("Short", "Normal",175, "Premium", 100));
            clothesList.Add(new Shirt("Short", "Normal",175, "Standard", 100));
            clothesList.Add(new Shirt("Short", "Mao", 100, "Premium", 100));
            clothesList.Add(new Shirt("Short", "Mao", 100, "Standard", 100));


        }
    }
}

    

        


