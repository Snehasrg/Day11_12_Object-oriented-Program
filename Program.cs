namespace ObjectOrientedPgm
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to the Object Oriented Program *****");

            string path = @" D:\240\ObjectOrientedProgram\ObjectOrientedPgm\Inventory.json";
            ReadData obj = new ReadData();
            var Info = obj.Read(path);

            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Stock is:");
            Console.WriteLine("--------------------");
            for (int i = 0; i < Info.typesOfStock.Count; i++)
            {
                Console.WriteLine("Name: " + Info.typesOfStock[i].name);
                Console.WriteLine("NoOfshare: " + Info.typesOfStock[i].NoOfshare);
                Console.WriteLine("price: " + Info.typesOfStock[i].price);

                int val = Info.typesOfStock[i].NoOfshare * Info.typesOfStock[i].price;
                Console.WriteLine("The price for " + Info.typesOfStock[i].NoOfshare + " Stock is " + val);
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");


        }
    }
}


