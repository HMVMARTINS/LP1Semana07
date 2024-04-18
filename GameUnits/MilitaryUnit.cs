using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        //Sobrescreve propriedade health para adicionar XP
        public override int Health
        {
            get { return base.Health + XP;}
            set { base.Health = value;}
        }

        //Sobrescreve propriedade Cost para adicionar XP
        public override float Cost => AttackPower + XP;

        //Método para atacar outra unidade
        public void Attack(Unit u)
        {
            //Adiciona XP da própria unidade
            XP++;

            // Aplica dano igual ao AttackPower na unidade que foi atacada
            u.Health -= AttackPower;

            //Verifica se unidade alvo de ataque foi atacada
            if (u.Health <=0)
            {
                Console.WriteLine($"A unidade {u.GetType().Name} foi derrotada!");
            } 
        }
    }
}
