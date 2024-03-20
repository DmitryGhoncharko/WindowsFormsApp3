using System.ComponentModel;

namespace WindowsFormsApp3.forms;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(68, 90);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(205, 32);
        this.label1.TabIndex = 0;
        this.label1.Text = "Логин";
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(467, 90);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(205, 32);
        this.label2.TabIndex = 1;
        this.label2.Text = "Пароль";
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(41, 125);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(157, 22);
        this.textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(434, 125);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(157, 22);
        this.textBox2.TabIndex = 3;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(239, 248);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(210, 63);
        this.button1.TabIndex = 4;
        this.button1.Text = "Войти";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(239, 356);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(209, 51);
        this.button2.TabIndex = 5;
        this.button2.Text = "На главную";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "LoginForm";
        this.Text = "LoginForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;

    #endregion
}