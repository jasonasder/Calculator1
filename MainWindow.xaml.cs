﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 新算機
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        float firstNumber, secondNumber;
        int operators = -1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "9";
        }
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + "0";
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); 
            txtNumber.Text = "0";
            operators = 0;
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 1;
        }
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 2;
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 3;
        }
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
        private void btnpesent__Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Text=Convert.ToString(Int32.Parse(txtNumber.Text)*0.01);
        }

        private void btndele_Click(object sender, RoutedEventArgs e)
        {
            int X = txtNumber.Text.Length;
            txtNumber.Text = txtNumber.Text.Substring(0, X - 1);
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            secondNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        
    }
}
