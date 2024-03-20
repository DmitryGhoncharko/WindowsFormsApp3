using System;
using System.Windows.Forms;
using WindowsFormsApp3.entity;

namespace WindowsFormsApp3.forms;

public partial class RegistrationForm : Form
{
    public RegistrationForm()
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
        if (user != null)
        {
            MessageBox.Show("Пользователь с таким логином уже существует");
            return;
        }
        service.addUser(login,password);
        MessageBox.Show("Вы успешно зарегистрированы");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MainFrom mainFrom = new MainFrom();
        this.Hide();
        mainFrom.Show();
    }
}