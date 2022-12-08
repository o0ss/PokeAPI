using System;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Http.Headers;

public class Pokemon
{
	public int id { get; set; }
	public string? name { get; set; }
	public int? base_experience { get; set; }
	public int? height { get; set; } /* in decimeters */
	public int? weight { get; set; } /* in hectograms */
	public Ability[]? abilities { get; set; }
	public PokemonAPI.NamedAPIResource[]? forms { get; set; }

	public PokemonMove[]? moves { get; set; }
	public PokemonSprite? sprites { get; set; }
	//public int sprites_count { get; set; }
	public List<Image> spriteImgs { get; set; }
	public PokemonAPI.NamedAPIResource? species { get; set; }

	public PokemonStat[]? stats { get; set; }
	public PokemonType[]? types { get; set; }

	public Pokemon()
	{
		spriteImgs = new List<Image>();
	}
	public class Ability
	{
		public bool? is_hidden { get; set; }
		public int? slot { get; set; }
		public PokemonAPI.NamedAPIResource? ability { get; set; }

	}
	public class PokemonMove
	{
		public PokemonAPI.NamedAPIResource? move { get; set; }

	}
	public class PokemonSprite
	{
		public string? front_default { get; set; }
		public string? front_shiny { get; set; }
		public string? front_female { get; set; }
		public string? front_shiny_female { get; set; }
		public string? back_default { get; set; }
		public string? back_shiny { get; set; }
		public string? back_female { get; set; }
		public string? back_shiny_female { get; set; }
	}
	public class PokemonStat
	{
		public PokemonAPI.NamedAPIResource? stat { get; set; }

		public int? effort { get; set; }
		public int? base_stat { get; set; }
	}
	public class PokemonType
	{
		public int? slot { get; set; }
		public PokemonAPI.NamedAPIResource? type { get; set; }
	}

	public async void ObtenerImg()
	{
		Image tmp;
		try
		{
			tmp = await ImageFromString(sprites?.front_default);
			if(tmp != null) spriteImgs.Add(tmp);
			tmp = await ImageFromString(sprites?.front_female);
			if (tmp != null) spriteImgs.Add(tmp);
			tmp = await ImageFromString(sprites?.front_shiny);
			if (tmp != null) spriteImgs.Add(tmp);
			tmp = await ImageFromString(sprites?.front_shiny_female);
			if (tmp != null) spriteImgs.Add(tmp);
			tmp = await ImageFromString(sprites?.back_default);
			if (tmp != null) spriteImgs.Add(tmp);
			tmp = await ImageFromString(sprites?.back_female);
			if (tmp != null) spriteImgs.Add(tmp);
			tmp = await ImageFromString(sprites?.back_shiny);
			if (tmp != null) spriteImgs.Add(tmp);
			tmp = await ImageFromString(sprites?.back_shiny_female);
			if (tmp != null) spriteImgs.Add(tmp);
		}
		catch (Exception e)
		{
			await global::System.Console.Out.WriteLineAsync(e.ToString());
			throw;
		}
	}

	private async Task<Image> ImageFromString(string? img_url)
	{
		try
		{
			if(img_url != null)
			{
				using (HttpClient img_c = new HttpClient())
				{
					byte[] imageData = img_c.GetByteArrayAsync(img_url).GetAwaiter().GetResult();
					using (MemoryStream stream = new MemoryStream(imageData))
					{
						return Image.FromStream(stream);
					}
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

	public string ObtenerTipos()
	{
		string tipos = types?[0].type?.ToString() ?? "";

		for (int i = 1; i < types?.Length; i++)
		{
			tipos = String.Concat(tipos, ", ", (types[i]?.type?.ToString()) ?? "" );
		}
		return tipos;
	}
}