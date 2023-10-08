using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox3_22_10
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string> { "Vuqar", "Ruad", "Ulvi" };
        List<string> todos = new List<string> { "Write Code","Play Tennis",
        "Read Book"};
        List<Car> cars = new List<Car>
        {
            new Car
            {
                 Model="E-200",
                 Vendor="Mercedes",
                 Year=2018
            },
            new Car
            {
                Model="La Ferrari",
                Vendor="Ferrari",
                Year=2020
            },
            new Car
            {
                Model="Santafe",
                Vendor="Hyundai",
                Year=2019
            }
        };
        List<int> points = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public Form1()
        {
            InitializeComponent();
            //listBox1.Items.AddRange(names.ToArray());

            //listBox1.DataSource = names;
            //listBox1.SelectedIndex = 0;

            //listBox1.DataSource = cars;
            //listBox1.DisplayMember = nameof(Car.Vendor);
            comboBox1.DataSource = points;
            checkedListBox1.Items.AddRange(todos.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var item = listBox1.SelectedItem as string;
            //label1.Text = item;

            //var item=listBox1.SelectedItem as Car;
            //if(item!=null)
            //label1.Text = item.ToString();

            //label1.Text = "";
            //var items=listBox1.SelectedItems;
            //foreach (var item in items)
            //{
            //    var car = item as Car;
            //    label1.Text += $"{car}\n";
            //}




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(textBox1.Text);
            //textBox1.Text = String.Empty;


            //names.Add(textBox1.Text);
            //listBox1.DataSource = null;
            //listBox1.DataSource = names;


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //var car = listBox1.SelectedItem as Car;
            //cars.Remove(car);
            //listBox1.DataSource=null;
            //listBox1.DataSource=cars;
            //listBox1.DisplayMember = nameof(Car.Vendor);


            var item = listBox1.SelectedItem as Car;
            listBox2.Items.Add(item);
            cars.Remove(item);
            listBox1.DataSource = null;
            listBox1.DataSource = cars;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = checkedListBox1.SelectedItem as string;
            label1.Text = item;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                var checkedItems = checkedListBox1.CheckedItems;
                foreach (var checkedItem in checkedItems)
                {
                    todos.Remove(checkedItem as string);
                }
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.AddRange(todos.ToArray());
            }
            catch (Exception)
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   MessageBox.Show($"You get {comboBox1.SelectedItem}");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = guna2RatingStar1.Value.ToString();
        }
    }
}
