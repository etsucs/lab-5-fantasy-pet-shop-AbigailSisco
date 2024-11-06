namespace Fantasy_Pet_Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PetShop petShop = new PetShop();

            Console.WriteLine("What is the pet's name? \n");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat is the species of pet?\n");
            string species = Console.ReadLine();

            Console.WriteLine("\nWhat is the age of the pet in years?\n");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the price of the pet in USD?\n");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the percentage discount? (ex. 50% you enter .50):\n");
            decimal percentage = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the magic power of the pet?\nChoose one of these options:\nTelepathy\nLaser Eyes\nTeleportation\n");
            string magicPower = Console.ReadLine();

            FantasyPet FantasyPet = new FantasyPet(name, species, age, price, magicPower, percentage);
            FantasyPet pet1 = new FantasyPet("Asher", "Snake", 23, 23, "Flying", .43m);
            FantasyPet pet2 = new FantasyPet("Muncher", "Rock", 4353, 5, "Talking", .0m);
            FantasyPet pet3 = new FantasyPet("Snickle", "Blue Jay", 3, 5445, "Fire-Breathing", .1m);

            Console.WriteLine(FantasyPet.describePet());
            Console.WriteLine($"Discounted Price: {FantasyPet.discountPrice()}");
            Console.WriteLine(FantasyPet.performMagic());
            Console.WriteLine(petShop.addPet(FantasyPet, pet1, pet2, pet3));
            Console.WriteLine(petShop.listPets(FantasyPet, pet1, pet2, pet3));

            
            
            

        }

    }
}
