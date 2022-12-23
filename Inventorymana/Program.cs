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
            }
           
        }
    }
}