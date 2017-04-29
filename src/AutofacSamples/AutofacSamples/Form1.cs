using System;
using System.Windows.Forms;
using Autofac;
using AutofacSamples.Implement;
using AutofacSamples.Protocol;

namespace AutofacSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            AutofacConfig.Instance.Register();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFlying bird = AutofacConfig.Instance.Container.ResolveNamed<IFlying>(nameof(Swallow));

            this.textBox1.Text += bird.Fly() + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IFlying bird = AutofacConfig.Instance.Container.ResolveNamed<IFlying>(nameof(Ostrich));

            this.textBox1.Text += bird.Fly() + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bird = AutofacConfig.Instance.Container.Resolve<Dog>();

            this.textBox1.Text += bird.Walk() + "\r\n";
        }
    }
}