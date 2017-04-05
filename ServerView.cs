using System;
using System.Windows.Forms;

namespace MissionPlanner.TcpStream
{

    public partial class ServerView : Form
    {
    
        public ServerView()
        {
            InitializeComponent();
        }
        
        private void chargeIP(object sender, EventArgs e)
        {
            try
            {
                TcpStreamPlugin.InitTimer();
                TcpStreamPlugin.setrealTime();
            }
            catch (Exception a)
            {
                Console.WriteLine(a.ToString());
            }

            try
            {
                TcpStreamPlugin.serverPort = Int32.Parse(this.textBox3.Text);
                TcpStreamPlugin.serverWindow = this;
                TcpStreamPlugin.changeIP(this.textBox1.Text, this.textBox2.Text);
            }
            catch(Exception a)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public Label getConnectionIndice()
        {
            return ConnectionIndice;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServerView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TcpStreamPlugin.IPLoaded)
            {
                try
                {
                    TcpStreamPlugin.client.Close();
                }
                catch(Exception ex) { }
            }
        }
        
        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerView_MouseMove(object sender, MouseEventArgs e)
        {
            if(!TcpStreamPlugin.IPLoaded)
            {
                ConnectionIndice.Text = "Disconnected";
                ConnectionIndice.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ConnectionIndice.Text = "Connected";
                ConnectionIndice.ForeColor = System.Drawing.Color.Green;
            }
        }
        
    }
}
