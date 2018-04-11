using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class MyCreature : ICreature
    {
        public string nameOfCreature;
        public string toEat;
        public string toDrink;
        public string sourceOfImage;
        public List<string> knownTricks = new List<string>
        {
            "Be cool™",
            "Pretend to be dead",
            "Be sad for no reason",
            "Listen to sad songs",
            "Hang out with friends",
            "Smash the patriarchy"
        };

        public List<string> foodSelection = new List<string>
        {
            "canned tuna",
            "salt",
            "cold pizza",
            "ice cubes",
            "leftovers",
            "microwave ramen",
            "Tide pods"
        };

        public List<string> drinkSelection = new List<string>
        {
            "Dom Perignon",
            "cheap rose",
            "sour milk",
            "decaf latte",
            "egg yolks"
        };
            
        public MyCreature(string nameOfCreature = "Rezso", string toEat = "canned tuna", string toDrink = "Dom Perignon", string sourceOfImage = "https://i.imgur.com/c8wj3wo.png")
        {
            this.nameOfCreature = nameOfCreature;
            this.toEat = toEat;
            this.toDrink = toDrink;
            this.sourceOfImage = sourceOfImage;
        }

        public void WearSunglasses()
        {
            sourceOfImage = "https://i.imgur.com/3kdOznA.png";
        }

        public void Die()
        {
            sourceOfImage = "https://i.imgur.com/iRsvJZ0.png";
        }

        public void BeSad()
        {
            sourceOfImage = "https://i.imgur.com/W2o5yUu.png";
        }

        public void Music()
        {
            sourceOfImage = "https://i.imgur.com/PcxsO8f.png";
        }

        public void GiveName(string givenName)
        {
            nameOfCreature = givenName;
        }

        public void AddDrink(int i)
        {
            toDrink = drinkSelection[i];
        }

        public void AddFood(int i)
        {
            toEat = foodSelection[i];
        }
    }
}
