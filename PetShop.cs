using System;
using System.Collections.Generic;


namespace Fantasy_Pet_Shop
{
    public class PetShop
    {

        private List<FantasyPet> pets;

        public PetShop()
        {
            pets = new List<FantasyPet>();
        }

        public string addPet(FantasyPet FantasyPet, FantasyPet pet1, FantasyPet pet2, FantasyPet pet3)
        {
           
            pets.Add(pet1);
            pets.Add(pet2);
            pets.Add(pet3);
            pets.Add(FantasyPet);

            return $"Pet, {FantasyPet.Name}, has been added to the shop!";
        }

        public string listPets(FantasyPet FantasyPet, FantasyPet pet1, FantasyPet pet2, FantasyPet pet3)
        {
            if (pets.Count == 0)
            {
                Console.WriteLine("No pets in the shop.");
                return "dgndgn";
            }

            Console.WriteLine("\nPets in the shop: ");
            foreach (var pet in pets)
            {
                //return pet.ToString();
                Console.WriteLine(pet.ToString());

            }
            return "\nThank you!";
        }

    }
}