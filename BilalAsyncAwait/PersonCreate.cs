using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace UI
{
    public partial class PersonCreate : Form
    {
        PersonBL bl;
        public PersonCreate(PersonBL blInstance)
        {
            bl = blInstance;

            InitializeComponent();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                FirstName = tboxFirstName.Text,
                LastName = tboxLastName.Text,
                Address = tboxAddress.Text,
                City = tboxCity.Text,
                PostalCode = int.Parse(tboxPostCode.Text),
                Email = tboxEmail.Text,
                Phone = int.Parse(tboxPhone.Text)
            };

            await bl.CreateAsync(p);
        }
    }
}
