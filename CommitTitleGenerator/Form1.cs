using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommitTitleGenerator
{
    public partial class Form1 : Form
    {
        public CheckBox Category;

        Task task = new Task();

        public Form1()
        {
            InitializeComponent();
            Other_TB.Visible = false;
        }
        // Method not working as intended for now :(
       /* private void checkBoxBehavior(CheckBox checkBox)
        {
            List<CheckBox> allCheckboxes = new List<CheckBox>();
            allCheckboxes.Add(NPC_CB);
            allCheckboxes.Add(Quest_CB);
            allCheckboxes.Add(Instance_CB);
            allCheckboxes.Add(Other_CB);
            allCheckboxes.Add(GO_CB);

            foreach (CheckBox e in allCheckboxes)
            {
                if(e != checkBox)
                {
                    e.Checked = false;
                    Other_TB.Visible = false;
                }

                else
                {
                    MessageBox.Show(e.Name);
                }

            }
        }
        */
        private void Other_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                Other_TB.Visible = true;
                Category = Other_CB;
            }
           // checkBoxBehavior(Other_CB);
        }

        private void Instance_CB_CheckedChanged(object sender, EventArgs e)
        {
            // checkBoxBehavior(Instance_CB);
            if (!((CheckBox)sender).Checked)
                Category = Instance_CB;
        }

        private void GO_CB_CheckedChanged(object sender, EventArgs e)
        {
            // checkBoxBehavior(GO_CB);
            if (!((CheckBox)sender).Checked)
                Category = GO_CB;
        }

        private void NPC_CB_CheckedChanged(object sender, EventArgs e)
        {
            // checkBoxBehavior(NPC_CB);
            if (!((CheckBox)sender).Checked)
                Category = NPC_CB;
        }

        private void Quest_CB_CheckedChanged(object sender, EventArgs e)
        {
          //  checkBoxBehavior(Quest_CB);
          if(!((CheckBox)sender).Checked)
            Category = Quest_CB;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Submit_BT_Click(object sender, EventArgs e)
        {
            generateTask();
            Result_TB.Text = task.returnCommitDescription();
        }

        private void Save_BT_Click(object sender, EventArgs e)
        {
            if (task == null)
                return;
            generateTask();
            task.saveToFile();
        }

        private void generateTask()
        {
            task = new Task(Category.Text, Specifier_TB.Text, Author_TB.Text, Desc_TB.Text, Number_TB.Text);
        }
    }
}
