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
        private async void Overview_Load(object sender, EventArgs e)
        {
            RefreshDgvAsync();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PersonCreate pc = new PersonCreate(bl);
            pc.OnPersonCreateOpen += RefreshDgvAsync;
            pc.ShowDialog();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rIndex = e.RowIndex;

            if (rIndex >= 0)
            {
                ShowPersonDetails(rIndex);
            }
        }

        private void ShowPersonDetails(int rIndex)
        {
            int id = (int)dgv.Rows[rIndex].Cells[0].Value;

            PersonDetails pd = new PersonDetails(bl, id);
            pd.OnPersonDetailsOpen += RefreshDgvAsync;
            pd.ShowDialog();
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            int selected = dgv.SelectedRows.Count;
            if (selected == 0)
            {
                lblSelected.Visible = false;
                tboxSelected.Visible = false;
            }
            else
            {
                lblSelected.Visible = true;
                tboxSelected.Visible = true;
                tboxSelected.Text = selected.ToString();
            }
        }

        private async void RefreshDgvAsync()
        {
            dgv.DataSource = null;
            try
            {
                dgv.DataSource = await bl.GetAsync();
                tboxTotal.Text = dgv.RowCount.ToString();
                dgv.Columns[0].Visible = false;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    $"An unknown error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
