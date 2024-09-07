using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.FrmRegistration;
using static Account_Registration.FrmRegistration.StudentInfoClass;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;  
        
        // initialize delegates inside the constructor
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram); // static methods from frmRegistration
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText (StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber (StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        // DISPLAY ALL INPUTS
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            //label
            program.Text = DelProgram(StudentInfoClass.Program);            
            studentNum.Text = DelStudNo(StudentInfoClass.StudentNo).ToString(); // convert long to string
            lastName.Text = DelLastName(StudentInfoClass.LastName);
            firstName.Text = DelFirstName(StudentInfoClass.FirstName);
            middleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            age.Text = DelNumAge(StudentInfoClass.Age).ToString();
            contactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            address.Text = DelAddress(StudentInfoClass.Address);
        }

        private void studentNum_Click(object sender, EventArgs e)
        {
            
            
        }
        // submitt button
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // FORM CLOSING EVENT
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        private void middleName_Click(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void contactNo_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }
    }
}
