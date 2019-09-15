using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh3_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<DienTu> listsDienTu = new List<DienTu>();
        private void đToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bàiĐiềnTừ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string debai = "";
            debai = "My grandfather was born in China. He came form a very poor family and was (1) ______ of seven children."
                + " His parents lived (2)____ a small farm."
                + " He didn't have a very good education. At the age of 17 he (3)_____home. "
                + "First he went to Shanghai and (4)_____he went to Hong Kong. He worded (5)_____a waiter and then as a cook. "
                + "When he was 21, he (6)_____ my grandmother and had four children. "
                + "\nMy mother was (7)_____oldest. My grandmother died rececntly, and my grandfather lives alone now. "
                + "He is almost 80, (8)_____he is still very active and interested in everything (9)_____ is going on. "
                + "He reads the papes and (10)_____televison even though his eyesight is fairly poor.";
            string dapan = "";
            dapan = "My grandfather was born in China. He came form a very poor family and was (1) one - of seven children."
                + " His parents lived (2) on - a small farm."
                + " He didn't have a very good education. At the age of 17 he (3)left - home. "
                + "First he went to Shanghai and (4)then - he went to Hong Kong. He worded (5)as - a waiter and then as a cook. "
                + "When he was 21, he (6)married - my grandmother and had four children. "
                + "\nMy mother was (7) the - oldest. My grandmother died rececntly, and my grandfather lives alone now. "
                + "He is almost 80, (8) but - he is still very active and interested in everything (9) that - is going on. "
                + "He reads the papes and (10) watches - televison even though his eyesight is fairly poor.";
            List<string> lists = new List<string>();
            lists.Add("one");
            lists.Add("on");
            lists.Add("left");
            lists.Add("then");
            lists.Add("as");
            lists.Add("married");
            lists.Add("the");
            lists.Add("but");
            lists.Add("that");
            lists.Add("watches");
            listsDienTu.Add(new DienTu(debai, dapan, lists));
            StaticData._DienTus = listsDienTu;
            DienTu_1 frm = new DienTu_1();
            frm.ShowDialog();
        }
    }
}
