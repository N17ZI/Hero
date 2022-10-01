using MongoDB.Driver;
namespace Hero
{
    public partial class lblLVL : System.Windows.Forms.Form
    {
        public lblLVL()
        {
            InitializeComponent();
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                cNames.Items.Add(item?.Name);
            }
        }

        private void cmbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbHeroes.Text)
            {
                case "Wizard":
                    trbS.Maximum = 45;
                    trbS.Minimum = 10;
                    trbD.Maximum = 70;
                    trbD.Minimum = 20;
                    trbi.Maximum = 250;
                    trbi.Minimum = 30;
                    trbC.Maximum = 60;
                    trbC.Minimum = 15;
                    break;
                case "Warrior":
                    trbS.Maximum = 250;
                    trbS.Minimum = 30;
                    trbD.Maximum = 70;
                    trbD.Minimum = 15;
                    trbi.Maximum = 50;
                    trbi.Minimum = 10;
                    trbC.Maximum = 100;
                    trbC.Minimum = 20;

                    break;
                case "Rogue":
                    trbS.Maximum = 55;
                    trbS.Minimum = 15;
                    trbD.Maximum = 250;
                    trbD.Minimum = 30;
                    trbi.Maximum = 70;
                    trbi.Minimum = 15;
                    trbC.Maximum = 80;
                    trbC.Minimum = 20;
                    break;
            }
        }

        private void trbS_Scroll(object sender, EventArgs e)
        {
            lblS.Text = String.Format("Strendh: {0}", trbS.Value);
        }

        private void trbD_Scroll(object sender, EventArgs e)
        {
            lblD.Text = String.Format("Dexterity: {0}", trbD.Value);
        }

        private void trbC_Scroll(object sender, EventArgs e)
        {
            lblC.Text = String.Format("Constitution: {0}", trbC.Value);
        }

        private void trbi_Scroll(object sender, EventArgs e)
        {
            lbli.Text = String.Format("Intelligense: {0}", trbi.Value);
        }
        class Hero
        {
            public double damage;
            public double health;
            public double armor;
            public double mana;
            public double magicDamage;
            public string name;
            public Hero(string name, double damage, double health, double armor, double mana, double magicDamage)
            {
                this.name = name;
                this.damage = damage;
                this.mana = mana;
                this.magicDamage = magicDamage;
                this.armor = armor;
                this.health = health;
            }
            public void Information()
            {
                MessageBox.Show($"{name}, Damage - {damage}, mana - {mana}, magicDamage - {magicDamage}, armor - {armor}, health - {health}");
            }
        }
        class Wizard : Hero
        {
            public Wizard() : base("Wizard", 20, 70, 5, 60, 15)
            {

            }
            public void Print()
            {
                Information();
            }
        }
        class Rogue : Hero
        {
            public Rogue() : base("Rogue", 30, 80, 4, 0, 0)
            {

            }
            public void Print()
            {
                Information();
            }
        }
        class Warrior : Hero
        {
            public Warrior() : base("Warrior", 45, 85, 7, 0, 0)
            {

            }
            public void Print()
            {
                Information();
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            double Strength = Convert.ToDouble(trbS.Value);
            double Dexterity = Convert.ToDouble(trbD.Value);
            double Constitution = Convert.ToDouble(trbC.Value);
            double Intellisence = Convert.ToDouble(trbi.Value);
            
            User user = new User(txtUser.Text, cmbHeroes.Text, Strength, Dexterity, Constitution, Intellisence);
            AddDb.AddToDB(user);
            switch (cmbHeroes.Text)
            { 
                case "Warrior":
            
                Warrior warrior = new Warrior();
                warrior.health = warrior.health+(Strength * 2) + (Constitution * 10);
                warrior.damage = warrior.damage +(Strength * 5) + Dexterity;
                warrior.armor = warrior.armor+Dexterity + (Constitution * 2);
                warrior.mana = warrior.mana+Intellisence;
                warrior.magicDamage = warrior.magicDamage+Intellisence;
                warrior.Print();
                    break;
                case "Rogue":
            
                Rogue rogue = new Rogue();
                rogue.health = rogue.health+Strength + (Constitution * 6);
                rogue.damage = rogue.damage+(Strength * 2) + (Dexterity * 4);
                rogue.armor = rogue.armor+Dexterity * 1.5;
                rogue.mana = rogue.mana+Intellisence * 1.5;
                rogue.magicDamage = rogue.magicDamage+Intellisence * 2;
                rogue.Print();
                    break;

                case "Wizard":
                Wizard wizard = new Wizard();
                wizard.health = wizard.health+Strength + (Constitution * 3);
                wizard.damage = wizard.damage+Strength * 3;
                wizard.armor = wizard.armor+(Dexterity * 0.5) + Constitution;
                wizard.mana = wizard.mana+Intellisence * 2;
                wizard.magicDamage = wizard.magicDamage+Intellisence * 5;
                wizard.Print();
                    break;
            }
            AddDb.ReplaceByName(txtUser.Text, user);
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {

            int exp = Convert.ToInt32(txtExp.Text);
            int lvl = Convert.ToInt32(txtLvl.Text);
            int count = 1000;
            while(count <= exp)
            {
                count += 1000;
                exp -= count;
                lvl++;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            User user = new User(txtUser.Text, cmbHeroes.Text, trbS.Value, trbD.Value, trbC.Value, trbi.Value);
            AddDb.ReplaceByName(txtUser.Text, user);
        }
        public void change()
        {
            cNames.Items.Clear();

            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                cNames.Items.Add(item?.Name);
            }
        }
    }
}