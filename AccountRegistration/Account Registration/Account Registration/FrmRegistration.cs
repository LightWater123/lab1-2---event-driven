using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        
        public FrmRegistration()
        {
            InitializeComponent();
            
        }

        public class StudentInfoClass
        {
            // initializing delegates
            public delegate long DelegateNumber(long number);
            public delegate string DelegateText(string txt);

            // initializing static variables

            public static string FirstName = "";
            public static string LastName = "";
            public static string MiddleName = "";
            public static string Address = "";
            public static string Program = "";

            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;

            // static return type methods

            public static string GetFirstName(string FirstName)
            {
                return FirstName;
            }

            public static string GetLastName(string LastName) 
            {
                return LastName;
            }

            public static string GetMiddleName(string MiddleName)
            {
                return MiddleName;
            }

            public static string GetAddress(string Address)
            {
                return Address;
            }

            public static string GetProgram(string Program) 
            {
                return Program;
            }

            public static long GetAge(long Age)
            {
                return Age;
            }

            public static long GetContactNo(long ContactNo)
            {
                return ContactNo;
            }

            public static long GetStudentNo(long StudentNo)
            {
                return StudentNo;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            
        }

        // NEXT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //FrmConfirm frmConfirm = new FrmConfirm();
                this.Hide();
                //frmConfirm.ShowDialog();

                // getting the value of each textBox and comboBox
                StudentInfoClass.Program = cbProgram.Text.ToString();
                StudentInfoClass.LastName = Lname.Text.ToString();
                StudentInfoClass.FirstName = Fname.Text.ToString();
                StudentInfoClass.MiddleName = Mname.Text.ToString();
                StudentInfoClass.Age = Convert.ToInt64(ageTxt.Text);
                StudentInfoClass.ContactNo = Convert.ToInt64(contactNo.Text);
                StudentInfoClass.StudentNo = Convert.ToInt64(studentNo.Text);
                StudentInfoClass.Address = addresstxt.Text.ToString();


                // validate if FrmConfirm ShowDialog() is == to DialogResult.OK
                FrmConfirm FConfirm = new FrmConfirm();
                FConfirm.ShowDialog();
                DialogResult res = FConfirm.ShowDialog(); // stores FConfirm in dialog res

                if (res == DialogResult.OK)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        // Reset tetxBox if clicked next
                        if (ctrl is TextBox)
                        {
                            ((TextBox)ctrl).Text = string.Empty;
                        }
                        // Reset comboBox if clicked next
                        else if (ctrl is ComboBox)
                        {
                            ((ComboBox)ctrl).SelectedIndex = -1; // Unselect selected programs
                        }
                    }
                }
                else
                {
                    MessageBox.Show("An error has occurred.", "NOTICE");                   
                    FrmRegistration frmRegistration = new FrmRegistration();
                    frmRegistration.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please fill in the fields \n" , "NOTICE");
                FrmRegistration frmRegistration = new FrmRegistration();
                frmRegistration.ShowDialog();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
