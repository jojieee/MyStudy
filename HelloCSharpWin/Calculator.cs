using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 툴박스
namespace HelloCSharpWin
{
    // 열겨형 데이터 타입 생성
    //public enum Season { Spring, Summer, Fall, Winter }
    public enum Operators { Add, Sub, Multi, Div }

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();

            // 열거형 데이터 타입을 할당
            // Season currentSeason = Season.Spring;
        }

        // 조건문
        /*public bool HasValue()
        {
            return true;
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            //HelloLabel.Text = "Hello C#";

            // int number1 = 10;
            // string operator1 = "*";
            // bool isCorrect = true; // false

            // int sum = 1 + 2;

            int number1 = 1;
            int number2 = 2;
            if (HasValue())
            {

            }
            else if()
            {

            }

            int sum = number1 + number2;

            // 정수를 string으로 변환
            HelloLabel.Text = sum.ToString();
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            // 초기화
            int number1 = 0;
            int number2 = 0;

            // 빈문자열, 공백문자열 처리
            // 벨리데이션
            if (String.IsNullOrWhiteSpace(Sum1.Text))
            {
                // MessageBox Alert창 띄워줌
                MessageBox.Show("Sum1에 숫자를 입력해주세요");
                Sum1.Focus();
                return;
            }

            // TryParse bool (string형 out int형)
            // out 값을 함수안에서 받아옴
            if (int.TryParse(Sum1.Text, out number1) == false)
            {
                // MessageBox Alert창 띄워줌
                MessageBox.Show("Sum1에 문자가 들어왔습니다. 숫자를 입력해주세요");
                // 전체선택 사용이유: 잘못입력된 값을 바로 수정하기 편하게
                Sum1.SelectAll();
                // 포커스 사용이유 : 잘못된 부분으로 이동
                Sum1.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                // MessageBox Alert창 띄워줌
                MessageBox.Show("Sum2에 숫자를 입력해주세요");
                return;
            }

            // TryParse bool (string형 out int형)
            // out 값을 함수안에서 받아옴
            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                // MessageBox Alert창 띄워줌
                MessageBox.Show("Sum2에 문자가 들어왔습니다. 숫자를 입력해주세요");
                return;
            }

            

            int sum = Add(number1, number2);
            // convert.tostring(sum) 과 같음
            SumResult.Text = sum.ToString();
        }
        */

        // 메서드
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {
            // 실수형(1.2, 2.5 ...)
            float sum = number1 + number2;
            return sum;
        }


        // public void Flush(Number1);
        // public void Flush(Number2);
        // public void Flush(Number1, Number2);
        // public void Flush();

        // void : 리턴값이 없다.

        // 함수의 오버로딩 : 
        // 같은 함수의 이름을 갖는것 가능
        // 하지만 같은 함수 같은 매개변수는 불가능

        public int Sub(int number1, int number2)
        {
            int Sub = number1 - number2;
            return Sub;
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            /*
           if (NumScreen.Text == "0")
               NumScreen.Text = "1";
           else
               NumScreen.Text = NumScreen.Text + "1";
           */
            // 모든 버튼에 대한 핸들링
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }
       

        public void SetNum(string num)
        {

            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
            /*
            if (NumScreen.Text == "0")
                NumScreen.Text = num;
            else
                NumScreen.Text = NumScreen.Text + num;
            */
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            // 예외처리 연산자 연속 누르기 방지
            if(isNewNum == false)
            {
                // string 을 int로 변환
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    // 더하기 버튼을 누르면 현재값 변경
                    Result = Add(Result, num);
                else if (Opt == Operators.Sub)
                    Result = Sub(Result, num);
                else if (Opt == Operators.Multi)
                    Result = Result * num;
                else if (Opt == Operators.Div)
                    Result = Result / num;

                // NumScreen에 표시
                NumScreen.Text = Result.ToString();
                // 새로운 숫자를 받아라
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "/")
                Opt = Operators.Div;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }

        // 변수 = 0
        // 연산자 = +

        // 숫자입력
        // 연산자버튼 - 숫자완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장
        // 숫자입력
        // 연산자버튼 - 숫자완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장
    }
}
