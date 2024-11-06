

namespace Fantasy_Pet_Shop
{
    public class FantasyPet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public string MagicPower { get; set; }
        public decimal Percentage { get; set; }

        public FantasyPet(string name, string species, int age, decimal price, string magicPower, decimal percentage)
        {
            Name = name;
            Species = species;
            Age = age;
            Price = price;
            MagicPower = magicPower;
            Percentage = percentage;    

        }

        public string describePet()
        {
            return $"\n\nThis pet is named, {Name}. {Name} is a(an) {Age} year old {Species}. {Name} has {MagicPower} powers, and is ${Price} USD.\n";
        }
        
        public decimal discountPrice()
        {
            return Price - (Percentage * Price); 
        }
        
        public string performMagic()
        {
            while (true){
                if (MagicPower=="Telepathy")
                {
                    return $"\n\"{Name}, Would you mind showing our guest here your talents?\"\n{Name} looks up at you and starts to sing the \"The Star-Spangled Banner in your mind.\"\n\n";
                    
                }
                else if (MagicPower=="Laser Eyes")
                {
                    return $"\n\"{Name}, can you do a little target practice for us?\"\n{Name} turns around and shoots the target on the other side of the room with their lasers.\n\n";
                    
                }
                else if (MagicPower=="Teleportation")
                {
                    return $"\n\"{Name}, Would you mind coming over here really quick?\"\n{Name} teleports over onto shelf behind the cashier.\n\n";
                 
                }
                else{
                    Console.WriteLine("\n\nThat wasn't an option, dumb-dumb. Try again");
                    MagicPower=GetUserInput();
                }
            }
        }

        private string GetUserInput()
        {
            Console.WriteLine("\nOne More time, what is the magic power of the pet?\nChoose one of THESE options:\nTelepathy\nLaser Eyes\nTeleportation\n");
            return Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Name}, {Age} year(s) old, {Species}, {MagicPower}, ${Price}, discount price: ${Price - (Percentage * Price)}";
        }
    }

}

        