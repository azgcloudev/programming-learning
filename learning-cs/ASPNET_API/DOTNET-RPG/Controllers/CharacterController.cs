using DOTNET_RPG.Models;
using DOTNET_RPG.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;
using DOTNET_RPG.Dtos.Character;

namespace DOTNET_RPG.Controllers
{

    [ApiController] //api controller attribute
    [Route("api/[controller]")] // route attribute
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character {Name = "Sam", Id = 1}
        };

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<GetCharacterDto>>> GetAll()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        // function that gets the first item
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCharacterDto>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }


        // create a new character
        [HttpPost]
        public async Task<ActionResult<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<GetCharacterDto>> UpdatedCharacter(UpdateCharacterDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacter(updatedCharacter);

            if (response is null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}
