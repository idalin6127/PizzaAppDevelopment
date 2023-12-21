namespace LING_Pizza
{
    public partial class Form1 : Form
    {

        public enum PizzaSize
        {
            Small, Medium, Large, ExtraLarge
        }

        List<User> UserList;

        public Form1()
        {
            InitializeComponent();

            UserList = new List<User>();

            this.cmbPizzaSize.DataSource = Enum.GetNames(typeof(PizzaSize));
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //lblResponseMessage.Text += "\nRegister Button Clicked";
            User currentUser = new User();

            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                this.lblMyName.Text = "Name is empty";
            }
            else
            {
                this.lblMyName.Text = this.txtName.Text;

                currentUser.Name = this.txtName.Text;
            }

            if (String.IsNullOrEmpty(this.txtPhoneNumber.Text))
            {
                this.lblMyPhoneNumber.Text = "Phone number cannot be empty";
            }
            else
            {
                //use try..catch to check for any error during conversion
                currentUser.PhoneNumber = Convert.ToInt32(this.txtPhoneNumber.Text);
                this.lblMyPhoneNumber.Text = this.txtPhoneNumber.Text;

                this.UserList.Add(currentUser);
            }

            if (this.rdbNonVeg.Checked)
            {
                this.lblVegOrNonVeg.Text = this.rdbNonVeg.Text;
                currentUser.EatingHabbit = this.rdbNonVeg.Text;
            }
            else if (this.rdbVeg.Checked)
            {
                this.lblVegOrNonVeg.Text = this.rdbVeg.Text;
                currentUser.EatingHabbit = this.rdbVeg.Text;
            }

            this.lblMyToppings.Text = "";

            if (this.chkOnions.Checked)
            {
                this.lblMyToppings.Text += this.chkOnions.Text + ", ";
            }
            if (this.chkOlives.Checked)
            {
                this.lblMyToppings.Text += this.chkOlives.Text + ", ";
            }
            if (this.chkPeppers.Checked)
            {
                this.lblMyToppings.Text += this.chkPeppers.Text + ", ";
            }
            if (this.chkCheese.Checked)
            {
                this.lblMyToppings.Text += this.chkCheese.Text + ", ";
            }
            if (this.chkGarlic.Checked)
            {
                this.lblMyToppings.Text += this.chkGarlic.Text + ", ";
            }
            if (this.chkSauce.Checked)
            {
                this.lblMyToppings.Text += this.chkSauce.Text + ", ";
            }
            currentUser.Seasoning = this.lblMyToppings.Text;


            this.lblSizeOfPizza.Text = this.cmbPizzaSize.SelectedItem.ToString();
            currentUser.PizzaSize = this.cmbPizzaSize.SelectedItem.ToString();

            this.lblQuantityOrdered.Text = this.nmuPizzaQuantity.Text;
            currentUser.PizzaQuantity = this.nmuPizzaQuantity.Text;
            CalculateCost();
        }

        public void CalculateCost()
        {
            double price = 0.0;

            if (this.cmbPizzaSize.SelectedIndex == 0)
            {
                if (this.rdbNonVeg.Checked)
                    price = 5.99;
                else
                    price = 6.99;
            }
            else if (this.cmbPizzaSize.SelectedIndex == 1)
            {
                if (this.rdbNonVeg.Checked)
                    price = 7.99;
                else
                    price = 8.99;
            }
            else if (this.cmbPizzaSize.SelectedIndex == 2)
            {
                if (this.rdbNonVeg.Checked)
                    price = 10.99;
                else
                    price = 12.99;
            }
            else if (this.cmbPizzaSize.SelectedIndex == 3)
            {
                if (this.rdbNonVeg.Checked)
                    price = 13.99;
                else
                    price = 15.00;
            }
            else
            {
                Console.WriteLine("Invalid size!");
            }

            int quantity = (int)this.nmuPizzaQuantity.Value; 

            double TotalCost = price * quantity;
            double TaxAmount = TotalCost * 0.13;
            double FinalCost = TotalCost + TaxAmount; 

            this.lblTaxAmount.Text = TaxAmount.ToString("0.00");
            this.lblFinalCostOfOrder.Text = FinalCost.ToString("0.00");
        }
        private void btnStartOver_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtPhoneNumber.Text = "";
            this.rdbNonVeg.Checked = true;
            this.rdbVeg.Checked = false;
            this.chkCheese.Checked = false;
            this.chkGarlic.Checked = false;
            this.chkOlives.Checked = false;
            this.chkOnions.Checked = false;
            this.chkPeppers.Checked = false;
            this.chkSauce.Checked = false;
            this.cmbPizzaSize.SelectedItem = 1;
            this.nmuPizzaQuantity.Value = 1;

            this.lblMyName.Text = "";
            this.lblMyPhoneNumber.Text = "";
            this.lblSizeOfPizza.Text = "";
            this.lblVegOrNonVeg.Text = "";
            this.lblQuantityOrdered.Text = "";
            this.lblMyToppings.Text = "";
            this.lblTaxAmount.Text = "";
            this.lblFinalCostOfOrder.Text = "";
            this.lblCode.Text = "";

        }

        private void btnDailySpecial_Click(object sender, EventArgs e)
        {
            this.btnDailySpecial.Text = "DAILY SPECIAL";
            this.txtPhoneNumber.Visible = false;
            this.lblCode.Visible = true;
            this.lblCode.Text = "OFFERSPECIAL";
            this.lblVegOrNonVeg.Text = "Non vegetarian";
            this.lblSizeOfPizza.Text = "Large";
            this.lblMyToppings.Text = "None";
            //this.lalToppings.Text = "None";
            this.lblQuantityOrdered.Text = "2";
            this.lblFinalCostOfOrder.Text = "$29.357";
            this.lblTaxAmount.Text = "$3.377 ";
            //this.lalMessage.ForeColor = Color.Black;
            this.lblRemark.Text = "This is today's special offer for you.";


            this.txtName.Text = "";
            this.txtPhoneNumber.Text = "";
            this.rdbVeg.Checked = false;
            this.rdbNonVeg.Checked = true;
            this.cmbPizzaSize.SelectedIndex = 1;
            this.chkOnions.Checked = false;
            this.chkOlives.Checked = false;
            this.chkPeppers.Checked = false;
            this.chkCheese.Checked = false;
            this.chkGarlic.Checked = false;
            this.chkSauce.Checked = false;
            this.nmuPizzaQuantity.Value = 1;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbPizzaSize.SelectedIndex = 1;
            this.nmuPizzaQuantity.Value = 1;
            this.lblMyName.Text = "";
            this.lblMyPhoneNumber.Text = "";
            this.lblSizeOfPizza.Text = "";
            this.lblVegOrNonVeg.Text = "";
            this.lblQuantityOrdered.Text = "";
            this.lblMyToppings.Text = "";
            this.lblTaxAmount.Text = "";
            this.lblFinalCostOfOrder.Text = "";
            this.lblCode.Text = "";
            this.lblRemark.Text = "";
        }
    }
}

    