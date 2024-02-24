using BusinessLogic;
using Models;

namespace BilalAsyncAwait
{
    public partial class Overview : Form
    {
        PersonBL bl;
        public Overview()
        {
            InitializeComponent();

            bl = new PersonBL();
        }



    }
}
