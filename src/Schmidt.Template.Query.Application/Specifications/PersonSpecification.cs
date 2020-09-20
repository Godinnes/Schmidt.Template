using Schmidt.Template.Common.Enumerators;
using Schmidt.Template.Query.Model.Model;
using System;
using System.Linq.Expressions;

namespace Schmidt.Template.Query.Application.Specifications
{
    public static class PersonSpecification
    {
        public static Expression<Func<Person, bool>> PersonName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return p => true;
            return p => p.Name.Contains(name);
        }
        public static Expression<Func<Person, bool>> PersonRace(RaceType? race)
        {
            if (race.HasValue)
                return p => p.Race == race;
            return p => true;
        }
    }
}
