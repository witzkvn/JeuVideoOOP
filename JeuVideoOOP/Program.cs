using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuVideoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Il était une fois...");
            Character terminator = new Character();
            Character rambo = new Character();

            terminator.nom = "Terminator";
            terminator.pointsDeVie = 100;
            terminator.attaque = 100;
            terminator.defense = 100;

            rambo.nom = "Rambo";
            rambo.pointsDeVie = 50;
            rambo.attaque = 20;
            rambo.defense = 40;

            Console.WriteLine($"{terminator.nom} se promenait tranquillement dans une prairie, lorsque soudain {rambo.nom} surgit de nul part et se jeta sur lui !");

            rambo.Attack(terminator);
            Console.WriteLine();
            Console.WriteLine($"{terminator.nom} n'est pas très content... il riposte !");
            terminator.Attack(rambo);


            Console.ReadLine();
        }

        public class Character
        {
            public string nom;
            public int pointsDeVie;
            public int attaque;
            public int defense;

            public bool IsAlive()
            {
                return pointsDeVie > 0;
            }

            public void Attack(Character attaquedCharacter)
            {
                Console.WriteLine();
                Console.WriteLine($"{this.nom} attaque !");
                attaquedCharacter.pointsDeVie = (attaquedCharacter.pointsDeVie) - (this.attaque - attaquedCharacter.defense);

                if (!attaquedCharacter.IsAlive()) {
                    Console.WriteLine($"BOOM ! {attaquedCharacter.nom} est mort...");
                } else {
                    Console.WriteLine($"{attaquedCharacter.nom} a été attaqué ! Il lui reste {attaquedCharacter.pointsDeVie} pv...");
                }
            }
        }
    }
}
