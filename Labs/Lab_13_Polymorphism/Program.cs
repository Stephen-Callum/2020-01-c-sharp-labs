using System;

namespace Lab_13_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Enemy
    {
        public Enemy()
        {
            EnemyAttack();
        }

        public virtual void EnemyAttack()
        {
            Console.WriteLine("Enemy Attacks!");
        }
    }

    class NinjaEnemy : Enemy
    {
        public NinjaEnemy()
        {
            EnemyAttack();
        }

        public override void EnemyAttack()
        {
            Console.WriteLine("NINJA ATTACK!");
        }
    }

    class BruteEnemy : Enemy
    {
        public BruteEnemy()
        {
            EnemyAttack();
        }

        public override void EnemyAttack()
        {
            Console.WriteLine("BRUTE ATTACK!");
        }
    }
}
