using BusinessLogic;
using Models;

namespace BilalAsyncAwait
{
    public partial class Overview : Form
    {
        PersonBL bl;
        public Overview()
        {
            // Initialize bl before loading components to reduce risk of NullReferenceException
            bl = new PersonBL();

            InitializeComponent();
        }
        private async void Overview_Load(object sender, EventArgs e)
        {
            dgv.DataSource = await bl.GetAsync();
        }
    }
}
