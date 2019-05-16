using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoFunctional
{
    class Program
    {

        static List<string> TodoTitles = new List<string>();
        static List<bool> TodoCompleted = new List<bool>();
        static int togglenum = 0;


        static int AddTodo(string title, bool completed)
        {
            var index = TodoTitles.Count;
            TodoTitles.Add(title);
            TodoCompleted.Add(completed);

            return index;
        }
        static void RemoveTodo(int index)
        {
            TodoTitles.RemoveAt(index);
            TodoCompleted.RemoveAt(index);
        }

        static void DisplayTodo(int index)
        {
            var title = TodoTitles[index];
            var completed = TodoCompleted[index];

            if (completed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(" - " + title);
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void DrawSepearator()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", Console.BufferWidth)));
        }
        static void DisplayAllTodos()
        {
            DrawSepearator();
            for (int i = 0; i < TodoTitles.Count; i++)
            {
                DisplayTodo(i);
            }

            DrawSepearator();
        }

        static void ReadNewTodo()
        {
            Console.WriteLine("Add Todo: ");
            
            Console.WriteLine("enter title of new todo here");
            string newtitle = Console.ReadLine();

            AddTodo(newtitle,false);
            
        }

        static void ReadToggleExistingTodo()
        {
            Console.WriteLine("Toggle Todo: ");
            togglenum = -1 + int.Parse(Console.ReadLine());
            if (TodoCompleted[togglenum] == true)
            {
                TodoCompleted[togglenum] = false;
            }else TodoCompleted[togglenum] = true;


        }

        static void ReadRemoveTodo()
        {
            Console.WriteLine("Remove Todo: ");
            Console.WriteLine("wich one");
            RemoveTodo(-1+ int.Parse(Console.ReadLine()));
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Todo Application");

           
            AddTodo("Get the shopping from the store because you a lazy dude and had to pre order it", false);
            AddTodo("Kiss a tree because climate", false);
            AddTodo("Finish this task because you are a model student", false);
            AddTodo("Go to Intro Class this arvo", true);
            AddTodo("die", true);
            AddTodo("raise from the dead", false);
            AddTodo("start cult", false);
            AddTodo("profit", false);



            while (true)
            {
                Console.Clear();
                DisplayAllTodos();
                Console.WriteLine("Pick an option:");
                Console.WriteLine(" (1) -> Create Todo");
                Console.WriteLine(" (2) -> Toggle Completed");
                Console.WriteLine(" (3) -> Remove Todo");
                Console.WriteLine(" (4) -> Exit");


                var key = Console.ReadKey(true);

                if(key.Key == ConsoleKey.D1)
                {
                    ReadNewTodo();
                }
                else if(key.Key == ConsoleKey.D2)
                {
                    ReadToggleExistingTodo();
                }
                else if(key.Key == ConsoleKey.D3)
                {
                    ReadRemoveTodo();
                }
                else if(key.Key == ConsoleKey.D4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nah you dumb, give me a valid answer please. Press any key to stop me raging at you....");
                    Console.ReadKey(true);
                }                

            }

        }
    }
}
