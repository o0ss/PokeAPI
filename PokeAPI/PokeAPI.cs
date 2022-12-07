
public class PokeAPI
{
    public HttpClient client;
    public int POKEMON_COUNT = 1154;
    public NamedAPIResourceList pokemonList;
    public Dictionary<int, string> diccPokeNames, diccPokeURLs;
	public PokeAPI()
	{
        client = new HttpClient();
        client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
                "application/json")
            );
        diccPokeNames = new Dictionary<int, string>();
        diccPokeURLs = new Dictionary<int, string>();
	}

    public class NamedAPIResource
    {
        public string name {get; set;}
        public string url {get; set;}

        public override string ToString()
        {
            return name;
        }
    }

    public class NamedAPIResourceList
    {
        public int count {get; set;}
        public string next {get; set;}
        public string previous {get; set;}
        public NamedAPIResource[] results {get; set;}
    }

    public async Task<NamedAPIResourceList> GetPokemonList()
    {
        HttpResponseMessage resp = await client.GetAsync("pokemon/?limit=10000");
        if(resp.IsSuccessStatusCode)
        {
            pokemonList = await resp.Content.ReadFromJsonAsync<NamedAPIResourceList>();
            POKEMON_COUNT = pokemonList.count;
            for (int i = 0; i < POKEMON_COUNT; i++)
            {
                if(!diccPokeNames.Contains(i))
                    diccPokeNames.Add(i, pokemonList.results[i].name);
                if(!diccPokeURLs.Contains(i))
                    diccPokeURLs.Add(i, pokemonList.results[i].url);
            }
            return pokemonList;
        }
        return null;
    }

    public async Task<Pokemon> GetPokemon(int id)
    {
        try
		{
			if (1 <= id && id <= POKEMON_COUNT)
			{
				Personaje personaje;
				HttpResponseMessage response = await client.GetAsync(string.Concat("character/", id.ToString()));
				if (response.IsSuccessStatusCode)
				{
					personaje = await response.Content.ReadFromJsonAsync<Personaje>();
					return personaje;
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

}