using System.Text.Json.Serialization;

namespace Schmidt.Template.Common.Enumerators
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RaceType
    {
        Human = 0,
        Orc = 1,
        Elf = 2,
        Dwarf = 3
    }
}
