using Microsoft.AspNetCore.Mvc.ModelBinding;
using pokemonReviewApp.Models;

namespace pokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons(); 

        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string Name);

        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);

        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool Save();
    }
}
