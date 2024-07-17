using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Program
    {
        //static List<Animal> RemoveEntries(List<Animal> Animals, string Value, bool IsTrue)
        //{
        //    foreach (Animal animal in Animals)
        //    {
        //        var property = animal.GetType().GetProperty(Value);
        //        if (property.GetValue(animal, null).ToString() != IsTrue.ToString())
        //        {
        //            Animals.Remove(animal);
        //        }
        //    }

        //    return Animals;
        //}

        static List<Animal> RemoveEntries(List<Animal> Animals, string propertyName, bool condition)
        {
            for (int i = Animals.Count - 1; i >= 0; i--)
            {
                var animal = Animals[i];
                var propertyInfo = typeof(Animal).GetProperty(propertyName);

                if (propertyInfo != null && !condition.Equals(propertyInfo.GetValue(animal)))
                {
                    Animals.RemoveAt(i);
                }
            }

            return Animals;
        }

        static void Main(string[] args)
        {
            List<Animal> Animals = GetAnimals();
            List<Question> Questions = GetQuestions();

            Console.WriteLine("Only respond with yes and no (or y/n)\nPress any key to continue.");
            Console.ReadKey();

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.Clear();
                Console.WriteLine(Questions[i].QuestionName);
                string Response = Console.ReadLine().ToLower();
                if (Response.Substring(0, 1) == "y")
                {
                    Animals = RemoveEntries(Animals, Questions[i].Value, true);
                    continue;
                }
            }

            Console.Clear();

            Console.WriteLine("Is your animal one of the following? " + string.Join(", ", Animals.Select(a => a.Name)));
            Console.ReadKey();
        }

        static List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();
            questions.Add(new Question() {QuestionName = "Does your animal eat meat?", Value="EatsMeat"});
            questions.Add(new Question() {QuestionName = "Does your animal have 4 legs?", Value="Has4Legs"});
            questions.Add(new Question() {QuestionName = "Does your animal bave stripes?", Value="HasStripes"});

            return questions;
        }

        static List<Animal> GetAnimals()
        {
            List<Animal> animals = new List<Animal>();

            // Adding animals to the list
            animals.Add(new Animal() { Name = "Horse", EatsMeat = false, Has4Legs = true, HasStripes = false });
            animals.Add(new Animal() { Name = "Cow", EatsMeat = false, Has4Legs = true, HasStripes = false });
            animals.Add(new Animal() { Name = "Sheep", EatsMeat = false, Has4Legs = true, HasStripes = false });
            animals.Add(new Animal() { Name = "Pig", EatsMeat = true, Has4Legs = true, HasStripes = false });
            animals.Add(new Animal() { Name = "Dog", EatsMeat = true, Has4Legs = true, HasStripes = false });
            animals.Add(new Animal() { Name = "Cat", EatsMeat = true, Has4Legs = true, HasStripes = true });
            animals.Add(new Animal() { Name = "Lion", EatsMeat = true, Has4Legs = true, HasStripes = false });
            animals.Add(new Animal() { Name = "Tiger", EatsMeat = true, Has4Legs = true, HasStripes = true });
            animals.Add(new Animal() { Name = "Whale", EatsMeat = false, Has4Legs = false, HasStripes = false });
            animals.Add(new Animal() { Name = "Dolphin", EatsMeat = false, Has4Legs = false, HasStripes = false });
            animals.Add(new Animal() { Name = "Seal", EatsMeat = false, Has4Legs = false, HasStripes = false });
            animals.Add(new Animal() { Name = "Penguin", EatsMeat = false, Has4Legs = false, HasStripes = true });
            animals.Add(new Animal() { Name = "Ostrich", EatsMeat = false, Has4Legs = false, HasStripes = false });
            animals.Add(new Animal() { Name = "Sparrow", EatsMeat = true, Has4Legs = false, HasStripes = true });
            animals.Add(new Animal() { Name = "Spider", EatsMeat = true, Has4Legs = false, HasStripes = false });
            animals.Add(new Animal() { Name = "Ant", EatsMeat = true, Has4Legs = true, HasStripes = false });
            animals.Add(new Animal() { Name = "Bee", EatsMeat = false, Has4Legs = false, HasStripes = true });
            animals.Add(new Animal() { Name = "Wasp", EatsMeat = false, Has4Legs = false, HasStripes = true });
            animals.Add(new Animal() { Name = "Termite", EatsMeat = false, Has4Legs = false, HasStripes = false });
            animals.Add(new Animal() { Name = "Octopus", EatsMeat = true, Has4Legs = false, HasStripes = false });
            animals.Add(new Animal() { Name = "Squid", EatsMeat = true, Has4Legs = false, HasStripes = false });

            return animals;
        }
    }
}
