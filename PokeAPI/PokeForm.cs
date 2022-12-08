using Microsoft.VisualBasic.Devices;
using System.Globalization;

namespace PokeAPI
{
	public partial class PokeForm : Form
	{
		private PokemonAPI api;
		private int sprite_index = 0;
		private Pokemon? poke;
		private TextInfo textInf;
		public PokeForm()
		{
			InitializeComponent();
			api = new PokemonAPI();
			textInf = new CultureInfo("en-US", false).TextInfo;
			
		}

/*		private async void buttonTest_Click(object sender, EventArgs e)
		{
			PokemonAPI.NamedAPIResourceList? pokelist = await api.GetPokemonList();
			if (pokelist != null && pokelist.results != null)
			{
				for (int i = 0; i < 20 *//*api.POKEMON_COUNT*//*; i++)
				{
					listBoxPokemon.Items.Add(textInf.ToTitleCase(pokelist.results[i].ToString()));
				}
			}
		}*/

		private async void listBoxPokemon_SelectedValueChanged(object sender, EventArgs e)
		{
			labelPokeName.Text = "Cargando...";
			Cursor = Cursors.WaitCursor;
			poke = await api.GetPokemon(listBoxPokemon.SelectedIndex);
			if (poke != null)
			{
				sprite_index = 0;
				pictureBoxSprite.Image = poke.spriteImgs?[sprite_index];
				labelPokeName.Text = textInf.ToTitleCase(poke.name ?? "");
				labelPokeID.Text = poke.id.ToString();
				labelType.Text = textInf.ToTitleCase( poke.ObtenerTipos());
				labelHeight.Text = String.Concat( (poke.height * 10).ToString(), " cm");
				labelWeight.Text = String.Concat( (poke.weight/(float)10).ToString(), " kg");
				labelXP.Text = poke.base_experience.ToString();
				listViewMoves.Items.Clear();
				for (int i = 0; i < poke.moves?.Length; i++)
				{
					listViewMoves.Items.Add(poke.moves.ElementAt(i).move?.ToString());
				}
				listViewStats.Items.Clear();
				for (int i = 0; i < poke.stats?.Length; i++)
				{
					ListViewItem item = new ListViewItem(poke.stats.ElementAt(i).stat?.name);
					item.SubItems.Add(poke.stats.ElementAt(i).base_stat.ToString());
					listViewStats.Items.Add(item);
				}

			}
			Cursor = Cursors.Default;
		}

		private void buttonSpriteNext_Click(object sender, EventArgs e)
		{
			if(poke != null)
			{
				sprite_index++;
				pictureBoxSprite.Image = poke.spriteImgs?[sprite_index % poke.spriteImgs.Count];
			}
		}

		private void buttonSpritePrev_Click(object sender, EventArgs e)
		{
			if(poke != null)
			{
				sprite_index += poke.spriteImgs.Count - 1;
				pictureBoxSprite.Image = poke.spriteImgs?[sprite_index % poke.spriteImgs.Count];
			}
		}

		private async void PokeForm_Load(object sender, EventArgs e)
		{
			PokemonAPI.NamedAPIResourceList? pokelist = await api.GetPokemonList();
			if (pokelist != null && pokelist.results != null)
			{
				for (int i = 0; i < api.POKEMON_COUNT; i++)
				{
					listBoxPokemon.Items.Add(textInf.ToTitleCase(pokelist.results[i].ToString()));
				}
			}
		}
	}
}