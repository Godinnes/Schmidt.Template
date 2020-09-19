using Schmidt.Template.Common.Enumerators;
using System;

namespace Schmidt.Template.Domain.Entities
{
    public class Person
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public RaceType Race { get; private set; }
        private Person() { }
        private Person(Guid id,
                       string name,
                       RaceType race)
        {
            ID = id;
            Name = name;
            Race = race;
        }
        public static Person Create(string name,
                                    RaceType race)
        {
            return new Person(Guid.NewGuid(),
                              name,
                              race);
        }
    }
}
