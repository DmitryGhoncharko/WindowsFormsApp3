using System;
using System.Windows.Forms;
using WindowsFormsApp3.forms.daoForms;

namespace WindowsFormsApp3.forms;

public partial class MenuFrom : Form
{
    public MenuFrom()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        AddProductForm addProductForm = new AddProductForm();
        this.Hide();
        addProductForm.Show();
    }
}