using System.Net.Http.Json;
using System.Text.Json;

public class PokemonAPI
{
	public HttpClient client;
	JsonSerializerOptions json_options;
	public int POKEMON_COUNT = 1154;
	public NamedAPIResourceList? pokemonList;
	public Dictionary<int, string?> diccPokeNames, diccPokeURLs;
	public Dictionary<int, Pokemon?> diccPokemons;
	public PokemonAPI()
	{
		client = new HttpClient
		{
			BaseAddress = new Uri("https://pokeapi.co/api/v2/")
		};
		client.DefaultRequestHeaders.Accept.Clear();
		client.DefaultRequestHeaders.Accept.Add(
			new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
				"application/json")
			);
		diccPokeNames = new Dictionary<int, string?>();
		diccPokeURLs = new Dictionary<int, string?>();
		diccPokemons = new Dictionary<int, Pokemon?>();
		json_options = new JsonSerializerOptions
		{
			DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
		};
	}

	public class NamedAPIResource
	{
		public string? name {get; set;}
		public string? url {get; set;}

		public override string ToString()
		{
			return name ?? "";
		}
	}

	public class NamedAPIResourceList
	{
		public int count {get; set;}
		public string? next {get; set;}
		public string? previous {get; set;}
		public NamedAPIResource[]? results {get; set;}
	}

	public async Task<NamedAPIResourceList?> GetPokemonList()
	{
		HttpResponseMessage resp = await client.GetAsync("pokemon/?limit=20");
		if(resp.IsSuccessStatusCode)
		{
			pokemonList = await resp.Content.ReadFromJsonAsync<NamedAPIResourceList>();
			if (pokemonList != null && pokemonList.results != null)
			{
				POKEMON_COUNT = pokemonList.count;
				//for (int i = 0; i < POKEMON_COUNT; i++)
					for (int i = 0; i < 20 ; i++)
					{
						if (!diccPokeNames.ContainsKey(i))
						diccPokeNames.Add(i, pokemonList.results[i].name);
					if (!diccPokeURLs.ContainsKey(i))
						diccPokeURLs.Add(i, pokemonList.results[i].url);
				}
				return pokemonList;
			}
		}
		return null;
	}

	public async Task<Pokemon?> GetPokemon(int id_local)
	{
		try
		{
			if (diccPokemons.ContainsKey(id_local))
				return diccPokemons[id_local];

			if (0 <= id_local && id_local <= POKEMON_COUNT)
			{
				Pokemon? poke;
				HttpResponseMessage response = await client.GetAsync(new Uri(diccPokeURLs[id_local] ?? ""));
				if (response.IsSuccessStatusCode)
				{
					poke = await response.Content.ReadFromJsonAsync<Pokemon>(json_options);
					poke?.ObtenerImg();
					diccPokemons.Add(id_local, poke);
					return poke;
				}
			}
			return null;
		}
		catch (Exception e)
		{
			await global::System.Console.Out.WriteLineAsync(e.ToString());
			throw;
		}
	}

	/*public async Task<Pokemon> GetPokemon(string name)
	{
		if( diccPokeNames.ContainsValue(name) )
		{
			diccPokeNames.
		}
	}*/

}