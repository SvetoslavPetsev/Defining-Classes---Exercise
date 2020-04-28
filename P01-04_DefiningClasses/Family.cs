namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Family
    {
        private readonly HashSet<Person> listOfPeople;

        public Family()
        {
            this.listOfPeople = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.listOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = listOfPeople.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldest;
        }

        public string GetMemebersAbove30()
        {
            StringBuilder membersOver = new StringBuilder();

            foreach (var member in listOfPeople.OrderBy(x => x.Name).Where(x => x.Age > 30))
            {
                membersOver.AppendLine(member.ToString());
            }

            return membersOver.ToString();
        }
    }
}
