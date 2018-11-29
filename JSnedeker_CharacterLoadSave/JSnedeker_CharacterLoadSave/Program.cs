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
        static List<Character> characters = new List<Character>();
        static void Main(string[] args)
        {
            int selection;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Characters";
            do
            {
                ////////////////////////////////////
                Console.WriteLine("*********************");
                Console.WriteLine("1. Create Character");
                Console.WriteLine("2. Modify Characater");
                Console.WriteLine("3. Delete Characater");
                Console.WriteLine("4. Load Characater");
                Console.WriteLine("5. Save Characaters");
                Console.WriteLine("6. List Characaters");
                Console.WriteLine("7. Clear Console");
                Console.WriteLine("0. Quit");
                Console.WriteLine("*********************");
                ////////////////////////////////////
                selection = int.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    characters.Add(CreateCharacter());
                }

                if (selection == 2)
                {

                    Console.Clear();
                    Character character = new Character();
                    string origional = null;
                    bool found = false;

                    Console.WriteLine("what character");
                    string search = Console.ReadLine();
                    for (int i = 0; i < characters.Count; i++)
                    {
                        if (characters[i].name == search)
                        {
                            origional = characters[i].name;
                            character = characters[i];
                            found = true;

                        }
                    }
                    if (found)
                    {
                        Character newCharacter = ModifyCharacter(character);
                        using (StreamWriter sw = new StreamWriter(path + @"/" + origional + ".txt"))
                        {
                            sw.WriteLine(newCharacter.name);
                            sw.WriteLine(newCharacter.strength);
                            sw.WriteLine(newCharacter.tenacity);
                            sw.WriteLine(newCharacter.utility);
                            sw.WriteLine(newCharacter.perception);
                            sw.WriteLine(newCharacter.intelligence);
                            sw.WriteLine(newCharacter.dexterity);
                        }
                        DeleteCharacter(path, origional);
                    }
                }
                if (selection == 3)
                {
                    Console.WriteLine("what character");
                    string character = Console.ReadLine();
                    DeleteCharacter(path, character);
                }
                if (selection == 4)
                {
                    characters = LoadCharacters(path);
                }
                if (selection == 5)
                {
                    for (int i = 0; i < characters.Count; i++)
                    {
                        using (StreamWriter sw = new StreamWriter(path + @"/" + characters[i].name + ".txt"))
                        {
                            sw.WriteLine(characters[i].name);
                            sw.WriteLine(characters[i].strength);
                            sw.WriteLine(characters[i].tenacity);
                            sw.WriteLine(characters[i].utility);
                            sw.WriteLine(characters[i].perception);
                            sw.WriteLine(characters[i].intelligence);
                            sw.WriteLine(characters[i].dexterity);

                        }
                    }
                }
                if (selection == 6)
                    ListCharacters(characters);
                if (selection == 7)
                    Console.Clear();

            } while (selection != 0);
        }
        static Character CreateCharacter()
        {
            Character character = new Character();
            Console.WriteLine("Name");
            character.name = Console.ReadLine();
            Console.WriteLine("Strength");
            character.strength = int.Parse(Console.ReadLine());
            Console.WriteLine("Tenacity");
            character.tenacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Utility");
            character.utility = int.Parse(Console.ReadLine());
            Console.WriteLine("Perception");
            character.perception = int.Parse(Console.ReadLine());
            Console.WriteLine("Intelligence");
            character.intelligence = int.Parse(Console.ReadLine());
            Console.WriteLine("Dexterity");
            character.dexterity = int.Parse(Console.ReadLine());
            return character;
        }
        static Character ModifyCharacter(Character character)
        {
            int selection2 = 0;
            do
            {
                Console.WriteLine("What would you like to change");
                ////////////////////////////////////
                Console.WriteLine("*********************");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Done");
                ////////////////////////////////////
                selection2 = int.Parse(Console.ReadLine());
                if (selection2 == 1)
                {
                    Console.WriteLine("What is the new name");
                    character.name = Console.ReadLine();

                }
                if (selection2 == 2)
                {

                    Console.WriteLine("Strength");
                    character.strength = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tenacity");
                    character.tenacity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Utility");
                    character.utility = int.Parse(Console.ReadLine());
                    Console.WriteLine("Perception");
                    character.perception = int.Parse(Console.ReadLine());
                    Console.WriteLine("Intelligence");
                    character.intelligence = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dexterity");
                    character.dexterity = int.Parse(Console.ReadLine());

                }
            } while (selection2 != 3);

            return character;
        }

        static void DeleteCharacter(string path, string character)
        {
            File.Delete(path + "\\" + character + ".txt");
        }
        static List<Character> LoadCharacters(string path)
        {
            List<Character> characters = new List<Character>();

            foreach (string dirFile in Directory.GetFiles(path, "*.txt"))
            {
                using (StreamReader sr = new StreamReader(dirFile))
                {
                    Character character = new Character();
                    character.name = sr.ReadLine();
                    character.strength = int.Parse(sr.ReadLine());
                    character.tenacity = int.Parse(sr.ReadLine());
                    character.utility = int.Parse(sr.ReadLine());
                    character.perception = int.Parse(sr.ReadLine());
                    character.intelligence = int.Parse(sr.ReadLine());
                    character.dexterity = int.Parse(sr.ReadLine());
                    characters.Add(character);
                }
            }
            return characters;
        }
        static void ListCharacters(List<Character> characters)
        {
            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine(characters[i].name);
                Console.WriteLine(characters[i].strength);
                Console.WriteLine(characters[i].tenacity);
                Console.WriteLine(characters[i].utility);
                Console.WriteLine(characters[i].perception);
                Console.WriteLine(characters[i].intelligence);
                Console.WriteLine(characters[i].dexterity);
            }
        }

    }
}