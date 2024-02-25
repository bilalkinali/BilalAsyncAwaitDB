using BusinessLogic;
using Models;
using UI;

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
        private async void Overview_LoadAsync(object sender, EventArgs e)
        {
            dgv.DataSource = await bl.GetAsync();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PersonCreate pc = new PersonCreate(bl);
            pc.ShowDialog();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rIndex = e.RowIndex;

            if (rIndex >= 0)
            {
                ShowPersonDetailsAsync(rIndex); 
            }
        }

        private async void ShowPersonDetailsAsync(int rIndex)
        {
            int id = (int)dgv.Rows[rIndex].Cells[0].Value;

            PersonDetails pd = new PersonDetails(bl, id);
            pd.OnPersonDetailsOpen += RefreshDgvAsync;
            pd.ShowDialog();
        }

        private async void RefreshDgvAsync()
        {
            dgv.DataSource = null;
            dgv.DataSource = await bl.GetAsync();
        }
    }
}
