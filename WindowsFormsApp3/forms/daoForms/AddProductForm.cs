using System;
using System.Windows.Forms;

namespace WindowsFormsApp3.forms.daoForms;

public partial class AddProductForm : Form
{
    public AddProductForm()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MenuFrom menuFrom = new MenuFrom();
        this.Hide();
        menuFrom.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string name = textBox1.Text;
        string category = textBox2.Text;
        string quantity = textBox3.Text;
        string minQuantity = textBox4.Text;
        if (name == null || category == null || quantity == null || minQuantity == null)
        {
            MessageBox.Show("Неправильно введены данные");
            return;
        }
        Service service = new Service();
        Product product = new Product();
        product.Name = name;
        product.Category = category;
        try
        {
            product.Quantity = Convert.ToInt32(quantity);
            product.MinQuantity = Convert.ToInt32(minQuantity);
        }
        catch (Exception exception)
        {
            MessageBox.Show("Неправильно введены данные");
            return;
        }
        service.addProduct(product);
        MessageBox.Show("Продукт успешно добавлен");
    }
}