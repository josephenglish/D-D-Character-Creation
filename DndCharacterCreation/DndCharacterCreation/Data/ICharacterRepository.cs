using DndCharacterCreation.Models;
using Microsoft.EntityFrameworkCore;

namespace DndCharacterCreation.Data
{
    public interface ICharacterRepository
    {
        public List<Character> GetAllCharacters();

        public Character GetCharacterById(int id);
        public int DeleteCharacter(int characterId);

        public int UpdateCharacter(Character character);

        public int AddCharacter(Character character);
    }
}
