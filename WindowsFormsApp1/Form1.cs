using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLeaderboard : Form
    {
        public Scores_store store = new Scores_store();
      
        public FrmLeaderboard()
        {
            InitializeComponent();
        }

        
        private void ResetTextBoxes() //a procedure to reset the text boxes with placeholders
        {
            TxtName.ForeColor = Color.Gray;
            TxtName.Text = "Name";
            TxtScore.ForeColor = Color.Gray;
            TxtScore.Text = "Score";
            btnAdd.Enabled = false;
        }

        private void TxtName_Click(object sender, System.EventArgs e)
        {
            TxtName.ForeColor = Color.Black;
            TxtName.Text = "";
        }

     
        private void TxtScore_Click(object sender, System.EventArgs e)
        {
            TxtScore.ForeColor = Color.Black;
            TxtScore.Text = "";
            btnAdd.Enabled = true;
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = TxtName.Text;
            int score = Convert.ToInt32(TxtScore.Text);
            store.peoples[store.numberpeople].Name = name;
            store.peoples[store.numberpeople].Score = score;
            store.numberpeople += 1;          
            ResetTextBoxes();
            //sort the array
            bool flag = true;
            Scores_store.People temp;
            int numLength = store.peoples.Length;

            //sorting an array  
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (store.peoples[j + 1].Score > store.peoples[j].Score)
                    {
                        temp = store.peoples[j];
                        store.peoples[j] = store.peoples[j + 1];
                        store.peoples[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            //addd titles to list box
            listBox1.Items.Add("Name          Score");
            //Sorted array addition to list box
            foreach (Scores_store.People person in store.peoples)
            {
                if (person.Score != 0 ){     //remove any empty records           
                listBox1.Items.Add(person.Name + " " + person.Score);
                }
            }

        }

        private void FrmLeaderboard_Load(object sender, EventArgs e)
        {
            ResetTextBoxes();
        }

        private void FrmLeaderboard_Click(object sender, System.EventArgs e) 
        {
            ResetTextBoxes();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
            int selected = listBox1.SelectedIndex - 1;
            store.peoples[selected].Name = "";
            store.peoples[selected].Score = 0;

            //sort the array
            bool flag = true;
            Scores_store.People temp;
            int numLength = store.peoples.Length;

            //sorting an array  
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (store.peoples[j + 1].Score > store.peoples[j].Score)
                    {
                        temp = store.peoples[j];
                        store.peoples[j] = store.peoples[j + 1];
                        store.peoples[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            //clear list box
            listBox1.Items.Clear();
            //addd titles to list box
            listBox1.Items.Add("Name          Score");
            //Sorted array addition to list box
            foreach (Scores_store.People person in store.peoples)
            {
                if (person.Score != 0)
                {     //remove any empty records           
                    listBox1.Items.Add(person.Name + " " + person.Score);
                }
            }

        }
    }
}
