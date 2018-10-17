using System;

namespace Startlist
{
    public class Registration
    {
        public int StartNo { get; private set; }
        public string Name { get; private set; }
        public string Club { get; private set; }
        public string Nationality { get; private set; }
        public string Group { get; private set; }
        public string Class { get; private set; }

        public Registration(string[] values)
        {
            var success = int.TryParse(values[0], out var number);
            if (success)
            {
                StartNo = number;
            }
            else
            {
                StartNo = -1;
            }
            
            Name = values[1];
            Club = values[2];
            Nationality = values[3];
            Group = values[4];
            Class = values[5];
        }

        public Registration(int startNo, string name, string club, string nationality, string @group, string @class)
        {
            StartNo = startNo;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = @group;
            Class = @class;
        }

        public void Show()
        {
            Console.WriteLine(GetText());
        }

        public string GetText()
        {
            return StartNo + ": " + Name + " (" + Club + ") " + Nationality + " - " + Group + " - " + Class;
        }
    }
}
