using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientWindowsFormsAppStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txtBoxInsertName.Visible = false;
            comBoxInsertGender.Visible = false;
            txtBoxUpdateId.Visible = false;
            txtBoxUpdateName.Visible = false;
            comBoxUpdateGender.Visible = false;
            dgRetrieve.Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                ADOStudy.Info dataInsert = new ADOStudy.Info();
                dataInsert.Name = txtBoxInsertName.Text;
                dataInsert.Gender = comBoxInsertGender.Text;
                ADOStudy.ADO opInsert = new ADOStudy.ADO();
                bool res = opInsert.Insert(dataInsert);
                if (res == true)
                {
                    lblResult.Text = "Insert done successfully";
                }
                else
                {
                    lblResult.Text = "Insert Aborted"; 
                }
            }
            if (checkBox2.Checked == true)
            {
                DataSet dsRetrieve = new DataSet();
                ADOStudy.ADO opretrive = new ADOStudy.ADO();
                dsRetrieve = opretrive.Retrieve();
                dgRetrieve.AutoGenerateColumns = true;
                dgRetrieve.DataSource = dsRetrieve;
                
                dgRetrieve.Visible = true;
            }
            if (checkBox3.Checked == true)
            {
                ADOStudy.UpdateInfo dataUpdate = new ADOStudy.UpdateInfo();
                dataUpdate.Name = txtBoxUpdateName.Text;
                dataUpdate.ID = Convert.ToInt32(txtBoxUpdateId.Text);
                dataUpdate.Gender = comBoxUpdateGender.Text;
                ADOStudy.ADO opUpdate = new ADOStudy.ADO();
                bool res = opUpdate.Update(dataUpdate);
                if (res == true)
                {
                    lblResult.Text = "Update done successfully";
                }
                else
                {
                    lblResult.Text = "Update Aborted";
                }
            }
            if (checkBox4.Checked == true)
            {
                ADOStudy.ADO opDelete = new ADOStudy.ADO();
                bool res = opDelete.Delete();
                if (res == true)
                {
                    lblResult.Text = "Deleted successfully";
                }
                else
                {
                    lblResult.Text = "Delete Aborted";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            txtBoxInsertName.Visible = true;
            comBoxInsertGender.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtBoxUpdateId.Visible = true;
            txtBoxUpdateName.Visible = true;
            comBoxUpdateGender.Visible = true;
        }


    }
}
