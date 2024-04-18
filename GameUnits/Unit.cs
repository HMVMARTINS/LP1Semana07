using System;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;

        // Propriedade virtual
        public virtual int Health { get; set;}

        //Método Move
        public void move(int numberOfSpaces)
        {
            Console.WriteLine($"A unidade moveu {numberOfSpaces} casas.");
        }
        
        //Propriedade abstrata Cost do tipo float
        public abstract float Cost { get;}

        protected Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }    
    }
}
    
