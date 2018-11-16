using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JSnedeker_CharacterLoadSave
{
    class Program
    {


        static void Main(string[] args)
        {
            int selection;
            List<Character> characters = new List<Character>();

            ////////////////////////////////////
            Console.WriteLine("*********************");
            Console.WriteLine("1. Create Character");
            Console.WriteLine("2. Modify Characater");
            Console.WriteLine("3. Delete Characater");
            Console.WriteLine("4. Load Characater");
            ////////////////////////////////////
            do
            {
                selection = int.Parse(Console.ReadLine()); {
                    if (selection == 1)
                    {
                        characters.Add(CreateCharacter());
                    }

                    if (selection == 2)
                    {
                        Console.WriteLine("what character");
                        string search = Console.ReadLine();
                        for (int i = 0; i < characters.Count; i++)
                        {
                            if (characters[i].name == search)
                                Character character = characters[i]

                        }
                    }
    

                

                } while (selection != 0) ;
            }
            static Character CreateCharacter()
            {

            }
            static void ModifyCharacter(Character character)
            {

            }
            static void DeleteCharacter(List<Character> characters, string characterName)
            {

            }
            static void LoadCharacter(string characterName)
            {

            }
        }
    }
}
