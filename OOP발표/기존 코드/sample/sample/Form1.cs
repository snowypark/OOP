using System;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        private double totalAmount;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double price;
            if (double.TryParse(txtPrice.Text, out price))
            {
                totalAmount += price;
                lbxItems.Items.Add($"물건: {name}, 가격: {price:N0}원");
                lblTotalAmount.Text = $"총액: {totalAmount:N0}원";

                txtName.Clear();
                txtPrice.Clear();
            }
            else
            {
                MessageBox.Show("유효한 숫자 형식을 입력하세요.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxItems.Items.Clear();
            lblTotalAmount.Text = "총액: $0.00";
            totalAmount = 0.0;
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lbxItems의 선택 항목 변경 시 실행되는 코드
        }
    }
}
