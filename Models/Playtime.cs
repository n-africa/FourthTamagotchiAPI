using System;

namespace FourthTamagotchiAPI.Models
{
    public class Playtime
    {
        public int ID { get; set; }
        public DateTime When { get; set; }
        public Pet PetID { get; set; }
    }
}