using System.Drawing;
using System.Windows.Forms;

namespace smarthomesui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, System.EventArgs e)
        {
            // Create a new Font object with the desired font family and size
            Font font = new Font("Arial", 13);

            // Assign the font to the TextBox control
            username.Font = font;
            password.Font = font;  
            
            username.Multiline = true;
            password.Multiline = true;
        }
    }
}
