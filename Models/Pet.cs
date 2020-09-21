using System;

namespace FourthTamagotchiAPI.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int HungerLevel { get; set; }
        public int HappinessLevel { get; set; }
    }
}