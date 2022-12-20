using System.ComponentModel;
using System.Windows.Forms;

namespace LA_1300_C
{
    public partial class Menu : Form
    {
        static string valueOptionsUsername = "Guest";
        static string valueOptionsWindowSize = "Windowed (Default)";
        public Menu()
        {
            InitializeComponent();
            properties();
            transparency();
            hoverEffect();
            click();
        }
        public void properties()
        {
            this.Text = "Dinosaurier Spiel - v.0.0.3 - Hauptmenü";
            this.Icon = Properties.Resources.game_icon;
        }
        public void transparency()
        {
            menuGameTitle.Parent = menuAnimatedBackground;
            menuGameTitle.BackColor = Color.Transparent;
            menuPlayButton.Parent = menuAnimatedBackground;
            menuPlayButton.BackColor = Color.Transparent;
            menuOptionsButton.Parent = menuAnimatedBackground;
            menuOptionsButton.BackColor = Color.Transparent;
            menuControlsButton.Parent = menuAnimatedBackground;
            menuControlsButton.BackColor = Color.Transparent;
            menuCreditsButton.Parent = menuAnimatedBackground;
            menuCreditsButton.BackColor = Color.Transparent;
            menuExitButton.Parent = menuAnimatedBackground;
            menuExitButton.BackColor = Color.Transparent;
        }
        public void hoverEffect()
        {
            menuPlayButton.MouseEnter += new EventHandler(menuPlayButton_MouseEnter);
            menuPlayButton.MouseLeave += new EventHandler(menuPlayButton_MouseLeave);
            menuOptionsButton.MouseEnter += new EventHandler(menuOptionsButton_MouseEnter);
            menuOptionsButton.MouseLeave += new EventHandler(menuOptionsButton_MouseLeave);
            menuControlsButton.MouseEnter += new EventHandler(menuControlsButton_MouseEnter);
            menuControlsButton.MouseLeave += new EventHandler(menuControlsButton_MouseLeave);
            menuCreditsButton.MouseEnter += new EventHandler(menuCreditsButton_MouseEnter);
            menuCreditsButton.MouseLeave += new EventHandler(menuCreditsButton_MouseLeave);
            menuExitButton.MouseEnter += new EventHandler(menuExitButton_MouseEnter);
            menuExitButton.MouseLeave += new EventHandler(menuExitButton_MouseLeave);
        }
        private void menuPlayButton_MouseEnter(object sender, System.EventArgs e) { menuPlayButton.Image = Properties.Resources.menu_play_entered; }
        private void menuPlayButton_MouseLeave(object sender, System.EventArgs e) { menuPlayButton.Image = Properties.Resources.menu_play_left; }
        private void menuOptionsButton_MouseEnter(object sender, System.EventArgs e) { menuOptionsButton.Image = Properties.Resources.menu_options_entered; }
        private void menuOptionsButton_MouseLeave(object sender, System.EventArgs e) { menuOptionsButton.Image = Properties.Resources.menu_options_left; }
        private void menuControlsButton_MouseEnter(object sender, System.EventArgs e) { menuControlsButton.Image = Properties.Resources.menu_controls_entered; }
        private void menuControlsButton_MouseLeave(object sender, System.EventArgs e) { menuControlsButton.Image = Properties.Resources.menu_controls_left; }
        private void menuCreditsButton_MouseEnter(object sender, System.EventArgs e) { menuCreditsButton.Image = Properties.Resources.menu_credits_entered; }
        private void menuCreditsButton_MouseLeave(object sender, System.EventArgs e) { menuCreditsButton.Image = Properties.Resources.menu_credits_left; }
        private void menuExitButton_MouseEnter(object sender, System.EventArgs e) { menuExitButton.Image = Properties.Resources.menu_exit_entered; }
        private void menuExitButton_MouseLeave(object sender, System.EventArgs e) { menuExitButton.Image = Properties.Resources.menu_exit_left; }
        public void click()
        {
            menuPlayButton.Click += new EventHandler(menuPlayButton_Click);
            menuOptionsButton.Click += new EventHandler(menuOptionsButton_Click);
            menuControlsButton.Click += new EventHandler(menuControlsButton_Click);
            menuCreditsButton.Click += new EventHandler(menuCreditsButton_Click);
            menuExitButton.Click += new EventHandler(menuExitButton_Click);
        }
        private void menuPlayButton_Click(object sender, EventArgs e) { new levelOverview().Show(); this.Hide(); }
        private void menuOptionsButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToString(InputBox()) == "OK")
            {
                labelresult.Text = valueOptionsUsername;
                if(valueOptionsWindowSize == "Windowed (Default)")
                {
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                }
            }
        }
        public static DialogResult InputBox()
        {
            Form form = new Form();
            form.Text = "Optionen";

            Label label = new Label();
            label.Text = "Window Settings:";
            label.SetBounds(100, 25, 372, 13);
            label.AutoSize = true;

            ComboBox windowSize = new ComboBox();
            windowSize.AllowDrop = false;
            windowSize.Items.Add("Windowed (Default)");
            windowSize.Items.Add("Windowed (Borderless)");
            if(valueOptionsWindowSize == "Windowed (Default)") { windowSize.SelectedItem = "Windowed (Default)"; }
            else { windowSize.SelectedItem = "Windowed (Borderless)"; }
            windowSize.SetBounds(100, 45, 200, 13);

            Label label2 = new Label();
            label2.Text = "Change Leaderboard name:";
            label2.SetBounds(100, 85, 372, 13);
            label2.AutoSize = true;

            TextBox textBox = new TextBox();
            textBox.SetBounds(100, 105, 200, 13);
            textBox.Text = valueOptionsUsername;

            Button buttonApply = new Button();
            buttonApply.Text = "Apply";
            buttonApply.DialogResult = DialogResult.OK;
            buttonApply.SetBounds(115, 160, 80, 30);

            Button buttonCancel = new Button();
            buttonCancel.Text = "Cancel";
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.SetBounds(205, 160, 80, 30);
            
            form.ClientSize = new Size(400, 200);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange(new Control[] { label, textBox, buttonApply, buttonCancel, windowSize, label2 });
            form.AcceptButton = buttonApply;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (windowSize.Text == "Windowed (Default)" || windowSize.Text == "Windowed (Borderless)")
                {
                    valueOptionsUsername = textBox.Text;
                    valueOptionsWindowSize = windowSize.Text;
                    return dialogResult;
                }
                else
                {
                    MessageBox.Show("Wrong values entered. No changes have been made.", "Error", MessageBoxButtons.OK);
                    return DialogResult.No;
                }
            }
            else
            {
                return DialogResult.No;
            }
        }
        private void menuControlsButton_Click(object sender, EventArgs e) { new Controls().Show(); this.Hide(); }
        private void menuCreditsButton_Click(object sender, EventArgs e) { new Credits().Show(); this.Hide(); }
        private void menuExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programm wirklich schliessen?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }
    }
}