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
using Models.Validation;

namespace UI
{
    public partial class PersonCreate : Form
    {
        PersonBL bl;
        PersonValidator validator;

        bool vFirstname, vLastname, vAddress, vCity, vPost, vEmail, vPhone;

        public event Action OnPersonCreateOpen;

        public PersonCreate(PersonBL blInstance)
        {
            bl = blInstance;
            validator = new PersonValidator();

            InitializeComponent();

            btnCreate.Enabled = false;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Person p = new Person()
                {
                    FirstName = tboxFirstName.Text.Trim(),
                    LastName = tboxLastName.Text.Trim(),
                    Address = tboxAddress.Text.Trim(),
                    City = tboxCity.Text.Trim(),
                    PostalCode = int.Parse(tboxPostCode.Text),
                    Email = tboxEmail.Text,
                    Phone = int.Parse(tboxPhone.Text)
                };

                bool result = await bl.CreateAsync(p);

                if (result)
                {
                    OnPersonCreateOpen.Invoke();
                    MessageBox.Show(
                        "The contact has been successfully created.",
                        "Contact Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "The contact could not be created due to an unexpected error.\n\n" +
                        "Please try again later or contact support.",
                        "Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    $"An unknown error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tboxFirstName_TextChanged(object sender, EventArgs e)
        {
            vFirstname = validator.ValidName(tboxFirstName.Text);
            lblFirstName.ForeColor = vFirstname ? DefaultForeColor : Color.OrangeRed;
            tboxFirstName.ForeColor = vFirstname ? DefaultForeColor : Color.OrangeRed;
            btnCreate.Enabled = CheckInput();
        }

        private void tboxLastName_TextChanged(object sender, EventArgs e)
        {
            vLastname = validator.ValidName(tboxLastName.Text);
            lblLastName.ForeColor = vLastname ? DefaultForeColor : Color.OrangeRed;
            tboxLastName.ForeColor = vLastname ? DefaultForeColor : Color.OrangeRed;
            btnCreate.Enabled = CheckInput();
        }

        private void tboxAddress_TextChanged(object sender, EventArgs e)
        {
            vAddress = validator.ValidAddress(tboxAddress.Text);
            lblAddress.ForeColor = vAddress ? DefaultForeColor : Color.OrangeRed;
            tboxAddress.ForeColor = vAddress ? DefaultForeColor : Color.OrangeRed;
            btnCreate.Enabled = CheckInput();
        }

        private void tboxCity_TextChanged(object sender, EventArgs e)
        {
            vCity = validator.ValidName(tboxCity.Text);
            lblCity.ForeColor = vCity ? DefaultForeColor : Color.OrangeRed;
            tboxCity.ForeColor = vCity ? DefaultForeColor : Color.OrangeRed;
            btnCreate.Enabled = CheckInput();
        }

        private void tboxPostCode_TextChanged(object sender, EventArgs e)
        {
            vPost = validator.ValidPostCode(tboxPostCode.Text);
            lblPostalCode.ForeColor = vPost ? DefaultForeColor : Color.OrangeRed;
            tboxPostCode.ForeColor = vPost ? DefaultForeColor : Color.OrangeRed;
            btnCreate.Enabled = CheckInput();
        }

        private void tboxEmail_TextChanged(object sender, EventArgs e)
        {
            vEmail = validator.ValidEmail(tboxEmail.Text);
            lblEmail.ForeColor = vEmail ? DefaultForeColor : Color.OrangeRed;
            tboxEmail.ForeColor = vEmail ? DefaultForeColor : Color.OrangeRed;
            btnCreate.Enabled = CheckInput();
        }

        private void tboxPhone_TextChanged(object sender, EventArgs e)
        {
            vPhone = validator.ValidPhone(tboxPhone.Text);
            lblPhone.ForeColor = vPhone ? DefaultForeColor : Color.OrangeRed;
            tboxPhone.ForeColor = vPhone ? DefaultForeColor : Color.OrangeRed;
            btnCreate.Enabled = CheckInput();
        }

        private bool CheckInput()
        {
            return vFirstname && vLastname && vAddress && vCity && vPost && vEmail && vPhone;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
