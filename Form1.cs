using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertor
{
   
    public partial class Form1 : Form
    {
    
        string[] CurrencyList = {"US Dollar","British Pound","Euro","Canadian Dollar",
                                 "Swiss Franc", "Australian Dollar", "Japanese Yen", "Indian Rupee" };
        List<Rates> dollarRates = new List<Rates>();
        List<Rates> poundRates = new List<Rates>();
        List<Rates> euroRates = new List<Rates>();
        List<Rates> canadianRates = new List<Rates>();
        List<Rates> swissRates = new List<Rates>();
        List<Rates> australianRates = new List<Rates>();
        List<Rates> yenRates = new List<Rates>();
        List<Rates> indianRates = new List<Rates>();

        
        string choice1, choice2;
        double inputValue = 0;
        double output;
        int listOne, listTwo;
        
        

        public Form1()
        {
            InitializeComponent();

            
            

            foreach (string currency in CurrencyList)
            {
                comboBox1.Items.Add(currency);
                comboBox2.Items.Add(currency);
            }


            //adding elements to dollarRates list

            dollarRates.Add(new Rates("British Pound", 0.5842));
            dollarRates.Add(new Rates("Euro", 0.734));
            dollarRates.Add(new Rates("Canadian Dollar", 1.0735));
            dollarRates.Add(new Rates("Swiss Franc", 0.8909));
            dollarRates.Add(new Rates("Australian Dollar", 1.0649));
            dollarRates.Add(new Rates("Japanese Yen", 101.57));
            dollarRates.Add(new Rates("Indian Rupee", 60.063));

            //adding items to pounRates list

            poundRates.Add(new Rates("US Dollar", 1.7077));
            poundRates.Add(new Rates("Euro", 1.2545));
            poundRates.Add(new Rates("Canadian Dollar", 1.8292));
            poundRates.Add(new Rates("Swiss Franc", 1.5238));
            poundRates.Add(new Rates("Australian Dollar", 1.8186));
            poundRates.Add(new Rates("Japanese Yen", 173.46));
            poundRates.Add(new Rates("Indian Rupee", 102.57));

            //adding elements to euroRates list

            euroRates.Add(new Rates("US Dollar", 1.3612));
            euroRates.Add(new Rates("British Pound", 0.7971));
            euroRates.Add(new Rates("Canadian Dollar", 1.4581));
            euroRates.Add(new Rates("Swiss Franc", 1.2147));
            euroRates.Add(new Rates("Australian Dollar", 1.4496));
            euroRates.Add(new Rates("Japanese Yen", 138.27));
            euroRates.Add(new Rates("Indian Rupee", 81.760));

            //adding elements to canadianRates list

            canadianRates.Add(new Rates("US Dollar", 0.9336));
            canadianRates.Add(new Rates("British Pound", 0.5467));
            canadianRates.Add(new Rates("Euro", 0.6858));
            canadianRates.Add(new Rates("Swiss Franc", 0.833));
            canadianRates.Add(new Rates("Australian Dollar", 0.9942));
            canadianRates.Add(new Rates("Japanese Yen", 94.829));
            canadianRates.Add(new Rates("Indian Rupee", 56.073));

            //adding elements to swissRates list

            swissRates.Add(new Rates("US Dollar", 1.1207));
            swissRates.Add(new Rates("British Pound", 0.6562));
            swissRates.Add(new Rates("Euro", 0.8233));
            swissRates.Add(new Rates("Canadian Dollar", 1.2004));
            swissRates.Add(new Rates("Australian Dollar", 1.1935));
            swissRates.Add(new Rates("Japanese Yen", 113.83));
            swissRates.Add(new Rates("Indian Rupee", 67.311));

            //adding elements to australianRates list

            australianRates.Add(new Rates("US Dollar", 0.939));
            australianRates.Add(new Rates("British Pound", 0.939));
            australianRates.Add(new Rates("Euro", 0.939));
            australianRates.Add(new Rates("Canadian Dollar", 0.939));
            australianRates.Add(new Rates("Swiss Franc", 0.8379));
            australianRates.Add(new Rates("Japanese Yen", 95.383));
            australianRates.Add(new Rates("Indian Rupee", 56.400));

            //adding elements to yenRates list

            yenRates.Add(new Rates("US Dollar", 0.0098));
            yenRates.Add(new Rates("British Pound", 0.0058));
            yenRates.Add(new Rates("Euro", 0.0072));
            yenRates.Add(new Rates("Canadian Dollar", 0.0105));
            yenRates.Add(new Rates("Swiss Franc", 0.0088));
            yenRates.Add(new Rates("Australian Dollar", 0.0105));
            yenRates.Add(new Rates("Indian Rupee", 0.5913));

            //adding elements to indianRates list

            indianRates.Add(new Rates("US Dollar", 0.0166));
            indianRates.Add(new Rates("British Pound", 0.0097));
            indianRates.Add(new Rates("Euro", 0.0122));
            indianRates.Add(new Rates("Canadian Dollar", 0.0178));
            indianRates.Add(new Rates("Swiss Franc", 0.0149));
            indianRates.Add(new Rates("Australian Dollar", 0.0177));
            indianRates.Add(new Rates("Japanese Yen", 1.6912));


            }
        

        public double doExchange(List<Rates> currencyRates, string input)
        {
            double result = 0;

            foreach (Rates element in currencyRates)
            {
                if (element.currrencyName == input)
                {
                    result = inputValue * element.rate;
                }
            }
            return result;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice1 = (string)comboBox2.SelectedItem;
            listOne = comboBox1.SelectedIndex;
            
        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice2 = (string)comboBox2.SelectedItem;
            listTwo = comboBox2.SelectedIndex;
            
        }

        public void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inputValue = Convert.ToDouble(textBox1.Text);
            }
            catch (System.Exception)
            {
           
                
            }
        }

        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (e.KeyChar == '.' && !textBox1.Text.Contains('.'))
            {
                return;
            }
            e.Handled = true;
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != string.Empty   && comboBox2.Text != string.Empty && textBox1.Text != "")
                {

                    if (listOne == listTwo)     //if the value of both comboboxes is the same
                    {
                        textBox3.Clear();
                        textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal:";
                        textBox2.Clear();
                        textBox2.Text = textBox1.Text + "\t" + comboBox2.SelectedItem + "s";


                    }
                    else
                        if (listOne == 0)
                        {
                            output = Math.Round(doExchange(dollarRates, choice2), 3);
                            textBox3.Clear();
                            textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal:";
                            textBox2.Clear();
                            textBox2.Text = Convert.ToString(output) + "\t" + comboBox2.SelectedItem + "s";
                        }
                        else
                            if (listOne == 1)
                            {
                                output = Math.Round(doExchange(poundRates, choice2), 3);
                                textBox3.Clear();
                                textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal:";
                                textBox2.Clear();
                                textBox2.Text = Convert.ToString(output) + "\t" + comboBox2.SelectedItem + "s";
                            }
                            else
                                if (listOne == 2)
                                {
                                    output = Math.Round(doExchange(euroRates, choice2), 3);
                                    textBox3.Clear();
                                    textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal";
                                    textBox2.Clear();
                                    textBox2.Text = Convert.ToString(output) + "\t" + comboBox2.SelectedItem + "s";
                                }
                                else
                                    if (listOne == 3)
                                    {
                                        output = Math.Round(doExchange(canadianRates, choice2), 3);
                                        textBox3.Clear();
                                        textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal:";
                                        textBox2.Clear();
                                        textBox2.Text = Convert.ToString(output) + "\t" + comboBox2.SelectedItem + "s";
                                    }
                                    else
                                        if (listOne == 4)
                                        {
                                            output = Math.Round(doExchange(swissRates, choice2), 3);
                                            textBox3.Clear();
                                            textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal:";
                                            textBox2.Clear();
                                            textBox2.Text = Convert.ToString(output) + "\t" + comboBox2.SelectedItem + "s";
                                        }
                                        else
                                            if (listOne == 5)
                                            {
                                                output = Math.Round(doExchange(australianRates, choice2), 3);
                                                textBox3.Clear();
                                                textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal:";
                                                textBox2.Clear();
                                                textBox2.Text = Convert.ToString(output) + "\t" + comboBox2.SelectedItem + "s";
                                            }
                                            else
                                                if (listOne == 6)
                                                {
                                                    output = Math.Round(doExchange(yenRates, choice2), 3);
                                                    textBox3.Clear();
                                                    textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal:";
                                                    textBox2.Clear();
                                                    textBox2.Text = Convert.ToString(output) + "\t" + comboBox2.SelectedItem + "s";
                                                }
                                                else
                                                    if (listOne == 7)
                                                    {
                                                        output = Math.Round(doExchange(indianRates, choice2), 3);
                                                        textBox3.Clear();
                                                        textBox3.Text = Convert.ToString(inputValue) + "\t" + comboBox1.SelectedItem + "s" + " equal:";
                                                        textBox2.Clear();
                                                        textBox2.Text = Convert.ToString(output) + "\t" + comboBox2.SelectedItem + "s";
                                                    }
                }
                else
                {
                    MessageBox.Show("One or more values are missing! \nPlease amend and try again.", "Error",MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            
            catch
            { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

    }
    public class Rates
    {
        public string currrencyName { get; set; }
        public double rate { get; set; }

        public Rates(string name, double rate)
        {
            this.currrencyName = name;
            this.rate = rate;
        }

    }
}
