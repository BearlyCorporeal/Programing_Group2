using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDoICallThis
{
    class Program
    {
        static void Main(string[] args) {
            string input;
            input = Console.ReadLine();
            int inputparse= 10;
            healPotion hp1 = new healPotion(50);
            takedamage dmg1 = new takedamage(inputparse);
            person p1 = new person("fred ", 100, hp1, dmg1);
           
            
         
            Console.WriteLine("p1 name " + p1.name);
            Console.WriteLine("p1 health " + p1.healthpool);
            Console.WriteLine("potion value " + p1.potion1.health);

            if (input == "h")
            {
                p1.usepotion();
            }
            else
            {
                inputparse = int.Parse(input);
                p1.takedmg();

            }

            Console.WriteLine("p1 health " + p1.healthpool);


            Console.ReadKey();
        }
    }
    public class takedamage {
        public int damage;

        public takedamage(int d) {
            damage = d;
        }
        public int receive() {
            return damage;
        }
    }

    public class healPotion {
        public int health;

        //constructor
        public healPotion(int h) {
            health = h;
        }
        public int use(){
            return health;
        }

    }
    public class person {
        public string name;
        public int healthpool;
        public healPotion potion1;
        public takedamage damage1;

        public person(string n, int hp, healPotion p,takedamage d) {
            name = n;
            healthpool = hp;
            potion1 = p;
            damage1 = d;
        }


        public void usepotion() {
            potion1.use();
                healthpool += potion1.use();
                potion1 = null;

        }
        public void takedmg() {
            damage1.receive();
            healthpool -= damage1.receive();
        }
    }
}
