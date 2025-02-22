using DndCharacterCreation.Models;
using Microsoft.EntityFrameworkCore;

namespace DndCharacterCreation.Data
{
    public class CharacterRepository : ICharacterRepository
    {

        private ApplicationDbContext _context;

        public CharacterRepository(ApplicationDbContext c)
        {
            _context = c;
        }



        public int AddCharacter(Character character)
        {
            _context.Characters.Add(character);
            return _context.SaveChanges();
        }

        public int DeleteCharacter(int characterId)
        {
            var character = GetCharacterById(characterId);
            _context.Characters.Remove(character);
            return _context.SaveChanges();
        }

        public List<Character> GetAllCharacters()
        {
            var characters = _context.Characters
                .Include(c => c.Attributes)
                .ToList();
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            var character = _context.Characters
               .Include(c => c.Attributes)
               .Where(c => c.CharacterId == id)
               .SingleOrDefault();
            return character;
        }

        public int UpdateCharacter(Character character)
        {
            _context.Characters.Update(character);
            return _context.SaveChanges();
        }
    }
    
}
