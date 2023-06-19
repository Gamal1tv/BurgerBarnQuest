using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerBarnQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        //global variables
        float total;
        float discount;
        List<string> listItems = new List<string>();
        List<float> orderPrices = new List<float>();

        public void Burger(object sender)
        {
            RadioButton burgerchoice = sender as RadioButton; //creates radio button choice variable for burger radio buttons
            float itemPrice = float.Parse(burgerchoice.Tag.ToString());

            if (burgerchoice.Checked) //below is executed if a radio button in group box burgers is checked
            {
                if (orderPrices.Count == 0)
                {
                    orderPrices.Add(itemPrice);
                    listborder.Items.Add(burgerchoice.Text.ToString());
                }
                else
                {
                    for (int currentList = 0; currentList < orderPrices.Count; currentList++)
                    {
                        if (itemPrice >= orderPrices[currentList])
                        {
                            orderPrices.Insert(currentList, itemPrice);
                            listborder.Items.Insert(currentList, burgerchoice.Text.ToString());
                            break;
                        }
                        else if (currentList == orderPrices.Count - 1)
                        {
                            orderPrices.Add(itemPrice);
                            listborder.Items.Add(burgerchoice.Text.ToString());
                            break;
                        }
                    }
                }
                if (cboxDiscount.Text == "20%") //executed if coupon button is disabled
                {
                    discount = 0.8f;
                    total = (total + float.Parse(burgerchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount;  //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "40%") //executed if coupon button is disabled
                {
                    discount = 0.6f;
                    total = (total + float.Parse(burgerchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount;  //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "60%") //executed if coupon button is disabled
                {
                    discount = 0.4f;
                    total = (total + float.Parse(burgerchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount;  //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "Discount") //executed if coupon button is enabled
                {
                    total = total + float.Parse(burgerchoice.Tag.ToString()); //total calculation
                    txttotal.Text = (total * 1.0825).ToString(); //total time tax gets added to text box
                }

                //uncheckes all radio buttons when purchase button is clicked
                if (rbPburger.Checked)
                {
                    rbPburger.Checked = false;
                }
                if (rbCburger.Checked)
                {
                    rbCburger.Checked = false;
                }
                if (rbVburger.Checked)
                {
                    rbVburger.Checked = false;
                }
                if (rbBburger.Checked)
                {
                    rbBburger.Checked = false;
                }
            }

        }
        private void rbPburger_CheckedChanged(object sender, EventArgs e)
        {
            Burger(sender);
        }

        public void Drink(object sender)
        {
            RadioButton drinkchoice = sender as RadioButton; //creates radio button choice variable for drinks radio buttons
            float itemPrice = float.Parse(drinkchoice.Tag.ToString());

            if (drinkchoice.Checked) //below is executed if a radio button in group box drinks is checked
            {
                if (drinkchoice.Checked) //below is executed if a radio button in group box burgers is checked
                {
                    if (orderPrices.Count == 0)
                    {
                        orderPrices.Add(itemPrice);
                        listborder.Items.Add(drinkchoice.Text.ToString());
                    }
                    else
                    {
                        for (int currentList = 0; currentList < orderPrices.Count; currentList++)
                        {
                            if (itemPrice >= orderPrices[currentList])
                            {
                                orderPrices.Insert(currentList, itemPrice);
                                listborder.Items.Insert(currentList, drinkchoice.Text.ToString());
                                break;
                            }
                            else if (currentList == orderPrices.Count - 1)
                            {
                                orderPrices.Add(itemPrice);
                                listborder.Items.Add(drinkchoice.Text.ToString());
                                break;
                            }
                        }
                    }
                }
                if (cboxDiscount.Text == "20%") //executed if coupon button is disabled
                {
                    discount = 0.8f;
                    total = (total + float.Parse(drinkchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount; //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "40%") //executed if coupon button is disabled
                {
                    discount = 0.6f;
                    total = (total + float.Parse(drinkchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount; //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "60%") //executed if coupon button is disabled
                {
                    discount = 0.4f;
                    total = (total + float.Parse(drinkchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount; //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "Discount")//executed if coupon button is enabled
                {
                    total = total + float.Parse(drinkchoice.Tag.ToString()); //total calculation
                    txttotal.Text = (total * 1.0825).ToString(); //total time tax gets added to text box
                }

                //uncheckes all radio buttons when purchase button is clicked
                if (rbcola.Checked)
                {
                    rbcola.Checked = false;
                }
                if (rbtea.Checked)
                {
                    rbtea.Checked = false;
                }
                if (rbpunch.Checked)
                {
                    rbpunch.Checked = false;
                }
                if (rbwater.Checked)
                {
                    rbwater.Checked = false;
                }
            }
        }

        private void rbcola_CheckedChanged(object sender, EventArgs e)
        {
            Drink(sender);
        }

        public void Purchase()
        {
            MessageBox.Show("Thank you for your purchase!");
            listborder.Items.Clear(); //list box is cleared
            txttotal.Clear(); //total is cleared
            total = 0; //total is cleared
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            Purchase();
        }

        public void Exit()
        {
            Application.Exit(); //Application closes when exit button is clicked
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        public void Sandwich(object sender)
        {
            RadioButton sandwichchoice = sender as RadioButton; //creates radio button choice variable for sandwich radio buttons
            float itemPrice = float.Parse(sandwichchoice.Tag.ToString());

            if (sandwichchoice.Checked) //below is executed if a radio button in group box sandwiches is checked
            {
                if (sandwichchoice.Checked) //below is executed if a radio button in group box burgers is checked
                {
                    if (orderPrices.Count == 0)
                    {
                        orderPrices.Add(itemPrice);
                        listborder.Items.Add(sandwichchoice.Text.ToString());
                    }
                    else
                    {
                        for (int currentList = 0; currentList < orderPrices.Count; currentList++)
                        {
                            if (itemPrice >= orderPrices[currentList])
                            {
                                orderPrices.Insert(currentList, itemPrice);
                                listborder.Items.Insert(currentList, sandwichchoice.Text.ToString());
                                break;
                            }
                            else if (currentList == orderPrices.Count - 1)
                            {
                                orderPrices.Add(itemPrice);
                                listborder.Items.Add(sandwichchoice.Text.ToString());
                                break;
                            }
                        }
                    }
                }
                if (cboxDiscount.Text == "20%") //executed if coupon button is disabled
                {
                    discount = 0.8f;
                    total = (total + float.Parse(sandwichchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount; //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "40%") //executed if coupon button is disabled
                {
                    discount = 0.6f;
                    total = (total + float.Parse(sandwichchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount; //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "60%") //executed if coupon button is disabled
                {
                    discount = 0.4f;
                    total = (total + float.Parse(sandwichchoice.Tag.ToString())); // total is calculated
                    float withdiscount = total * discount; //total with discount is calculated
                    txttotal.Text = (withdiscount * (1.0825)).ToString(); //total with discount times tax is put in text box
                }
                else if (cboxDiscount.Text == "Discount")//executed if coupon button is enabled
                {
                    total = total + float.Parse(sandwichchoice.Tag.ToString()); //total calculation
                    txttotal.Text = (total * 1.0825).ToString(); //total time tax gets added to text box
                }

                //uncheckes all radio buttons when purchase button is clicked
                if (rbchicken.Checked)
                {
                    rbchicken.Checked = false;
                }
                if (rbturkey.Checked)
                {
                    rbturkey.Checked = false;
                }
                if (rbitaliansub.Checked)
                {
                    rbitaliansub.Checked = false;
                }
                if (rbblt.Checked)
                {
                    rbblt.Checked = false;
                }
            }
        }
        private void rbchicken_CheckedChanged(object sender, EventArgs e)
        {
            Sandwich(sender);
        }

        private void cboxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txttotal.Text.Length > 0) //below is executed if text box has nothing in it
            {
                float withdiscount = total * discount; //discounted price calculation
                txttotal.Text = (withdiscount * (1.0825)).ToString(); //total text box reads the discounted price times tax
            }

        }
    }
}
