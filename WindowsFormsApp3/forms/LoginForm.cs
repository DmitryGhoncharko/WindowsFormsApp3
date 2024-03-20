using System;
using System.Windows.Forms;
using WindowsFormsApp3.entity;

namespace WindowsFormsApp3.forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var login = textBox1.Text;
        var password = textBox2.Text;
        
        
        if (login == null || password == null)
        {
            MessageBox.Show("Логин и пароль не должны быть пустыми");
            return;
        }

        Service service = new Service();
        User user = service.findUserByLogin(login);
        if (user == null)
        {
            MessageBox.Show("Такого пользователя не существует");
            return;
        }

        if (user.UserPassword.Equals(password))
        {
            MenuFrom menuFrom = new MenuFrom();
            this.Hide();
            menuFrom.Show();
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль");
            return; 
        }
       
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MainFrom mainFrom = new MainFrom();
        this.Hide();
        mainFrom.Show();
    }
}