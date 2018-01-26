using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refleksja
{

    public partial class Form1 : Form
    {
        public static int parameter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String folderPath = null;
            List<String> classPaths = new List<string>();
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                foreach (String item in Directory.GetFiles(folderPath))
                {
                    classPaths.Add(item);
                }
                Jfk.Prism.Program.Main(classPaths.ToArray());
                listBox1.Items.Clear();

                foreach (var type in Jfk.Prism.Program.assignableClasses)
                {
                    listBox1.Items.Add(type.ToString());
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RUN.Enabled = true;
            Info.Text = Jfk.Prism.Program.classDescriptionAtributes.ElementAt(listBox1.SelectedIndex);
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void RUN_Click(object sender, EventArgs e)
        {
            Type type = Jfk.Prism.Program.assignableClasses.ElementAt(listBox1.SelectedIndex);
            Jfk.Prism.ICallable callable = (Jfk.Prism.ICallable) Activator.CreateInstance(type);
            Result.Text = callable.Count(parameter).ToString();
        }

        private void argument_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(argument.Text, out parameter);
        }
    }
}
