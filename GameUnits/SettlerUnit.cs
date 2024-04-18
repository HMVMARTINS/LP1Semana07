using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        // Construtor que inicia a class movement = 1 e a health =3
        public SettlerUnit() : base(1,3)
        {    
        }

        //Sobrescreve a propriedade Cost para retornar 5
        public override float Cost => 5;
    }
}