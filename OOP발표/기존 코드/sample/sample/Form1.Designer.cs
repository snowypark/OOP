using System;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTotalAmount;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnCalculate;
        private Button btnClear;
        private ListBox lbxItems;
        private Label label1;
        private Label label2;
        private Label label3;

 
        private void InitializeComponent()
        {
            this.lblTotalAmount = new Label();
            this.txtName = new TextBox();
            this.txtPrice = new TextBox();
            this.btnCalculate = new Button();
            this.btnClear = new Button();
            this.lbxItems = new ListBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("±¼¸²", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalAmount.Location = new System.Drawing.Point(109, 345);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(60, 16);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "ÃÑ ±Ý¾×";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("±¼¸²", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(431, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrice.Font = new System.Drawing.Font("±¼¸²", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrice.Location = new System.Drawing.Point(431, 201);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(442, 277);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "°è»ê";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(442, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "ÃÊ±âÈ­";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // lbxItems
            // 
            this.lbxItems.Font = new System.Drawing.Font("±¼¸²", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 16;
            this.lbxItems.Location = new System.Drawing.Point(30, 27);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(357, 276);
            this.lbxItems.TabIndex = 5;
            this.lbxItems.SelectedIndexChanged += new EventHandler(this.lbxItems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "ÃÑ ±Ý¾×";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "¹°°Ç ÀÔ·Â";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "±Ý¾× ÀÔ·Â";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(585, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTotalAmount);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


    }
}
