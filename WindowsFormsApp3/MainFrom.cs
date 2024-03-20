using System;
using System.Windows.Forms;
using WindowsFormsApp3.forms;

namespace WindowsFormsApp3;

public partial class MainFrom : Form
{
    public MainFrom()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var loginForm = new LoginForm();
        Hide();
        loginForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var registrationForm = new RegistrationForm();
        Hide();
        registrationForm.Show();
    }
}