using System.Collections.Generic;

namespace Startlist
{
    public class Club
    {
        public string Name { get; }
        public List<Registration> Registrations { get; }

        public Club()
        {            
            Registrations = new List<Registration>();
        }

        public Club(string name) : this()
        {
            Name = name;
        }

        public void AddRegistration(Registration registration)
        {
            Registrations.Add(registration);
        }
    }
}
