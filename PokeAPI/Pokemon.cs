using System;
public class Pokemon
{
	public int id {get; set;}
	public string name {get; set;}
	public int base_experience {get; set;}
	public int height {get; set;} /* in decimeters */
	public int weight {get; set;} /* in hectograms */
	public Ability[] abilities {get; set;}
	public NamedAPIResource[] forms {get; set;}
	
	public PokemonMove[] moves {get; set;}
	public PokemonSprite sprites {get; set;}
	public NamedAPIResource species {get; set;}
	
	public PokemonStat[] stats {get; set;}
	public PokemonType[] types {get; set;}

	public class Ability
	{
		public bool is_hidden {get; set;}
		public int slot {get; set;}
		public NamedAPIResource ability {get; set;}
		
	}
	public class PokemonMove
	{
		public NamedAPIResource move {get; set;}
		
	}
	public class PokemonSprite
	{
		public string front_default {get; set;}
		public string front_shiny {get; set;}
		public string front_female {get; set;}
		public string front_shiny_female {get; set;}
		public string back_default {get; set;}
		public string back_shiny {get; set;}
		public string back_female {get; set;}
		public string back_shiny_female {get; set;}
	}
	public class PokemonStat
	{
		public NamedAPIResource stat {get; set;}
		
		public int effort {get; set;}
		public int base_stat {get; set;}
	}
	public class PokemonType
	{
		public int slot {get; set;}
		public NamedAPIResource type {get; set;}
		
	}
}