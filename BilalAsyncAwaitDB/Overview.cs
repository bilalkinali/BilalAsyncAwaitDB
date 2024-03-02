using BusinessLogic;
using Models;
using UI;

namespace BilalAsyncAwaitDB
{
    public partial class Overview : Form
    {
        PersonBL bl;
        public Overview()
        {
            // Initialize bl before loading components to reduce risk of NullReferenceException
            bl = new PersonBL();

            InitializeComponent();

            lblLoading.Enabled = false;
            lblLoading.Visible = false;
            btnUpdate.Enabled = false;

            btnCreate.Click += btnCreate_Click;
            btnExit.Click += btnExit_Click;
            btnUpdate.Click += btnUpdate_Click;
            this.Load += Overview_Load;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            dgv.SelectionChanged += dgv_SelectionChanged;
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            ShowPersonDetails(dgv.SelectedRows[0].Index);
        }

        private void Overview_Load(object sender, EventArgs e)
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

        private void ShowPersonDetails(int index)
        {
            int id = (int)dgv.Rows[index].Cells[0].Value;
            PersonDetails pd = new PersonDetails(bl, id);
            pd.OnPersonDetailsOpen += RefreshDgvAsync;
            pd.ShowDialog();
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            int selected = dgv.SelectedRows.Count;
            tboxSelected.Text = selected.ToString();
            // Enable/disable according to the selected count, if anything else than 1, disable.
            btnUpdate.Enabled = selected == 1;
        }

        private async void RefreshDgvAsync()
        {
            lblLoading.Visible = true;
            dgv.DataSource = null;

            try
            {
                dgv.DataSource = await bl.GetAsync();
                lblLoading.Visible = false;

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.Columns[0].Visible = false;
                dgv.Columns["FirstName"].HeaderText = "Firstname";
                dgv.Columns["LastName"].HeaderText = "Lastname";
                dgv.Columns["PostalCode"].HeaderText = "Postal";


                dgv.Columns["FirstName"].MinimumWidth = 50;
                dgv.Columns["LastName"].MinimumWidth = 50;
                dgv.Columns["Address"].MinimumWidth = 180;
                dgv.Columns["City"].MinimumWidth = 70;
                dgv.Columns["PostalCode"].MinimumWidth = 50;
                dgv.Columns["Email"].MinimumWidth = 150;
                dgv.Columns["Phone"].MinimumWidth = 60;

                dgv.Columns["Address"].FillWeight = 150;
                dgv.Columns["Email"].FillWeight = 150;
                dgv.Columns["PostalCode"].FillWeight = 50;
                dgv.Columns["Phone"].FillWeight = 80;

                tboxTotal.Text = dgv.RowCount.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show(
                    $"An unknown error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
