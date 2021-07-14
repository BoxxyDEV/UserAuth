using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace UserAuth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ("boxxy:123" == UsernameText.Text + ":" + PasswordText.Text)
            {
                MessageBox.Show("Signed in as " + UsernameText.Text, UsernameText.Text);
            }
            if ("default:password" == UsernameText.Text + ":" + PasswordText.Text)
            {
                MessageBox.Show("Checking Account " + UsernameText.Text, UsernameText.Text);
                Thread.Sleep(5000);
                System.Diagnostics.Process.Start("https://youtu.be/dQw4w9WgXcQ?t=17");
                Thread.Sleep(2000);
                MessageBox.Show("You've Just been rick rolled", UsernameText.Text);
            }
            else
            {
                MessageBox.Show("Username and Password is Incorrect");
                MessageBox.Show("Make sure capitalization is correct");
            }    
            }
        }
}
