namespace PokeAPI
{
	public partial class PokeForm : Form
	{
		private PokemonAPI api;
		public PokeForm()
		{
			InitializeComponent();
			api = new PokemonAPI();
		}

		private async void buttonTest_Click(object sender, EventArgs e)
		{
			PokemonAPI.NamedAPIResourceList? pokelist = await api.GetPokemonList();
			if (pokelist != null && pokelist.results != null)
			{
				for (int i = 0; i < 20 /*api.POKEMON_COUNT*/; i++)
				{
					listViewPokemon.Items.Add(pokelist.results[i].ToString());
					listBoxPokemon.Items.Add(pokelist.results[i].ToString());
				}
			}
		}

		private async void listBoxPokemon_SelectedValueChanged(object sender, EventArgs e)
		{
			Pokemon? poke = await api.GetPokemon(listBoxPokemon.SelectedIndex);
			if (poke != null)
			{
				pictureBoxSprite.Image = poke.spriteImg;
				labelPokeName.Text = poke.name;
				labelPokeID.Text = poke.id.ToString();
				labelType.Text = poke.ObtenerTipos();
				labelHeight.Text = poke.height.ToString();
				labelWeight.Text = poke.weight.ToString();
			}
		}
	}
}