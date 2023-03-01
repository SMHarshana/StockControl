using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            cutomizeMenu();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void cutomizeMenu() { 
        panel_sales.Visible = false;
        panel_stocks.Visible = false;
        panel_customer.Visible = false;

        }
        private void hideSubmenu() {

            //if (panel_sales.Visible == true) ;
            //    //panel_sales.Visible=false;

            //    if (panel_stocks.Visible == true) ;
            //    //panel_stocks.Visible = false;
        }
        private void showSubmenu(Panel subMenu) {

            if (subMenu.Visible == false)
            {               
                subMenu.Visible = true;

            }
            else { 
            subMenu.Visible = false;
            }
        
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            //container(new Purchase());
            //lbl_title.Text = "Purchase";
            showSubmenu(panel_sales);
        }
        private void container(object _form) { 
        if(PanelContainer.Controls.Count > 0) PanelContainer.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;   
            PanelContainer.Controls.Add(fm);
            PanelContainer.Tag = fm;
            fm.Show();
        }

        private void btn_estimate_Click(object sender, EventArgs e)
        {
            container(new Estimates());
            lbl_title.Text = "Estimates";
           
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            container(new Invoices());
            lbl_title.Text = "Invoices";
            
        }

        private void btn_products_Click(object sender, EventArgs e)
        {

        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stocks);
        }

        private void btn_adprducts_Click(object sender, EventArgs e)
        {
            container(new Products());
            lbl_title.Text = "Products";
        }

        private void btn_breakdown_Click(object sender, EventArgs e)
        {
            container(new Breakdown());
            lbl_title.Text = "Breakdown";

        }

        private void bnt_customer_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_customer);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            container(new NewCustomer ());
            lbl_title.Text = "Customers";
        }

        private void btn_estimateReport_Click(object sender, EventArgs e)
        {
            container(new EstimateReport());
            lbl_title.Text = "Estimate Report";
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            container(new Home());
            lbl_title.Text = "Home";
        }
    }
}
