using ConsignmentShopsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> ShoppingCartData = new List<Item>();

        BindingSource itemsBinding = new BindingSource();
        BindingSource CartBinding = new BindingSource();
        BindingSource VendorsBinding = new BindingSource();
        private decimal StoreProfit = 0;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x=> x.Sold==false).ToList();
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";


            CartBinding.DataSource = ShoppingCartData;
            shoppingcartlistBox.DataSource = CartBinding;

            shoppingcartlistBox.DisplayMember = "Display";
            shoppingcartlistBox.ValueMember = "Display";


            VendorsBinding.DataSource = store.Vendors;
            VendorListBox.DataSource = VendorsBinding;

            VendorListBox.DisplayMember = "Display";
            VendorListBox.ValueMember = "Display";


        }

        private void SetupData()
        {
            // method 1 to add items:

            //Vendor demoVendor = new Vendor();
            //demoVendor.FirstName = "Mona";
            //demoVendor.LastName = "Osama";
            //demoVendor.Commesion = .5;
            //store.Vendors.Add(demoVendor);

            //demoVendor = new Vendor();
            //demoVendor.FirstName = "Sue";
            //demoVendor.LastName = "Jons";
            //demoVendor.Commesion = .5;
            //store.Vendors.Add(demoVendor);


            // method 2 to add items:
            store.Vendors.Add(new Vendor { FirstName = "Mona", LastName = "Elgendy" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A tale of two cities",
                Description = "A book about a Revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry potter Book 1",
                Description = "A book about a boy",
                Price = 3.90M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyer",
                Description = "A book about a girl",
                Price = 4.80M,
                Owner = store.Vendors[0]
            });

            store.Name = "Seconds are better";





        }


        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //figure out what is selected from items list

            //copy that item to the shopping cart

            //do we remove the item from the items list ? -no
            Item selecteditem = (Item)itemsListBox.SelectedItem;

            

            ShoppingCartData.Add(selecteditem);
            CartBinding.ResetBindings(false);



        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //mark each item in the cart as sold
            // clear the cart
            foreach(Item item in ShoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commesion * item.Price;
                StoreProfit+=( 1-(decimal)item.Owner.Commesion) * item.Price;
            }
            ShoppingCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            StoreProfitValue.Text = string.Format("${0}", StoreProfit);
            CartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            VendorsBinding.ResetBindings(false);
        }
    }
}
