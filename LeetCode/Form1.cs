using ConsoleSolution.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExec_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic p1 = ConvertToType(cmbType1, txtVal1);
                dynamic p2 = ConvertToType(cmbType2, txtVal2);
                dynamic p3 = ConvertToType(cmbType3, txtVal3);
                dynamic p4 = ConvertToType(cmbType4, txtVal4);

                string result = "";
                result = new Solution992().SubarraysWithKDistinct(p1, p2).ToString();
                rtbConsole.AppendColorText("输出：" + result);
            }
            catch (Exception ex)
            {
                rtbConsole.AppendColorText(ex.Message, "Red");
            }


        }

        /// <summary>
        /// 转换参数类型值
        /// </summary>
        /// <param name="typeControl"></param>
        /// <param name="valControl"></param>
        /// <returns></returns>
        public dynamic ConvertToType(ComboBox typeControl, TextBox valControl)
        {
            dynamic result = null;
            if (typeControl.SelectedItem.ToString() == "String" || typeControl.SelectedItem.ToString() == "")
            {
                result = valControl.Text;
            }
            else if (typeControl.SelectedItem.ToString() == "Int")
            {
                int r;
                if (int.TryParse(valControl.Text.Trim(), out r))
                {
                    result = r;
                }
                else
                {
                    rtbConsole.AppendColorText($"\"{valControl.Text}\"不能转为int");
                }
            }
            else if (typeControl.SelectedItem.ToString() == "Array")
            {
                if (valControl.Text.StartsWith("[") && valControl.Text.EndsWith("]"))
                {
                    var arr = valControl.Text.Substring(1, valControl.Text.Length - 2).Split(',');
                    if (arr.All(s => int.TryParse(s, out int a)))
                    {
                        //result = arr.Cast<int>().ToArray();
                        result = arr.Select(m => Convert.ToInt32(m)).ToArray();
                    }
                    else
                    {
                        result = arr;
                    }
                }
                else
                {
                    rtbConsole.AppendColorText($"\"{valControl.Text}\"不能转为Array");
                }

            }
            else if (typeControl.SelectedItem.ToString() == "Double")
            {
                double r;
                if (double.TryParse(valControl.Text.Trim(), out r))
                {
                    result = r;
                }
                else
                {
                    rtbConsole.AppendColorText($"\"{valControl.Text}\"不能转为double");
                }
            }


            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbType1.SelectedIndex = cmbType2.SelectedIndex = cmbType3.SelectedIndex = cmbType4.SelectedIndex = 0;
        }
    }
}
