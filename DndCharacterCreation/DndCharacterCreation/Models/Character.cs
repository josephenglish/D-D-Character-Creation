namespace DndCharacterCreation.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public AppUser? AppUser { get; set; }

        public Attributes? Attributes { get; set; }







        public int AttributesId { get; set; }
    }
}
