using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_view_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("First Name", 200);
            listView1.Columns.Add("Last Name", 200);
            listView1.Columns.Add("Points", 100);
        }

        private void ClearTextBoxs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(textBox1.Text);
            newItem.SubItems.Add(textBox4.Text);
            newItem.SubItems.Add(textBox3.Text);
            newItem.SubItems.Add(textBox2.Text);
            listView1.Items.Add(newItem);
            ClearTextBoxs();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                if(listView1.SelectedItems.Count > 0)
                {
                    textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                    textBox4.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                    textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }
            
           
        }

        private void btn_Add_Five_Items_Click(object sender, EventArgs e)
        {
            for(int item = 0; item < 5; item++)
            {
                ListViewItem newItem = new ListViewItem(item.ToString());
                newItem.SubItems.Add("Person " + item + 1);
                newItem.SubItems.Add("father " + item + 1);
                newItem.SubItems.Add((item + 2.9).ToString());
                listView1.Items.Add(newItem);
            }
          
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                  listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                  listView1.SelectedItems[0].SubItems[1].Text = textBox4.Text;
                  listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                  listView1.SelectedItems[0].SubItems[3].Text = textBox2.Text;
            }
            ClearTextBoxs();

        }

        private void btn_Remove_Item_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            ClearTextBoxs();

        }

        private void btn_Clear_List_Click(object sender, EventArgs e)
        {
          
                listView1.Items.Clear();
            
        }
    }
}
