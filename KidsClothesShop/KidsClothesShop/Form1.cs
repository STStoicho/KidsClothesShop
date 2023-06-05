using KidsClothesShop.Controller;
using KidsClothesShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KidsClothesShop
{
    public partial class Form1 : Form
    {
        ProductLogic productsController = new ProductLogic();
        ProductTypeLogic productTypesController = new ProductTypeLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadRecord(Product product)
        {
            txb_Id.Text = product.Id.ToString();
            txb_Name.Text = product.Name;
            txb_Price.Text = product.Price.ToString();
            txb_Size.Text = product.Size.ToString();
            cmb_Gender.Text = product.Gender;
            cmb_Type.Text = product.ProductTypes.NameType;
            txb_Description.Text = product.Description;
        }

        private void ClearScreen()
        {
            txb_Id.Clear();
            txb_Name.Clear();
            txb_Price.Clear();
            txb_Size.Clear();
            cmb_Gender.Text = "";
            cmb_Type.Text = "";
            txb_Description.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductType> allProductTypes = productTypesController.GetAllProductTypes();
            cmb_Type.DataSource = allProductTypes;
            cmb_Type.DisplayMember = "NameType";
            cmb_Type.ValueMember = "Id";

            btn_SelectAll_Click(sender, e);
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            List<Product> allProducts = productsController.GetAll();
            listbox.Items.Clear();
            foreach (var item in allProducts)
            {
                listbox.Items.Add($"{item.Id}. {item.Name}, Price: {item.Price}, Size: {item.Size}, Gender: {item.Gender}, Type: {item.ProductTypes.NameType}, Description: {item.Description}");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_Name.Text) || txb_Name.Text == "")
            {
                MessageBox.Show("Въведете данни!");
                txb_Name.Focus();
                return;
            }

            Product newProduct = new Product();
            newProduct.Name = txb_Name.Text;
            newProduct.Price = double.Parse(txb_Price.Text);
            newProduct.Size = int.Parse(txb_Size.Text);
            newProduct.Gender = cmb_Gender.Text;
            newProduct.ProductTypeId = (int)cmb_Type.SelectedValue;
            newProduct.Description = txb_Description.Text;

            productsController.Create(newProduct);
            MessageBox.Show("Successfully added!");
            ClearScreen();
            btn_SelectAll_Click(sender, e);
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txb_Id.Text) || !txb_Id.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter ID!");
                txb_Id.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txb_Id.Text);
            }
            Product findedProduct = productsController.Get(findId);
            if (findedProduct == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Enter ID!");
                txb_Id.Focus();
                return;
            }
            LoadRecord(findedProduct);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txb_Id.Text) || !txb_Id.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter ID!");
                txb_Id.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txb_Id.Text);
            }

            if (string.IsNullOrEmpty(txb_Name.Text))
            {
                Product findedProduct = productsController.Get(findId);
                if (findedProduct == null)
                {
                    MessageBox.Show("Няма такъв запис е БД!");
                    txb_Id.Focus();
                    return;
                }
                LoadRecord(findedProduct);
            }
            else
            {
                Product updatedProduct = new Product();
                updatedProduct.Name = txb_Name.Text;
                updatedProduct.Price = double.Parse(txb_Price.Text);
                updatedProduct.Size = int.Parse(txb_Size.Text);
                updatedProduct.Gender = cmb_Gender.Text;
                updatedProduct.ProductTypeId = (int)cmb_Type.SelectedValue;
                updatedProduct.Description = txb_Description.Text;

                productsController.Update(findId, updatedProduct);

                MessageBox.Show("Successfully updated!");
            }
            btn_SelectAll_Click(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txb_Id.Text) || !txb_Id.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter ID!");
                txb_Id.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txb_Id.Text);
            }
            Product findedProduct = productsController.Get(findId);
            if (findedProduct == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Enter ID!");
                txb_Id.Focus();
                return;
            }

            DialogResult answer = MessageBox.Show("Are you sure you want to delete No " + findId + " ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                productsController.Delete(findId);

                MessageBox.Show("Successfully deleted!");

                ClearScreen();
            }

            btn_SelectAll_Click(sender, e);
        }
    }
}
