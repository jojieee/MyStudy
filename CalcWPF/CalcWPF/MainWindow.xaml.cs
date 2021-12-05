using System;
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

namespace CalcWPF
{
    public partial class MainWindow : Window
    {
        private double saveNum; // 연산자 전에 쓰인 숫자를 저장하는 변수
        private bool op_check;  // 연산자의 쓰임 여부 체크
        private string op;      // 연산자에 쓸 변수

        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnNum_Click(object sender, EventArgs e)    // 1~9,0 버튼클릭 메소드
        {
            Button numbutton = sender as Button;
            if (NumScreen.Text == "0" || op_check == true)      // 값이 0인 경우 또는 연산자가 쓰인 경우 : 처음 누르는 숫자버튼의 숫자로 값이 바뀜
            { 
                NumScreen.Text = numbutton.Content.ToString();
                op_check = false;                               // 연산자가 쓰였을 때는 false로 초기화                
            }
            else
            { 
                NumScreen.Text += numbutton.Content.ToString(); // 위 조건이 아닌 경우에는 계속해서 숫자 연결 
            }

        }
      
        public void BtnPlus_Click(object sender, EventArgs e)   // +버튼 클릭할 때 실행되는 메소드
        {       
            if (op_check == false)
                saveNum = Double.Parse(NumScreen.Text);         // 연산자 쓰이기 전 값을 double형으로 저장
            op = "+";
            op_check = true;                                    // 연산자가 쓰였기때문에 true
        }

        public void BtnMinus_Click(object sender, EventArgs e)  // -버튼 클릭할 때 실행되는 메소드
        { 
            if (op_check == false)
                saveNum = Double.Parse(NumScreen.Text);
            op = "-";
            op_check = true;
        }

        public void BtnMulti_Click(object sender, EventArgs e)  // *버튼 클릭할 때 실행되는 메소드
        {
            if (op_check == false)
                saveNum = Double.Parse(NumScreen.Text);
            op = "*";
            op_check = true;
        }

        public void BtnDivide_Click(object sender, EventArgs e) // /버튼 클릭할 때 실행되는 메소드
        {
            if (op_check == false)
                saveNum = Double.Parse(NumScreen.Text);
            op = "/";
            op_check = true;
        }

        public void BtnEqul_Click(object sender, EventArgs e)   // =버튼 클릭할 때 실행되는 메소드
        { 
            double saveNum2 = Double.Parse(NumScreen.Text);     // 연산자 다음에 쓰이는 숫자를 저장하는 변수

            switch (op)
            {
                case "+":
                    NumScreen.Text = (saveNum + saveNum2).ToString(); // ToString() : double형 값을 문자열 형태로 반환
                    break;
                case "-":
                    NumScreen.Text = (saveNum - saveNum2).ToString(); 
                    break;
                case "*":
                    NumScreen.Text = (saveNum * saveNum2).ToString(); 
                    break;
                case "/":
                    NumScreen.Text = (saveNum / saveNum2).ToString(); 
                    break;
            }
        }
        
        public void Delete_Click(object sender, EventArgs e)    // 맨 뒤에 숫자 하나만 삭제
        { 
            if (NumScreen.Text != "0")
            {
                NumScreen.Text = NumScreen.Text.Remove(NumScreen.Text.Length - 1);
                if (NumScreen.Text == "0" || NumScreen.Text == "") // 값을 지우다 보면 빈 값이 될 경우
                    NumScreen.Text = "0";                          // 값을 0으로 초기화
            }
        }
        
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            saveNum = 0;
            op_check = true;
            NumScreen.Text = "0";
        }
    }

}