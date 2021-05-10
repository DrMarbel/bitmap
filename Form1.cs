using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitmapGeneraterGUI
{
    public partial class Form1 : Form
    {
        List<PictureBox> tiles = new List<PictureBox>();
        int mapWidth = 16;
        int mapHeight = 16;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < mapHeight * mapWidth; i++)
            {
                tiles.Add(new PictureBox());
                tiles[tiles.Count - 1].Size = new Size(16, 16);
                tiles[tiles.Count - 1].Location = new Point(200,-50);
                tiles[tiles.Count - 1].Location = new Point((i / mapWidth) * 16, (i % mapWidth) * 16);
                this.Controls.Add(tiles[tiles.Count - 1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("*Map Generated*");
            int[,] arr = StandinWorldGenerator();
            /*string output = "";
            for (int i = 0; i < arr.Length && i < 1; i++)
            {
                for (int a = 0; a < arr.Length && a < 1; a++)
                {
                    output += Convert.ToString(arr[0,0]);
                }
            }
            label1.Text = output;
            */
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    switch (arr[x, y])
                    {
                        case 0:
                            tiles[x * mapWidth + y].ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\sand.png";
                            break;
                        case 1:
                            tiles[x * mapWidth + y].ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\water.png";
                            break;
                        case 2:
                            tiles[x * mapWidth + y].ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\grass.png";
                            break;
                        case 3:
                            tiles[x * mapWidth + y].ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\stone.png";
                            break;
                        case 4:
                            tiles[x * mapWidth + y].ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\grass2.png";
                            break;
                        default:
                            break;
                    }
                }
            }


            // label1.Text = Convert.ToString(arr[0,0]);
            // label1.Text = output;
            
            // WORKS!
            /*
            if (arr[0,0] == 0)
            {
                // label1.Text = "TEST";
                label2.Text = "*Sand*";

                pictureBox1.ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\sand.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            } else if (arr[0, 0] == 1) {
                label2.Text = "*Water*";

                pictureBox1.ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\water.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (arr[0, 0] == 2)
            {
                label2.Text = "*Grass*";

                pictureBox1.ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\grass.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (arr[0, 0] == 3)
            {
                label2.Text = "*Stone*";

                pictureBox1.ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\stone.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (arr[0, 0] == 4)
            {
                label2.Text = "*Grass 2*";

                pictureBox1.ImageLocation = "C:\\Users\\Martin\\Pictures\\Saved Pictures\\Tiles\\grass2.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            */
        }

        int[,] StandinWorldGenerator()
        {
            int col = this.mapWidth;
            int rowThing = this.mapHeight;
            Random random = new Random();
            int[,] Output = new int[col, rowThing];
            for (int collumn = 0; collumn < col; collumn++)
            {
                for (int row = 0; row < rowThing; row++)
                {
                    Output[row, collumn] = random.Next(0, 5);
                }
            }
            return Output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confrim = MessageBox.Show("Do you really want to leave?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confrim == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
