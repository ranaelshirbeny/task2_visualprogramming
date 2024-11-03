using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace task2
{
    public partial class Form1 : Form
    {
      
        private List<string> imagepaths;
        private int currentIndex = 2;
        public Form1()
        {
            InitializeComponent();
            imagepaths = new List<string>
          {
                @"E:\\Myproject_HTML\30.jpg",
               @"E:\\Myproject_HTML\40.jpg",
               @"E:\\Myproject_HTML\50.jpg",
               @"E:\\Myproject_HTML\60.jpg",
               @"E:\\Myproject_HTML\70.jpg",
               @"E:\\Myproject_HTML\80.jpg",
               @"E:\\Myproject_HTML\90.jpg"


          };
            DisplayImage();
        }

    

        private void DisplayImage()
        {
            
              if(imagepaths.Count > 0)
            {
                pictureBox1.ImageLocation = imagepaths[currentIndex];
                
            }
            
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayImage();
                }
            else
            {
                MessageBox.Show("this the first pictue");
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (currentIndex < imagepaths.Count - 1)
            {
                currentIndex++;
                DisplayImage();
            }
        }
        
    }
}
