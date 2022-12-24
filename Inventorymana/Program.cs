namespace Inventorymana
{
     class program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Dell\source\repos\Inventorymana\Inventorymana\Inventory.json";
            FetchInventoryDetails fetchInventoryDetails=new FetchInventoryDetails();
            Details data =fetchInventoryDetails.Read(path);
            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].price);
                Console.WriteLine(data.typesOfRice[i].weight);
                int Totalprice = data.typesOfRice[i].weight * data.typesOfRice[i].price;
                Console.WriteLine("The Price For " + data.typesOfRice[i].weight + "kg is :" + Totalprice);
                Console.WriteLine("-----------------------------------------");
            }
            for (int i = 0; i < data.typesOfwheat.Count; i++)
            {
                Console.WriteLine(data.typesOfwheat[i].name);
                Console.WriteLine(data.typesOfwheat[i].price);
                Console.WriteLine(data.typesOfwheat[i].weight);
                int Totalprice = data.typesOfwheat[i].weight * data.typesOfwheat[i].price;
                Console.WriteLine("The Price For " + data.typesOfwheat[i].weight + "kg is :" + Totalprice);
                Console.WriteLine("-----------------------------------------");
            }
            for (int i = 0; i < data.typesOfpulses.Count; i++)
            {
                Console.WriteLine(data.typesOfpulses[i].name);
                Console.WriteLine(data.typesOfpulses[i].price);
                Console.WriteLine(data.typesOfpulses[i].weight);
                int Totalprice = data.typesOfpulses[i].weight * data.typesOfpulses[i].price;
                Console.WriteLine("The Price For " + data.typesOfpulses[i].weight + "kg is :" + Totalprice);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}