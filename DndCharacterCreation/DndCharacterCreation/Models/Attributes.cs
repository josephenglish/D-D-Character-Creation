namespace DndCharacterCreation.Models
{
    public class Attributes
    {
        public int AttributesId { get; set; }

        public string? Name { get; set; }

        public string? Class {  get; set; }

        public string? Species { get; set; }

        public string? Background { get; set; }

        public string? Alignment { get; set; }

        public int Level { get; set; } = 1;

        public int Experience { get; set; } = 0;
    }
}
