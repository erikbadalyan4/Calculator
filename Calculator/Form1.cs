using Microsoft.VisualBasic.Logging;
using System.Net;
using System.Numerics;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        bool iscommon;
        bool menuexpand;
        bool trigonomexpand;
        bool error = false;
        bool trigonomisgrey = false;
        bool n2;
        bool inmem = false;
        double m = 0;
        double epsilon = 0.00000001;
        double dn1, dn2, res;
        string oper;
        string oper2 = "";
        string N1;
        int sdvig = 0;
        public Form1()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button56.FlatAppearance.BorderSize = 0;
            button56.ImageAlign = ContentAlignment.MiddleLeft;
            textBox1.ReadOnly = true;


        }
        //public double cosinus(double dn)
        //{
        //    int i = 0;
        //    double dn2 = dn;
        //    if (dn > 0)
        //    {

        //        for (i = 0; dn2 > 0; i++)
        //        {
        //            dn2 -= (Math.PI / 2);
        //        }
        //        if (i % 2 == 1 && dn2 <=epsilon)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Math.Cos(dn);
        //        }
        //    }

        //    else if (dn < 0)
        //    {
        //        for (i = 0; dn2 < 0; i++)
        //        {
        //            dn2 += (Math.PI / 2);
        //        }
        //        if (i % 2 == 1 && dn2 >=epsilon)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Math.Cos(dn);
        //        }
        //    }
        //    else
        //    {
        //        return Math.Cos(dn);
        //    }
        //}

        public double cosinus(double dn)
        {


            if (dn != 0 && ((Math.Abs((dn / (Math.PI / 2)) % 2) <= (1 + epsilon)) && (Math.Abs((dn / (Math.PI / 2)) % 2) >= (1 - epsilon))))
            {
                return 0;
            }
            else
            {
                return Math.Cos(dn);
            }

        }



        //public double sinus(double dn)
        //{
        //    int i = 0;
        //    double dn2 = dn;
        //    if (dn > 0)
        //    {

        //        for (i = 0; dn2 > 0; i++)
        //        {
        //            dn2 -= (Math.PI);
        //        }
        //        if (dn2 == 0)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Math.Sin(dn);
        //        }
        //    }

        //    else if (dn < 0)
        //    {
        //        for (i = 0; dn2 < 0; i++)
        //        {
        //            dn2 += Math.PI;
        //        }
        //        if (dn2 == 0)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Math.Sin(dn);
        //        }
        //    }
        //    else
        //    {
        //        return Math.Sin(dn);
        //    }
        //}

        public double sinus(double dn)
        {
            if (dn != 0 && Math.Abs((dn / Math.PI) % 1) <= epsilon)
            {
                return 0;
            }
            else
            {
                return Math.Sin(dn);
            }

        }

        //public double sinush(double dn)
        //{
        //    int i = 0;
        //    double dn2 = dn;
        //    if (dn > 0)
        //    {

        //        for (i = 0; dn2 > 0; i++)
        //        {
        //            dn2 -= (Math.PI);
        //        }
        //        if (dn2 == 0)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Math.Sinh(dn);
        //        }
        //    }

        //    else if (dn < 0)
        //    {
        //        for (i = 0; dn2 < 0; i++)
        //        {
        //            dn2 += Math.PI;
        //        }
        //        if (dn2 == 0)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Math.Sinh(dn);
        //        }
        //    }
        //    else
        //    {
        //        return Math.Sinh(dn);
        //    }
        //}

        public double sinush(double dn)
        {
            if (dn != 0 && Math.Abs((dn / Math.PI) % 1) <= epsilon)
            {
                return 0;
            }
            else
            {
                return Math.Sinh(dn);
            }

        }

        //public double cosinush(double dn)
        //{
        //    int i = 0;
        //    double dn2 = dn;
        //    if (dn > 0)
        //    {

        //        for (i = 0; dn2 > 0; i++)
        //        {
        //            dn2 -= (Math.PI / 2);
        //        }
        //        if (i % 2 == 1 && dn2 == 0)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Math.Cosh(dn);
        //        }
        //    }

        //    else if (dn < 0)
        //    {
        //        for (i = 0; dn2 < 0; i++)
        //        {
        //            dn2 += (Math.PI / 2);
        //        }
        //        if (i % 2 == 1 && dn2 == 0)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Math.Cosh(dn);
        //        }
        //    }
        //    else
        //    {
        //        return Math.Cosh(dn);
        //    }
        //}

        public double cosinush(double dn)
        {
            if (dn != 0 && ((Math.Abs((dn / (Math.PI / 2)) % 2) <= (1 + epsilon)) && (Math.Abs((dn / (Math.PI / 2)) % 2) >= (1 - epsilon))))
            {
                return 0;
            }
            else
            {
                return Math.Cosh(dn);
            }

        }
        public BigInteger Factorial(BigInteger n)
        {

            BigInteger result = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        private void DisableButtons()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;
            button40.Enabled = false;
            button41.Enabled = false;
            button42.Enabled = false;
            button43.Enabled = false;
            button44.Enabled = false;
            button45.Enabled = false;
            button46.Enabled = false;
            button47.Enabled = false;
            button48.Enabled = false;
            button49.Enabled = false;
            button50.Enabled = false;
            button51.Enabled = false;
            button52.Enabled = false;
            button53.Enabled = false;
            button54.Enabled = false;
            button55.Enabled = false;
            panel3.Height = 0;
            trigonomisgrey = true;
            trigonomexpand = false;
            textBox1.Enabled = false;

        }
        private void EnableButtons()
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            if (inmem) 
            {
                button37.Enabled = true;
                button38.Enabled = true;
                button42.Enabled = true;
            }
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            button43.Enabled = true;
            button44.Enabled = true;
            button45.Enabled = true;
            button46.Enabled = true;
            button47.Enabled = true;
            button48.Enabled = true;
            button49.Enabled = true;
            button50.Enabled = true;
            button51.Enabled = true;
            button52.Enabled = true;
            button53.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            trigonomisgrey = false;
            button44.ForeColor = Color.Black;
            textBox1.Enabled = true;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (n2)
            {
                n2 = false;

                textBox1.Text = "0"; oper2 = "";

            }
            if (oper == "=") { label4.Text = ""; oper2 = ""; }
            if (error == true) { textBox1.Font = new Font("Verdana", 24, FontStyle.Bold); EnableButtons(); error = false; label4.Text = ""; textBox1.Text = "0"; oper2 = ""; }
            if (textBox1.Text == "0")
            {
                textBox1.Text = B.Text;

            }
            else
            {
                if (textBox1.Text.Length < 32)
                {
                    textBox1.Text += B.Text;
                }


            }
            this.ActiveControl = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            oper2 = "";
            Button B = (Button)sender;
            oper = B.Text; N1 = textBox1.Text;
            if (oper == "x^y")
            {
                label4.Text = Convert.ToDouble(N1) + "\n^";
            }
            else if (oper == "LOGyX")
            {
                label4.Text = Convert.ToDouble(N1) + "\nlog";
            }
            else if (oper == "exp")
            {
                label4.Text = Convert.ToDouble(N1) + ",e\n";
            }
            else
            {
                label4.Text = Convert.ToDouble(N1) + "\n"+oper;
            }
            n2 = true;






        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (N1 != null)
            {
                if (N1.Length != 0)
                {
                    dn1 = Convert.ToDouble(N1);


                    switch (oper)
                    {
                        case "+":
                            dn2 = Convert.ToDouble(textBox1.Text);
                            res = dn1 + dn2;
                            oper = "=";
                            oper2 = "+";
                            n2 = true;
                            label4.Text += "\n" + dn2 + "\n"+ "=";
                            textBox1.Text = Convert.ToString(res);

                            break;
                        case "−":
                            dn2 = Convert.ToDouble(textBox1.Text);
                            res = dn1 - dn2;
                            oper = "=";
                            oper2 = "−";
                            n2 = true;
                            label4.Text += "\n"+ dn2 + "\n" + "=";
                            textBox1.Text = Convert.ToString(res);
                            break;
                        case "×":
                            dn2 = Convert.ToDouble(textBox1.Text);
                            res = dn1 * dn2;
                            oper = "=";
                            oper2 = "×";
                            n2 = true;
                            label4.Text += "\n"+ dn2 + "\n" + "=";
                            textBox1.Text = Convert.ToString(res);
                            break;
                        case "÷":
                            dn2 = Convert.ToDouble(textBox1.Text);
                            if (dn2 != 0)
                            {
                                res = dn1 / dn2;
                                label4.Text += "\n" + dn2 + "\n" + "=";
                                textBox1.Text = Convert.ToString(res);
                            }
                            else
                            {
                                label4.Text += "\n" + dn2 + "\n" + "=";
                                textBox1.Text = "Деление на ноль невозможно!";
                                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                                error = true;
                                DisableButtons();
                            }
                            oper = "=";
                            oper2 = "÷";
                            n2 = true;
                            
                            break;
                        case "%":
                            dn2 = Convert.ToDouble(textBox1.Text);
                            if (dn2 != 0)
                            {
                                res = dn1 % dn2;
                            }
                            else
                            {
                                res = dn1;
                            }
                            oper = "=";
                            oper2 = "%";
                            n2 = true;
                            label4.Text += "\n"+ dn2 + "\n" + "=";
                            textBox1.Text = Convert.ToString(res);
                            break;
                        case "x^y":
                            dn2 = Convert.ToDouble(textBox1.Text);
                            if (dn2 % 1 != 0 && dn1 < 0)
                            {
                                label4.Text += "\n" + dn2 + "\n" + "=";
                                textBox1.Text = "Неверный ввод";
                                textBox1.Font = new Font("Verdana", 18, FontStyle.Bold);
                                error = true;
                                DisableButtons();
                            }
                            else
                            {
                                label4.Text += "\n" + dn2 + "\n" + "=";
                                res = Math.Pow(dn1, dn2);
                                textBox1.Text = Convert.ToString(res);
                            }
                            oper = "=";
                            oper2 = "x^y";
                            n2 = true;
                            
                            break;
                        case "LOGyX":
                            dn2 = Convert.ToDouble(textBox1.Text);
                            if (dn1 > 0 && dn2 > 0 && dn2 != 1)
                            {
                                label4.Text += "\n" + dn2 + "\n" + "=";
                                res = Math.Log(dn1, dn2);
                                textBox1.Text = Convert.ToString(res);
                            }
                            else if (dn2 == 1)
                            {
                                label4.Text += "\n" + dn2 + "\n" + "=";
                                textBox1.Text = "Деление на ноль невозможно!";
                                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                                error = true;
                                DisableButtons();
                            }
                            else if (dn1 <= 0 || dn2 <= 0)
                            {
                                label4.Text += "\n" + dn2 + "\n" + "=";
                                textBox1.Text = "Неверный ввод";
                                textBox1.Font = new Font("Verdana", 18, FontStyle.Bold);
                                error = true;
                                DisableButtons();
                            }
                            oper = "=";
                            oper2 = "LOGyX";
                            n2 = true;
                            
                            break;

                        case "exp":
                            dn2 = Convert.ToDouble(textBox1.Text);
                            res = dn1 * Math.Pow(10, dn2);
                            oper = "=";
                            oper2 = "exp";
                            n2 = true;
                            if (dn2 >= 0)
                            {
                                label4.Text += "+" + "\n" + dn2 + "\n" + "=";
                            }
                            else
                            {
                                label4.Text += textBox1.Text[0] + "\n" + Math.Abs(dn2) + "\n" + "=";
                            }

                            textBox1.Text = Convert.ToString(res);
                            break;


                        case "=":

                            dn1 = res;
                            switch (oper2)
                            {
                                case "+":
                                    res = dn1 + dn2;
                                    oper = "=";
                                    oper2 = "+";
                                    n2 = true;
                                    label4.Text = dn1 + "\n" + "+" + "\n" + dn2 + "\n" + "=";
                                    textBox1.Text = Convert.ToString(res);

                                    break;
                                case "−":
                                    res = dn1 - dn2;
                                    oper = "=";
                                    oper2 = "−";
                                    n2 = true;
                                    label4.Text = dn1 + "\n" + "−" + "\n" + dn2 + "\n" + "=";
                                    textBox1.Text = Convert.ToString(res);
                                    break;
                                case "×":
                                    res = dn1 * dn2;
                                    oper = "=";
                                    oper2 = "×";
                                    n2 = true;
                                    label4.Text = dn1 + "\n" + "×" + "\n" + dn2 + "\n" + "=";
                                    textBox1.Text = Convert.ToString(res);
                                    break;
                                case "÷":
                                    if (dn2 != 0)
                                    {
                                        res = dn1 / dn2;
                                        textBox1.Text = Convert.ToString(res);
                                    }
                                    else
                                    {
                                        textBox1.Text = "Деление на ноль невозможно!";
                                        textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                                        error = true;
                                        DisableButtons();
                                    }
                                    oper = "=";
                                    oper2 = "÷";
                                    n2 = true;
                                    label4.Text = dn1 + "\n" + "÷" + "\n" + dn2 + "\n" + "=";
                                    break;
                                case "%":
                                    if (dn2 != 0)
                                    {
                                        res = dn1 % dn2;
                                    }
                                    else
                                    {
                                        res = dn1;
                                    }
                                    oper = "=";
                                    oper2 = "%";
                                    n2 = true;
                                    label4.Text = dn1 + "\n" + "%" + "\n" + dn2 + "\n" + "=";
                                    textBox1.Text = Convert.ToString(res);
                                    break;
                                case "x^y":
                                    if (dn2 % 1 != 0 && dn1 < 0)
                                    {

                                        textBox1.Text = "Неверный ввод";
                                        textBox1.Font = new Font("Verdana", 18, FontStyle.Bold);
                                        error = true;
                                        DisableButtons();
                                    }
                                    else
                                    {
                                        res = Math.Pow(dn1, dn2);
                                        textBox1.Text = Convert.ToString(res);
                                    }
                                    oper = "=";
                                    oper2 = "x^y";
                                    n2 = true;
                                    label4.Text = dn1 + "\n" + "^" + "\n" + dn2 + "\n" + "=";
                                    break;
                                case "LOGyX":
                                    if (dn1 > 0 && dn2 > 0 && dn2 != 1)
                                    {
                                        res = Math.Log(dn1, dn2);
                                        textBox1.Text = Convert.ToString(res);
                                    }
                                    else if (dn2 == 1)
                                    {
                                        textBox1.Text = "Деление на ноль невозможно!";
                                        textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                                        error = true;
                                        DisableButtons();
                                    }
                                    else if (dn1 <= 0 || dn2 <= 0)
                                    {
                                        textBox1.Text = "Неверный ввод";
                                        textBox1.Font = new Font("Verdana", 18, FontStyle.Bold);
                                        error = true;
                                        DisableButtons();
                                    }
                                    oper = "=";
                                    oper2 = "LOGyX";
                                    n2 = true;
                                    label4.Text = dn1 + "\n" + "log" + "\n" + dn2 + "\n" + "=";
                                    break;


                            }

                            break;
                    }
                }
            }




        }


        private void button2_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double res;
            res = Math.PI;
            textBox1.Text = Convert.ToString(res);
            n2 = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double res;
            res = Math.Exp(1);
            textBox1.Text = Convert.ToString(res);
            n2 = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (error == true) { textBox1.Font = new Font("Verdana", 24, FontStyle.Bold); EnableButtons(); error = false; label4.Text = ""; oper2 = ""; }
            textBox1.Text = "0"; oper2 = "";
            if (!n2 && oper == "") { label4.Text = ""; oper2 = ""; }
            if (oper == "=") { label4.Text = ""; oper2 = ""; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (error == true) { textBox1.Font = new Font("Verdana", 24, FontStyle.Bold); EnableButtons(); error = false; }
            textBox1.Text = "0";
            label4.Text = "";
            N1 = "";
            oper = "";
            oper2 = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (error == true) { textBox1.Font = new Font("Verdana", 24, FontStyle.Bold); EnableButtons(); error = false; textBox1.Text = "0"; label4.Text = ""; oper2 = ""; }
            if (oper != "=" && n2 == false)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
                if (textBox1.Text == ""|| textBox1.Text == "-") { textBox1.Text = "0"; oper2 = ""; }
            }

            if (textBox1.Text == "" || oper == "=") { textBox1.Text = "0"; label4.Text = ""; oper2 = ""; }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "sqr(" + dn + ")";
            }
            textBox1.Text = Convert.ToString(res);
            n2 = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn, res = 0;
            dn = Convert.ToDouble(textBox1.Text);
            if (dn == 0)
            {
                textBox1.Text = "Деление на ноль невозможно!";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }
            else
            {
                res = 1 / dn;
                textBox1.Text = Convert.ToString(res);
            }
            n2 = true;
            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "1/(" + dn+ ")";
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Abs(dn);
            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "abs(" + dn + ")";
            }

            textBox1.Text = Convert.ToString(res); n2 = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn, res = 0;
            dn = Convert.ToDouble(textBox1.Text);
            if (dn < 0)
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 18, FontStyle.Bold);
                error = true;
                DisableButtons();
            }
            else
            {
                res = Math.Sqrt(dn);
                textBox1.Text = Convert.ToString(res);
            }
            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "√(" + dn+ ")"; n2 = true;
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            oper2 = "";
            BigInteger dn;
            dn = BigInteger.Parse(textBox1.Text);
            if (dn <= 3248 && dn >= 0)
            {

                textBox1.Text = Convert.ToString(Factorial(dn));

            }
            else if (dn < 0)
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 18, FontStyle.Bold);
                error = true;
                DisableButtons();
            }
            else if (dn > 3248)
            {
                textBox1.Text = "Переполнение";
                textBox1.Font = new Font("Verdana", 25, FontStyle.Bold);
                error = true;
                DisableButtons();
            }
            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "!"; n2 = true;
            }
            else
            {
                label4.Text = "("+dn+")" + "!"; n2 = true;
            }


        }

        private void button22_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double res, dn;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Exp(dn);
            textBox1.Text = Convert.ToString(res);
            label4.Text = "e^(" + dn+")"; n2 = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double res, dn;
            dn = Convert.ToDouble(textBox1.Text);
            if (dn > 0)
            {
                res = Math.Log(dn);
                textBox1.Text = Convert.ToString(res);

            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 18, FontStyle.Bold);
                error = true;
                DisableButtons();
            }
            label4.Text = "ln(" + dn + ")"; n2 = true;
            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "ln(" + dn + ")"; n2 = true;
            }
        }
        private void button33_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double res, dn;
            dn = Convert.ToDouble(textBox1.Text);
            if (dn == 0)
            {
                res = 0;
            }
            else 
            {
                res = (-1) * (dn);
            }
            

            textBox1.Text = Convert.ToString(res);

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "negate(" + dn + ")";
            }
        }
        private void button35_Click(object sender, EventArgs e)
        {
            oper2 = "";
            bool point = false;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ',')
                {
                    point = true;
                    break;
                }
            }
            if (n2)
            {
                n2 = false;

                textBox1.Text = "0,";

            }
            if (oper == "=") { label4.Text = "";oper2 = ""; }
            if (!point)
            {

                if (textBox1.Text != "0,")
                {
                    if (textBox1.Text.Length < 32) 
                    {
                        textBox1.Text += ",";
                    }
                        

                }


            }


        }

        private void button43_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            res = sinus(dn);
            textBox1.Text = Convert.ToString(res);

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "sin(" + dn + ")"; n2 = true;
            }

        }

        private void button45_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            res = cosinus(dn);
            textBox1.Text = Convert.ToString(res);

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "cos(" + dn + ")"; n2 = true;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            if (cosinus(dn) != 0)
            {
                res = sinus(dn) / cosinus(dn);
                textBox1.Text = Convert.ToString(res);
            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "tan(" + dn + ")"; n2 = true;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            if (cosinus(dn) != 0)
            {
                res = 1 / cosinus(dn);
                textBox1.Text = Convert.ToString(res);
            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "sec(" + dn + ")"; n2 = true;
            }
        }


        private void button48_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            if (sinus(dn) != 0)
            {
                res = 1 / sinus(dn);
                textBox1.Text = Convert.ToString(res);
            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }
            n2 = true;

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "csc(" + dn + ")"; n2 = true;
            }

        }
        private void button49_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            if (sinus(dn) != 0)
            {
                res = cosinus(dn) / sinus(dn);
                textBox1.Text = Convert.ToString(res);
            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "cot(" + dn + ")"; n2 = true;
            }

        }
        private void button50_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            res = sinush(dn);
            textBox1.Text = Convert.ToString(res);

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "sinh(" + dn + ")"; n2 = true;
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            res = cosinush(dn);
            textBox1.Text = Convert.ToString(res);

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "cosh(" + dn + ")"; n2 = true;
            }
        }
        private void button52_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            if (cosinush(dn) != 0)
            {
                res = sinush(dn) / cosinush(dn);
                textBox1.Text = Convert.ToString(res);
            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "tanh(" + dn + ")"; n2 = true;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            if (cosinush(dn) != 0)
            {
                res = 1 / cosinush(dn);
                textBox1.Text = Convert.ToString(res);
            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "sech(" + dn + ")"; n2 = true;
            }
        }


        private void button54_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            if (sinush(dn) != 0)
            {
                res = 1 / sinush(dn);
                textBox1.Text = Convert.ToString(res);
            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "csch(" + dn + ")"; n2 = true;
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            oper2 = "";
            double dn = Convert.ToDouble(textBox1.Text), res;
            if (sinush(dn) != 0)
            {
                res = cosinush(dn) / sinush(dn);
                textBox1.Text = Convert.ToString(res);
            }
            else
            {
                textBox1.Text = "Неверный ввод";
                textBox1.Font = new Font("Verdana", 13, FontStyle.Bold);
                error = true;
                DisableButtons();
            }

            if (oper == "+" || oper == "-" || oper == "×" || oper == "÷" || oper == "%" || oper == "x^y" || oper == "LOGyX" || oper == "exp")
            {
                //label4.Text += dn + "√"; n2 = true;
            }
            else
            {
                label4.Text = "coth(" + dn + ")"; n2 = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button37.Enabled = false;
            button38.Enabled = false;
            button42.Enabled = false;
            button2.Visible = false;
            button3.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button17.Visible = false;
            button22.Visible = false;
            button27.Visible = false;
            button32.Visible = false;
            button44.Visible = false;
            panel3.Visible = false;
            button4.Location = new Point(81, 197);
            button4.Size = new Size(79, 44);
            button5.Location = new Point(161, 197);
            button5.Size = new Size(79, 44);
            button6.Location = new Point(241, 197);
            button6.Size = new Size(79, 44);
            button7.Location = new Point(81, 242);
            button7.Size = new Size(79, 44);
            button8.Location = new Point(1, 242);
            button8.Size = new Size(79, 44);
            button12.Location = new Point(161, 242);
            button12.Size = new Size(79, 44);
            button16.Location = new Point(241, 242);
            button16.Size = new Size(79, 44);
            button18.Location = new Point(1, 287);
            button18.Size = new Size(79, 44);
            button19.Location = new Point(81, 287);
            button19.Size = new Size(79, 44);
            button20.Location = new Point(161, 287);
            button20.Size = new Size(79, 44);
            button21.Location = new Point(241, 287);
            button21.Size = new Size(79, 44);
            button23.Location = new Point(1, 332);
            button23.Size = new Size(79, 44);
            button24.Location = new Point(81, 332);
            button24.Size = new Size(79, 44);
            button25.Location = new Point(161, 332);
            button25.Size = new Size(79, 44);
            button26.Location = new Point(241, 332);
            button26.Size = new Size(79, 44);
            button28.Location = new Point(1, 377);
            button28.Size = new Size(79, 44);
            button29.Location = new Point(81, 377);
            button29.Size = new Size(79, 44);
            button30.Location = new Point(161, 377);
            button30.Size = new Size(79, 44);
            button31.Location = new Point(241, 377);
            button31.Size = new Size(79, 44);
            button33.Location = new Point(1, 422);
            button33.Size = new Size(79, 44);
            button34.Location = new Point(81, 422);
            button34.Size = new Size(79, 44);
            button35.Location = new Point(161, 422);
            button35.Size = new Size(79, 44);
            button36.Location = new Point(241, 422);
            button36.Size = new Size(79, 44);
            button11.Location = new Point(1, 197);
            button11.Size = new Size(79, 44);
            panel1.Width = 0;
            button56.Image = Properties.Resources.engineeringcalc;
            label1.Text = "Обычный";
            button56.Text = "   Инженерный";
            iscommon = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menutimer_Tick(object sender, EventArgs e)
        {
            if (menuexpand)
            {

                panel1.Width -= 15;

                if (panel1.Width == panel1.MinimumSize.Width)
                {
                    menuexpand = false;
                    menutimer.Stop();
                }
            }
            else
            {

                panel1.Width += 15;

                if (panel1.Width == panel1.MaximumSize.Width)
                {
                    menuexpand = true;
                    menutimer.Stop();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menutimer.Start();
        }

        private void menutimer_Tick_1(object sender, EventArgs e)
        {
            if (menuexpand)
            {

                panel1.Width -= 15;

                if (panel1.Width == panel1.MinimumSize.Width)
                {

                    menuexpand = false;
                    menutimer.Stop();
                }
            }
            else
            {

                panel1.Width += 15;

                if (panel1.Width == panel1.MaximumSize.Width)
                {
                    menuexpand = true;
                    menutimer.Stop();
                }
            }
        }



        private void trigonomtimer_Tick(object sender, EventArgs e)
        {
            if (trigonomexpand)
            {
                panel3.Height -= 15;
                if (panel3.Height == panel3.MinimumSize.Height)
                {
                    trigonomexpand = false;
                    trigonomtimer.Stop();
                }
            }
            else
            {
                panel3.Height += 15;
                if (panel3.Height == panel3.MaximumSize.Height)
                {
                    trigonomexpand = true;
                    trigonomtimer.Stop();
                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            trigonomtimer.Start();
            if (trigonomisgrey) { button44.ForeColor = Color.Black; trigonomisgrey = false; }
            else { button44.ForeColor = Color.Gray; trigonomisgrey = true; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button42_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(m), "Число сохранненое в памяти", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (iscommon)
            {

                button2.Visible = true;
                button3.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button17.Visible = true;
                button22.Visible = true;
                button27.Visible = true;
                button32.Visible = true;
                button44.Visible = true;
                panel3.Visible = true;
                button4.Location = new Point(129, 230);
                button4.Size = new Size(63, 31);
                button5.Location = new Point(193, 230);
                button5.Size = new Size(63, 31);
                button6.Location = new Point(257, 230);
                button6.Size = new Size(63, 31);
                button7.Location = new Point(1, 265);
                button7.Size = new Size(63, 31);
                button8.Location = new Point(65, 265);
                button8.Size = new Size(63, 31);
                button12.Location = new Point(1, 299);
                button12.Size = new Size(63, 31);
                button16.Location = new Point(257, 299);
                button16.Size = new Size(63, 31);
                button18.Location = new Point(65, 333);
                button18.Size = new Size(63, 31);
                button19.Location = new Point(129, 333);
                button19.Size = new Size(63, 31);
                button20.Location = new Point(193, 333);
                button20.Size = new Size(63, 31);
                button21.Location = new Point(257, 333);
                button21.Size = new Size(63, 31);
                button23.Location = new Point(65, 367);
                button23.Size = new Size(63, 31);
                button24.Location = new Point(129, 367);
                button24.Size = new Size(63, 31);
                button25.Location = new Point(193, 367);
                button25.Size = new Size(63, 31);
                button26.Location = new Point(257, 367);
                button26.Size = new Size(63, 31);
                button28.Location = new Point(65, 401);
                button28.Size = new Size(63, 31);
                button29.Location = new Point(129, 401);
                button29.Size = new Size(63, 31);
                button30.Location = new Point(193, 401);
                button30.Size = new Size(63, 31);
                button31.Location = new Point(257, 401);
                button31.Size = new Size(63, 31);
                button33.Location = new Point(65, 435);
                button33.Size = new Size(63, 31);
                button34.Location = new Point(129, 435);
                button34.Size = new Size(63, 31);
                button35.Location = new Point(193, 435);
                button35.Size = new Size(63, 31);
                button36.Location = new Point(257, 435);
                button36.Size = new Size(63, 31);
                button11.Location = new Point(257, 265);
                button11.Size = new Size(63, 31);
                panel1.Width = 0;
                panel3.Height = 0;
                if (!inmem) 
                {
                    m = 0;
                    button37.Enabled = false;
                    button38.Enabled = false;
                    button42.Enabled = false;
                }
                button44.Location = new Point(1, 197);
                menuexpand = false;
                label1.Text = "Инженерный";
                button56.Text = "   Обычный";
                button56.Image = Properties.Resources.commoncalc;
                iscommon = false;
                textBox1.Text = "0";
                label4.Text = "";
                N1 = "";
                oper = "";
                oper2 = "";
                if (error == true) { textBox1.Font = new Font("Verdana", 24, FontStyle.Bold); EnableButtons(); error = false; }
            }
            else
            {

                button2.Visible = false;
                button3.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button17.Visible = false;
                button22.Visible = false;
                button27.Visible = false;
                button32.Visible = false;
                button44.Visible = false;
                panel3.Visible = false;
                button4.Location = new Point(81, 197);
                button4.Size = new Size(79, 44);
                button5.Location = new Point(161, 197);
                button5.Size = new Size(79, 44);
                button6.Location = new Point(241, 197);
                button6.Size = new Size(79, 44);
                button7.Location = new Point(81, 242);
                button7.Size = new Size(79, 44);
                button8.Location = new Point(1, 242);
                button8.Size = new Size(79, 44);
                button12.Location = new Point(161, 242);
                button12.Size = new Size(79, 44);
                button16.Location = new Point(241, 242);
                button16.Size = new Size(79, 44);
                button18.Location = new Point(1, 287);
                button18.Size = new Size(79, 44);
                button19.Location = new Point(81, 287);
                button19.Size = new Size(79, 44);
                button20.Location = new Point(161, 287);
                button20.Size = new Size(79, 44);
                button21.Location = new Point(241, 287);
                button21.Size = new Size(79, 44);
                button23.Location = new Point(1, 332);
                button23.Size = new Size(79, 44);
                button24.Location = new Point(81, 332);
                button24.Size = new Size(79, 44);
                button25.Location = new Point(161, 332);
                button25.Size = new Size(79, 44);
                button26.Location = new Point(241, 332);
                button26.Size = new Size(79, 44);
                button28.Location = new Point(1, 377);
                button28.Size = new Size(79, 44);
                button29.Location = new Point(81, 377);
                button29.Size = new Size(79, 44);
                button30.Location = new Point(161, 377);
                button30.Size = new Size(79, 44);
                button31.Location = new Point(241, 377);
                button31.Size = new Size(79, 44);
                button33.Location = new Point(1, 422);
                button33.Size = new Size(79, 44);
                button34.Location = new Point(81, 422);
                button34.Size = new Size(79, 44);
                button35.Location = new Point(161, 422);
                button35.Size = new Size(79, 44);
                button36.Location = new Point(241, 422);
                button36.Size = new Size(79, 44);
                button11.Location = new Point(1, 197);
                button11.Size = new Size(79, 44);
                panel1.Width = 0;
                if (!inmem)
                {
                    m = 0;
                    button37.Enabled = false;
                    button38.Enabled = false;
                    button42.Enabled = false;
                }
                menuexpand = false;
                label1.Text = "Обычный";
                button56.Text = "   Инженерный";
                button56.Image = Properties.Resources.engineeringcalc;
                iscommon = true;
                textBox1.Text = "0";
                label4.Text = "";
                N1 = "";
                oper = "";
                oper2 = "";
                if (error == true) { textBox1.Font = new Font("Verdana", 24, FontStyle.Bold); EnableButtons(); error = false; oper2 = ""; }
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            if (panel1.Width != panel1.MinimumSize.Width)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
                button29.Enabled = false;
                button30.Enabled = false;
                button31.Enabled = false;
                button32.Enabled = false;
                button33.Enabled = false;
                button34.Enabled = false;
                button35.Enabled = false;
                button36.Enabled = false;
                button37.Enabled = false;
                button38.Enabled = false;
                button39.Enabled = false;
                button40.Enabled = false;
                button41.Enabled = false;
                button42.Enabled = false;
                button43.Enabled = false;
                button44.Enabled = false;
                button45.Enabled = false;
                button46.Enabled = false;
                button47.Enabled = false;
                button48.Enabled = false;
                button49.Enabled = false;
                button50.Enabled = false;
                button51.Enabled = false;
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                textBox1.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;
                button24.Enabled = true;
                button25.Enabled = true;
                button26.Enabled = true;
                button27.Enabled = true;
                button28.Enabled = true;
                button29.Enabled = true;
                button30.Enabled = true;
                button31.Enabled = true;
                button32.Enabled = true;
                button33.Enabled = true;
                button34.Enabled = true;
                button35.Enabled = true;
                button36.Enabled = true;
                button37.Enabled = true;
                button38.Enabled = true;
                button39.Enabled = true;
                button40.Enabled = true;
                button41.Enabled = true;
                button42.Enabled = true;
                button43.Enabled = true;
                button44.Enabled = true;
                button45.Enabled = true;
                button46.Enabled = true;
                button47.Enabled = true;
                button48.Enabled = true;
                button49.Enabled = true;
                button50.Enabled = true;
                button51.Enabled = true;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                textBox1.Enabled = true;
                if (error == true) { DisableButtons(); }
            }
        }




        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_FontChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 0 && textBox1.Text.Length <= 18) { textBox1.Font = new Font("Verdana", 18, FontStyle.Bold); }
            if (textBox1.Text.Length == 19) { textBox1.Font = new Font("Verdana", 17, FontStyle.Bold); }
            if (textBox1.Text.Length == 20) { textBox1.Font = new Font("Verdana", 16, FontStyle.Bold); }
            if (textBox1.Text.Length == 21 || textBox1.Text.Length == 22) { textBox1.Font = new Font("Verdana", 15, FontStyle.Bold); }
            if (textBox1.Text.Length >= 23 && textBox1.Text.Length <= 26) { textBox1.Font = new Font("Verdana", 13, FontStyle.Bold); }
            if (textBox1.Text.Length >= 27 && textBox1.Text.Length <= 28) { textBox1.Font = new Font("Verdana", 12, FontStyle.Bold); }
            if (textBox1.Text.Length >= 29 && textBox1.Text.Length <= 32) { textBox1.Font = new Font("Verdana", 10, FontStyle.Bold); }




            if (textBox1.Text.Length > 32)
            {

                textBox1.Text = BigInteger.Parse(textBox1.Text).ToString("0.###########E+000");
            }

            if (textBox1.Text == "∞")
            {
                textBox1.Text = "Переполнение";
                textBox1.Font = new Font("Verdana", 25, FontStyle.Bold);
                error = true;
                DisableButtons();
            }


        }

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (n2 == true)
        //    {
        //        n2 = false;

        //        textBox1.Text = "";
        //        if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
        //            if (textBox1.Text == "0")
        //            {
        //                textBox1.Text = "";
        //                return;
        //            }
        //            else { return; }


        //        if (e.KeyChar == ',')
        //        {
        //            bool point = false;
        //            for (int i = 0; i < textBox1.Text.Length; i++)
        //            {
        //                if (textBox1.Text[i] == ',')
        //                {
        //                    point = true;
        //                    break;
        //                }
        //            }
        //            if (!point) { return; }
        //        }
        //        e.Handled = true;
        //    }
        //    if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
        //        if (textBox1.Text == "0")
        //        {
        //            textBox1.Text = "";
        //            return;
        //        }
        //        else { return; }

        //    if (Char.IsControl(e.KeyChar))
        //    {
        //        if (e.KeyChar == (char)Keys.Back)
        //        {
        //            //if (textBox1.Text == "" || oper == "=") 
        //            //{
        //            //    textBox1.Text = "0"; label4.Text = ""; 

        //            //}
        //            //else 
        //            //{
        //            //    return;
        //            //}

        //        }
        //        if (e.KeyChar == (char)Keys.Enter)
        //        {
        //            button36.Focus();
        //        }
        //    }
        //    if (e.KeyChar == ',')
        //    {
        //        bool point = false;
        //        for (int i = 0; i < textBox1.Text.Length; i++)
        //        {
        //            if (textBox1.Text[i] == ',')
        //            {
        //                point = true;
        //                break;
        //            }
        //        }
        //        if (!point) { return; }
        //    }
        //    e.Handled = true;
        //}

        private void button37_Click(object sender, EventArgs e)
        {
            m = 0;
            inmem = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button42.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(m);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            inmem = true;
            m += Convert.ToDouble(textBox1.Text);
            button37.Enabled = true;
            button38.Enabled = true;
            button42.Enabled = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            inmem = true;
            m -= Convert.ToDouble(textBox1.Text);
            button37.Enabled = true;
            button38.Enabled = true;
            button42.Enabled = true;

        }

        private void button41_Click(object sender, EventArgs e)
        {
            inmem = true;
            m = Convert.ToDouble(textBox1.Text);
            button37.Enabled = true;
            button38.Enabled = true;
            button42.Enabled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyValue)
            {
                case (char)Keys.Back:
                    button6.PerformClick();
                    break;
                case (char)Keys.Enter:
                    button36.PerformClick();
                    break;
                case (char)Keys.Oemcomma:
                    button35.PerformClick();
                    break;
                case (char)Keys.Divide:
                    button16.PerformClick();
                    break;
                case (char)Keys.Multiply:
                    button21.PerformClick();
                    break;
                case (char)Keys.Subtract:
                    button26.PerformClick();
                    break;
                case (char)Keys.Add:
                    button31.PerformClick();
                    break;
                case (char)Keys.Decimal:
                    button35.PerformClick();
                    break;
                case '0':
                    button34.PerformClick();
                    break;
                case '1':
                    button28.PerformClick();
                    break;
                case '2':
                    button29.PerformClick();
                    break;
                case '3':
                    button30.PerformClick();
                    break;
                case '4':
                    button23.PerformClick();
                    break;
                case '5':
                    button24.PerformClick();
                    break;
                case '6':
                    button25.PerformClick();
                    break;
                case '7':
                    button18.PerformClick();
                    break;
                case '8':
                    button19.PerformClick();
                    break;
                case '9':
                    button20.PerformClick();
                    break;

                case (char)Keys.NumPad0:
                    button34.PerformClick();
                    break;
                case (char)Keys.NumPad1:
                    button28.PerformClick();
                    break;
                case (char)Keys.NumPad2:
                    button29.PerformClick();
                    break;
                case (char)Keys.NumPad3:
                    button30.PerformClick();
                    break;
                case (char)Keys.NumPad4:
                    button23.PerformClick();
                    break;
                case (char)Keys.NumPad5:
                    button24.PerformClick();
                    break;
                case (char)Keys.NumPad6:
                    button25.PerformClick();
                    break;
                case (char)Keys.NumPad7:
                    button18.PerformClick();
                    break;
                case (char)Keys.NumPad8:
                    button19.PerformClick();
                    break;
                case (char)Keys.NumPad9:
                    button20.PerformClick();
                    break;

            }
        }

        
    }
}
