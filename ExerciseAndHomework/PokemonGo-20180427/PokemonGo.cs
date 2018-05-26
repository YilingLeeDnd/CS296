using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGo_20180427
{
    public partial class PokemonGo : Form
    {
        public int pokemonCp = 959;
        public string pokemonName = "鬼斯通";
        public int pokemonHp = 60;
        public int pokemonMaxHp = 60;
        public float pokemonWeight = 1.1f;
        public float pokemonHeight = 1.69f;
        public int playerStardust = 230929;
        public int playerGastlyCandy = 106;
        public int pokemonPowerUpStardust = 3000;
        public int pokemonPowerUpCandy = 3;
        public int pokemonEvolveCandy = 100;

        private int gengarPokemonCp = 2100;
        private int gengarPokemonHp = 100;
        private int gengarPokemonMaxHp = 100;
        private float gengarPokemonWeight = 47.95f;
        private float gengarPokemonHeight = 1.62f;

        public PokemonGo()
        {
            InitializeComponent();
            Render();
        }

        public void Render()
        {
            PokemonPictureBox.Image = Image.FromFile("..\\..\\Haunter.png");
            PokemonCpLabel.Text = pokemonCp.ToString();
            PokemonNameLabel.Text = pokemonName.ToString();
            PokemonHpLabel.Text = pokemonHp.ToString();
            PokemonMaxHpLabel.Text = pokemonMaxHp.ToString();
            PokemonWeightLabel.Text = pokemonWeight.ToString("##.##");
            PokemonHeightLabel.Text = pokemonHeight.ToString("##.##");
            PlayerStardustLabel.Text = playerStardust.ToString();
            PlayerGastlyCandyLabel.Text = playerGastlyCandy.ToString();
            PokemonPowerUpStardustLabel.Text = pokemonPowerUpStardust.ToString();
            PokemonPowerUpCandyLabel.Text = pokemonPowerUpCandy.ToString();
            PokemonEvolveCandyLabel.Text = pokemonEvolveCandy.ToString();

            if (pokemonEvolveCandy > playerGastlyCandy)
            {
                EvolveButton.Enabled = false;
            }
            if (pokemonPowerUpStardust > playerStardust || pokemonPowerUpCandy > playerGastlyCandy)
            {
                PowerUpButton.Enabled = false;
            }
        }

        private void PowerUpButton_Click(object sender, EventArgs e)
        {
            playerStardust = playerStardust - pokemonPowerUpStardust;
            PlayerStardustLabel.Text = playerStardust.ToString();

            playerGastlyCandy = playerGastlyCandy - pokemonPowerUpCandy;
            PlayerGastlyCandyLabel.Text = playerGastlyCandy.ToString();

            if (pokemonEvolveCandy > playerGastlyCandy)
            {
                EvolveButton.Enabled = false;
            }
            if (pokemonPowerUpStardust > playerStardust || pokemonPowerUpCandy > playerGastlyCandy)
            {
                PowerUpButton.Enabled = false;
            }
            if (pokemonName == "耿鬼")
            {
                gengarPokemonCp = gengarPokemonCp + 5;
                PokemonCpLabel.Text = gengarPokemonCp.ToString();

                gengarPokemonHp = gengarPokemonHp + 5;
                gengarPokemonMaxHp = gengarPokemonMaxHp + 5;
                PokemonHpLabel.Text = gengarPokemonHp.ToString();
                PokemonMaxHpLabel.Text = gengarPokemonMaxHp.ToString();
            }
            else
            {
                pokemonCp = pokemonCp + 5;
                PokemonCpLabel.Text = pokemonCp.ToString();

                pokemonHp = pokemonHp + 5;
                pokemonMaxHp = pokemonMaxHp + 5;
                PokemonHpLabel.Text = pokemonHp.ToString();
                PokemonMaxHpLabel.Text = pokemonMaxHp.ToString();
            }
        }

        private void EvolveButton_Click(object sender, EventArgs e)

        {
            PokemonCpLabel.Text = gengarPokemonCp.ToString();
            PokemonHpLabel.Text = gengarPokemonHp.ToString();
            PokemonMaxHpLabel.Text = gengarPokemonMaxHp.ToString();

            playerGastlyCandy = (playerGastlyCandy - pokemonEvolveCandy);
            PlayerGastlyCandyLabel.Text = playerGastlyCandy.ToString();

            if (pokemonEvolveCandy > playerGastlyCandy)
            {
                EvolveButton.Enabled = false;
                PokemonEvolveCandyLabel.Visible = PokemonEvolveCandyPictureBox.Visible = EvolveButton.Visible = false;
                PokemonPictureBox.Image = Image.FromFile("..\\..\\Gengar.png");
                PokemonNameLabel.Text = pokemonName = "耿鬼";
                PokemonWeightLabel.Text = gengarPokemonWeight.ToString("##.##");
                PokemonHeightLabel.Text = gengarPokemonHeight.ToString("##.##");
                if (pokemonPowerUpStardust > playerStardust || pokemonPowerUpCandy > playerGastlyCandy)
                {
                    PowerUpButton.Enabled = false;
                }
            }
        }
    }
}