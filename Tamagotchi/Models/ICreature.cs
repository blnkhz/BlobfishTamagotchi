using System;
namespace Tamagotchi.Models
{
    public interface ICreature
    {
        void GiveName(string creatureName);
        void WearSunglasses();
        void BeSad();
        void Die();
        void Music();
        void AddFood(int i);
        void AddDrink(int i);
    }
}