using Pokemon_Battle.pokemons;

namespace Pokemon_Battle
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemon>();
            pokemons.Add(new Torchic());
            pokemons.Add(new Lotad());
            pokemons.Add(new Taillow());
            pokemons.Add(new Wingull());

            this.monster = new Wurmple();
            this.pictureBox2.Image = this.monster.getImage();

            this.pictureBox2.Image = monster.getImage();
            this.tbName2.Text = monster.getName();
            this.tbHP2.Text = monster.getHP().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int damage = this.monster.getDefense() - this.selectedPokemon.getAttack();
            this.monster.takeDamage(damage);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}