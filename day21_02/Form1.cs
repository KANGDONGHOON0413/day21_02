using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day21_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //방법2: Size = new Size(550,550);

            //방법3: 
            //Width = 550;
            //Height = 550;
        }

        private void Form1_Resize(object sender, EventArgs e)   //폼의 크기변경 감지
        {
            Control ctrl = (Control)sender; //매개변수값을 언박싱을 한 후 넘겨준다.

            //폼의 크기 변경이 감지되었을 때 크기를 다시금 재조정하는 부분
            ctrl.Width = 550;
            ctrl.Height = 550;

            MessageBox.Show("resize detected");

            // 간소화
            //Width = 550;
            //Height = 550;
        }

        private void Form1_Layout(object sender, LayoutEventArgs e) //폼의크기변경 + 폼의 컨트롤 배치가 바뀌는 경우
        {
            MessageBox.Show("layout change detected");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
        }
    }
}
