using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Models;
using Models.Validation;

namespace UI
{
    public partial class PersonDetails : Form
    {
        PersonBL bl;
        Person p;
        PersonValidator validator;
        int id;

        bool vFirstname, vLastname, vAddress, vCity, vPost, vEmail, vPhone;

        public event Action OnPersonDetailsOpen;

        public PersonDetails(PersonBL bl, int id)
        {
            this.bl = bl;
            this.id = id;
            validator = new PersonValidator();

            InitializeComponent();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private async void PersonDetails_Load(object sender, EventArgs e)
        {
            p = await bl.GetAsync(id);

            if (p != null)
            {
                tboxFirstName.Text = p.FirstName;
                tboxLastName.Text = p.LastName;
                tboxAddress.Text = p.Address;
                tboxCity.Text = p.City;
                tboxPostCode.Text = p.PostalCode.ToString();
                tboxEmail.Text = p.Email;
                tboxPhone.Text = p.Phone.ToString();

                btnDelete.Enabled = true;
            }
        }
        private async void bntUpdate_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to update this contact?\n\n" +
                $"{tboxFirstName.Text} {tboxLastName.Text}\n" +
                $"{tboxAddress.Text}\n" +
                $"{tboxCity.Text}\n" +
                $"{tboxPostCode.Text}\n" +
                $"{tboxEmail.Text}\n" +
                $"{tboxPhone.Text}\n",
                "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                btnUpdate.Enabled = false;

                try
                {
                    p.FirstName = tboxFirstName.Text;
                    p.LastName = tboxLastName.Text;
                    p.Address = tboxAddress.Text;
                    p.City = tboxCity.Text;
                    p.PostalCode = int.Parse(tboxPostCode.Text);
                    p.Email = tboxEmail.Text;
                    p.Phone = int.Parse(tboxPhone.Text);

                    bool result = await bl.UpdateAsync(p);

                    if (result)
                    {
                        OnPersonDetailsOpen.Invoke();
                        MessageBox.Show(
                            "The contact has been successfully updated.",
                            "Contact Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            "The contact could not be updated due to an unexpected error.\n\n" +
                            "Contact doesn't exist.",
                            "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "An unknown error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (p == null)
            {
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Are you sure you want to delete this contact?\n\n" +
                $"Name: {p.FirstName} {p.LastName}\n" +
                $"Email: {p.Email}\n" +
                $"Phone: {p.Phone}\n\n" +
                "*This action is irreversible and all related data will be permanently erased.",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;

                try
                {
                    bool result = await bl.DeleteAsync(id);

                    if (result)
                    {
                        OnPersonDetailsOpen.Invoke();

                        MessageBox.Show(
                            "The contact has been successfully removed.",
                            "Contact Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        MessageBox.Show(
                            "The contact could not be removed due to an unexpected error.\n\n" +
                            "Contact doesn't exits.",
                            "Removal Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    MessageBox.Show(
                        $"An unknown error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxFirstName_TextChanged(object sender, EventArgs e)
        {
            vFirstname = validator.ValidName(tboxFirstName.Text);
            lblFirstName.ForeColor = vFirstname ? DefaultForeColor : Color.OrangeRed;
            tboxFirstName.ForeColor = vFirstname ? DefaultForeColor : Color.OrangeRed;
            btnUpdate.Enabled = CheckInput();
        }

        private void tboxLastName_TextChanged(object sender, EventArgs e)
        {
            vLastname = validator.ValidName(tboxLastName.Text);
            lblLastName.ForeColor = vLastname ? DefaultForeColor : Color.OrangeRed;
            tboxLastName.ForeColor = vLastname ? DefaultForeColor : Color.OrangeRed;
            btnUpdate.Enabled = CheckInput();
        }

        private void tboxAddress_TextChanged(object sender, EventArgs e)
        {
            vAddress = validator.ValidAddress(tboxAddress.Text);
            lblAddress.ForeColor = vAddress ? DefaultForeColor : Color.OrangeRed;
            tboxAddress.ForeColor = vAddress ? DefaultForeColor : Color.OrangeRed;
            btnUpdate.Enabled = CheckInput();
        }

        private void tboxCity_TextChanged(object sender, EventArgs e)
        {
            vCity = validator.ValidName(tboxCity.Text);
            lblCity.ForeColor = vCity ? DefaultForeColor : Color.OrangeRed;
            tboxCity.ForeColor = vCity ? DefaultForeColor : Color.OrangeRed;
            btnUpdate.Enabled = CheckInput();
        }

        private void tboxPostCode_TextChanged(object sender, EventArgs e)
        {
            vPost = validator.ValidPostCode(tboxPostCode.Text);
            lblPostalCode.ForeColor = vPost ? DefaultForeColor : Color.OrangeRed;
            tboxPostCode.ForeColor = vPost ? DefaultForeColor : Color.OrangeRed;
            btnUpdate.Enabled = CheckInput();
        }

        private void tboxEmail_TextChanged(object sender, EventArgs e)
        {
            vEmail = validator.ValidEmail(tboxEmail.Text);
            lblEmail.ForeColor = vEmail ? DefaultForeColor : Color.OrangeRed;
            tboxEmail.ForeColor = vEmail ? DefaultForeColor : Color.OrangeRed;
            btnUpdate.Enabled = CheckInput();
        }

        private void tboxPhone_TextChanged(object sender, EventArgs e)
        {
            vPhone = validator.ValidPhone(tboxPhone.Text);
            lblPhone.ForeColor = vPhone ? DefaultForeColor : Color.OrangeRed;
            tboxPhone.ForeColor = vPhone ? DefaultForeColor : Color.OrangeRed;
            btnUpdate.Enabled = CheckInput();
        }
        private bool CheckInput()
        {
            return vFirstname && vLastname && vAddress && vCity && vPost && vEmail && vPhone;
        }
    }
}
