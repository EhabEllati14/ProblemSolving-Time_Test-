using System;
using System.Collections.Generic;

namespace ProblemSolving_Time_Test_
{
    class Person
    {
        public string name { get; set; }
        public List<Person> friends { get; set; }

        public static Person DeepClone(Person person)
        {
            var visited = new Dictionary<object, object>();
            return DeepCloneInternal(person, visited);
        }
        private static Person DeepCloneInternal(Person person, Dictionary<object, object> visited)
        {
            if (person == null) return null;

            if (visited.ContainsKey(person))
                return (Person)visited[person];

            var clone = new Person { name = person.name };
            visited[person] = clone;

            if (person.friends != null)
            {
                clone.friends = new List<Person>();
                foreach (var f in person.friends)
                {
                    clone.friends.Add(DeepCloneInternal(f, visited));
                }
            }

            return clone;
        }
    }
}
