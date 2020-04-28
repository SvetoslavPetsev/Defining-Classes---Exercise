namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());

            Family familyMembers = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                Person member = new Person(name, age);
                
                familyMembers.AddMember(member);
            }

            Console.WriteLine(familyMembers.GetMemebersAbove30());
        }
    }
}
