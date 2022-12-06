using System;
public class Pokemon
{
	public int id {get; set;}
	public string name {get; set;}
	public int base_experience {get; set;}
	public int height {get; set;} /* in decimeters */
	public int weight {get; set;} /* in hectograms */
	public Ability[] abilities {get; set;}

}