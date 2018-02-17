using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Service
{
    public partial class Form1 : Form
    {
        Letalisce letalisce;
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();
            letalisce = new Letalisce();
            button3.Enabled = false;

            width = Math.Max(groupBox3.Width, groupBox3.Width);
            height = Math.Max(groupBox3.Height, groupBox3.Height);

            // Resize the control to the exact size to display the page. Also, make sure scroll bars are disabled
            webBrowser1.Width = width;
            webBrowser1.Height = height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.WebService services = new localhost.WebService();
            try
            {
                if (listView1.SelectedItems != null)
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Letalisce));
                    using (StringReader reader = new StringReader(services.GetLetalisceByCode(listView1.SelectedItems[0].Text)))
                    {
                        letalisce = (Letalisce)deserializer.Deserialize(reader);
                    }
                }
                webBrowser1.DocumentText = @"<html> <body> <iframe src=" + letalisce.Map + " style='Height:" + height+ "; Width:" +width +"'></iframe></body></html>";
                webBrowser1.ScriptErrorsSuppressed = true;
                textBox2.Text = letalisce.Opis;
            }
            catch
            {
                MessageBox.Show("Izberi letališče!");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string[] list;
            localhost.WebService services = new localhost.WebService();
            try
            {
                list = services.GetLeltalisceDrzava(textBox1.Text);
                foreach (string s in list)
                {
                    listView1.Items.Add(s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ne najdem države! ");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(letalisce.Glas);
            SoundPlayer sound = new SoundPlayer(ms);
            sound.LoadAsync();
            sound.Play();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
