using System.ComponentModel;

namespace WindowsFormsApp3.forms;

partial class MenuFrom
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
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.button4 = new System.Windows.Forms.Button();
        this.button5 = new System.Windows.Forms.Button();
        this.button6 = new System.Windows.Forms.Button();
        this.button7 = new System.Windows.Forms.Button();
        this.button8 = new System.Windows.Forms.Button();
        this.button9 = new System.Windows.Forms.Button();
        this.button10 = new System.Windows.Forms.Button();
        this.button11 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(62, 51);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(178, 49);
        this.button1.TabIndex = 0;
        this.button1.Text = "Добавить товар на склад";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(281, 201);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(178, 49);
        this.button2.TabIndex = 1;
        this.button2.Text = "Добавить стеллаж";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        this.button3.Location = new System.Drawing.Point(475, 272);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(178, 49);
        this.button3.TabIndex = 2;
        this.button3.Text = "Создать заказ";
        this.button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        this.button4.Location = new System.Drawing.Point(62, 272);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(178, 49);
        this.button4.TabIndex = 3;
        this.button4.Text = "Разместить товар на стеллаже";
        this.button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        this.button5.Location = new System.Drawing.Point(62, 201);
        this.button5.Name = "button5";
        this.button5.Size = new System.Drawing.Size(178, 49);
        this.button5.TabIndex = 4;
        this.button5.Text = "Выполнить отгрузку товара";
        this.button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        this.button6.Location = new System.Drawing.Point(475, 188);
        this.button6.Name = "button6";
        this.button6.Size = new System.Drawing.Size(178, 49);
        this.button6.TabIndex = 5;
        this.button6.Text = "Посмотреть заказы";
        this.button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        this.button7.Location = new System.Drawing.Point(475, 124);
        this.button7.Name = "button7";
        this.button7.Size = new System.Drawing.Size(178, 49);
        this.button7.TabIndex = 6;
        this.button7.Text = "Посмотреть продукты";
        this.button7.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        this.button8.Location = new System.Drawing.Point(281, 124);
        this.button8.Name = "button8";
        this.button8.Size = new System.Drawing.Size(178, 49);
        this.button8.TabIndex = 7;
        this.button8.Text = "Вывести отчет по поставке и отгрузке за указанный месяц";
        this.button8.UseVisualStyleBackColor = true;
        // 
        // button9
        // 
        this.button9.Location = new System.Drawing.Point(62, 124);
        this.button9.Name = "button9";
        this.button9.Size = new System.Drawing.Size(178, 49);
        this.button9.TabIndex = 8;
        this.button9.Text = "Выполнить поставку товара";
        this.button9.UseVisualStyleBackColor = true;
        // 
        // button10
        // 
        this.button10.Location = new System.Drawing.Point(475, 51);
        this.button10.Name = "button10";
        this.button10.Size = new System.Drawing.Size(178, 49);
        this.button10.TabIndex = 9;
        this.button10.Text = "Посмотреть стеллажи";
        this.button10.UseVisualStyleBackColor = true;
        // 
        // button11
        // 
        this.button11.Location = new System.Drawing.Point(281, 51);
        this.button11.Name = "button11";
        this.button11.Size = new System.Drawing.Size(178, 49);
        this.button11.TabIndex = 10;
        this.button11.Text = "Вывести отчет о наличии и размещении товаров";
        this.button11.UseVisualStyleBackColor = true;
        // 
        // MenuFrom
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.button11);
        this.Controls.Add(this.button10);
        this.Controls.Add(this.button9);
        this.Controls.Add(this.button8);
        this.Controls.Add(this.button7);
        this.Controls.Add(this.button6);
        this.Controls.Add(this.button5);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Name = "MenuFrom";
        this.Text = "MenuFrom";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.Button button11;

    private System.Windows.Forms.Button button1;

    #endregion
}