using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Models;

namespace UI
{
    public partial class PersonDetails : Form
    {
        PersonBL bl;
        Person p;
        int id;

        public event Action OnPersonDetailsOpen;

        public PersonDetails(PersonBL bl, int id)
        {
            this.bl = bl;
            this.id = id;
            InitializeComponent();
        }
        private async void PersonDetails_LoadAsync(object sender, EventArgs e)
        {
            p = await bl.GetAsync(id);

            tboxFirstName.Text = p.FirstName;
            tboxLastName.Text = p.LastName;
            tboxAddress.Text = p.Address;
            tboxCity.Text = p.City;
            tboxPostCode.Text = p.PostalCode.ToString();
            tboxEmail.Text = p.Email;
            tboxPhone.Text = p.Phone.ToString();
        }

        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            bool result = await bl.DeleteAsync(id);

            if (result)
            {
                MessageBox.Show("Success!");
                OnPersonDetailsOpen.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
