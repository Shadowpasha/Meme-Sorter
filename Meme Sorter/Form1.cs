using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;
using System.Diagnostics;
using MetroFramework;
using MetroFramework.Forms;
namespace Meme_Sorter
{

    public partial class Form1 : MetroForm
    {
        string[] filesjpg;
        string[] filespng;
        string[] filesjpeg;
        string[] filesgif;
        string[] filesvid;
        string[] filesall;
        int counter = 0;
        string[] shatayem = { "5awal", "Metnak", "Sharmot", "Retard" ,"3ayel ya Metnak", "nigga" , "Kosomak" , "3el2" , "Teez", "Metayz", "Bdan", "Abo Sha5a","Wese5","Labwa", "Ablah"};
        String A = "",B = "",C = "",D = "",E = "",F = "",G = "",H = "",I = "",J = "",K = "",L = "",M = "",N = "",O = "",P = "",Q = "",R = "",S = "",T = "",U = "",V = "",W = "",X = "",Y = "",Z = "";

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Remind.txt"));
            //Read the first line of text
            lastplace = sr.ReadLine();
            //Continue to read until you reach end of file

            //close the file
            sr.Close();
            Console.ReadLine();
            Random random = new Random();
            int sheytema = random.Next(14);
            MessageBox.Show("A2a5er raqm wa2ft 3ando kan " + lastplace + " ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      
    

      
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                button4.PerformClick();
                button4.Focus();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label4.Text != "")
            {
                counter++;
            }
            if(counter == 200)
            {
                label4.Text = "";
                timer1.Enabled = false;
            }
        }

        String Lastfile,Lastmeme, lastplace;

        DialogResult result, resultA, resultB, resultC, resultD, resultE, resultF , resultG, resultH, resultI, resultJ, resultK, resultL, resultM, resultN, resultO, resultP, resultQ, resultR, resultS, resultT, resultU, resultV, resultW, resultX, resultY,resultZ;

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(System.IO.Path.Combine(Lastfile, Lastmeme));
                button4.PerformClick();
            }
            catch
            {
                Random random = new Random();
                int sheytema = random.Next(14);
                MessageBox.Show("Enta ma3meltsh sort le 7aga ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) - 1 <= filesall.Length)
            {
                x = int.Parse(textBox2.Text) - 1;
                pictureBox1.Image = new Bitmap(filesall[x]);
                current_image = new Bitmap(filesall[x]);
                label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x+1).ToString()  + Path.GetExtension(filesall[x]);
                button5.Focus();
            }
            else 
            {
                Random random = new Random();
                int sheytema = random.Next(14);
                MessageBox.Show("Choose raqam goa el file ya " + shatayem[sheytema] , "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        String Folder1 = "", Folder2 = "";
        bool fileready = false;
        static int x = 0;
        Bitmap current_image;



        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            //try
            ////{
            ////    //Pass the file path and file name to the StreamReader constructor
            ////    StreamReader sr = new StreamReader((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Remind.txt"));
            ////    //Read the first line of text
            ////    lastplace = sr.ReadLine();
            ////    //Continue to read until you reach end of file

            ////    //close the file
            ////    sr.Close();
            ////    Console.ReadLine();
            ////    Random random = new Random();
            ////    int sheytema = random.Next(14);
            ////    MessageBox.Show("A2a5er raqm wa2ft 3ando kan " + lastplace + " ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //catch { }
        }

        private void choose_folder_Click(object sender, EventArgs e)
        {
            result = Choosefolder.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(Choosefolder.SelectedPath))
            {
                label3.Text = new DirectoryInfo(Choosefolder.SelectedPath).Name;
                filesjpg = Directory.GetFiles(Choosefolder.SelectedPath, "*.jpg");
                filespng = Directory.GetFiles(Choosefolder.SelectedPath, "*.png");
                filesjpeg = Directory.GetFiles(Choosefolder.SelectedPath, "*.jpeg");
                filesgif = Directory.GetFiles(Choosefolder.SelectedPath, "*.gif");
                filesvid = Directory.GetFiles(Choosefolder.SelectedPath, "*.mp4");
                filesall = new string[filesjpg.Length + filespng.Length + filesjpeg.Length + filesgif.Length + filesvid.Length];
                Array.Copy(filesjpg, filesall, filesjpg.Length);
                Array.Copy(filesjpeg, 0, filesall, filesjpg.Length, filesjpeg.Length);
                Array.Copy(filespng, 0, filesall, filesjpg.Length + filesjpeg.Length, filespng.Length);
                Array.Copy(filesgif, 0, filesall, filesjpg.Length + filesjpeg.Length + filespng.Length, filesgif.Length);
                Array.Copy(filesvid, 0, filesall, filesjpg.Length + filesjpeg.Length + filespng.Length + filesgif.Length, filesvid.Length);

                for (x = 0; x < filesall.Length; x++)
                {
                    if (Path.GetExtension(filesall[x]) == ".mp4")
                    {
                        pictureBox1.Visible = false;
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = filesall[x];
                        fileready = true;
                        break;
                    }
                    else
                    {
                        pictureBox1.Visible = true;
                        axWindowsMediaPlayer1.Visible = false;
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        pictureBox1.Image = new Bitmap(filesall[x]);
                        current_image = new Bitmap(filesall[x]);
                        fileready = true;
                        break;
                    }

                }
                label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fileready)
            {

                if (x + 1 < filesall.Length)
                {
                    if (Path.GetExtension(filesall[x + 1]) == ".mp4")
                    {
                        pictureBox1.Visible = false;
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = filesall[x + 1];
                        x++;
                    }
                    else
                    {
                        pictureBox1.Visible = true;
                        axWindowsMediaPlayer1.Visible = false;
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        pictureBox1.Image = new Bitmap(filesall[x + 1]);
                        current_image = new Bitmap(filesall[x + 1]);
                        x++;
                    }
                    try
                    {
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Remind.txt"));
                        //Write a line of text
                        sw.WriteLine(x.ToString());
                        sw.Close();
                    }
                    catch
                    {
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("can't access documents ya 5awal " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Random random = new Random();
                    int sheytema = random.Next(14);
                    MessageBox.Show("Dah a5er 7aga fel file ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();

            }
             else {
                    Random random = new Random();
                    int sheytema = random.Next(14);
                    MessageBox.Show("Choose File el awel ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
        



        private void button4_Click(object sender, EventArgs e)
        {
            if (fileready)
            {

                if (x != 0)
                {
                    if (Path.GetExtension(filesall[x - 1]) == ".mp4")
                    {
                        pictureBox1.Visible = false;
                        axWindowsMediaPlayer1.Visible = true;
                        axWindowsMediaPlayer1.URL = filesall[x - 1];
                        x--;
                    }
                    else
                    {
                        pictureBox1.Visible = true;
                        axWindowsMediaPlayer1.Visible = false;
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        pictureBox1.Image = new Bitmap(filesall[x - 1]);
                        current_image = new Bitmap(filesall[x - 1]);
                        x--;
                    }
                    try
                    {
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Remind.txt"));
                        //Write a line of text
                        sw.WriteLine(x.ToString());
                        sw.Close();
                    }
                    catch
                    {
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("can't access documents ya 5awal " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Random random = new Random();
                    int sheytema = random.Next(14);
                    MessageBox.Show("Deh awel 7aga fel file ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
            }
            else {
                Random random = new Random();
                int sheytema = random.Next(14);
                MessageBox.Show("Choose File el awel ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (Folder2 != "")
            {
                String destFile = System.IO.Path.Combine(Folder2, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                File.Copy(filesall[x], destFile, true);
                Lastfile = Folder2;
                Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                button3.PerformClick();
               
            }
            else
            {
                try
                {
                    result = sort1.ShowDialog();
                    Folder2 = sort1.SelectedPath;
                    button1.Text = new DirectoryInfo(Folder2).Name;
                }
                catch {
                    Folder2 = "";
                    Random random = new Random();
                    int sheytema = random.Next(14);
                    MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (result == DialogResult.OK)
            {
                label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Folder1 != "")
            {
                String destFile = System.IO.Path.Combine(Folder1, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                File.Copy(filesall[x], destFile, true);
                Lastfile = Folder1;
                Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                button3.PerformClick();
                
            }
            else
            {
                try
                {
                    result =  sort1.ShowDialog();
                    Folder1 = sort1.SelectedPath;
                    button2.Text = new DirectoryInfo(Folder1).Name;
                }
                catch { Folder1 = "";
                    Random random = new Random();
                    int sheytema = random.Next(14);
                    MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (result == DialogResult.OK)
            {
                label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
            }
           
        }

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (A == "")
                {
                    try
                    {
                        resultA = sort1.ShowDialog();
                        A = sort1.SelectedPath;
                    }
                    catch
                    {
                        A = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (resultA == DialogResult.OK || A != "")
                {
                    String destFile = System.IO.Path.Combine(A, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    Lastfile = A;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(A).Name;
                }
            }
            if (e.KeyCode == Keys.B)
            {
                if (B == "")
                {
                    try
                    {
                        resultB = sort1.ShowDialog();
                        B = sort1.SelectedPath;
                    }
                    catch
                    {
                        B = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (resultB == DialogResult.OK || B != "")
                {
                    String destFile = System.IO.Path.Combine(B, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    Lastfile = B;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(B).Name;
                }
            }
            if (e.KeyCode == Keys.C)
            {
                if (C == "")
                {
                    try
                    {
                        resultC = sort1.ShowDialog();
                        C = sort1.SelectedPath;
                    }
                    catch
                    {
                        C = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (resultC == DialogResult.OK || C != "")
                {
                    String destFile = System.IO.Path.Combine(C, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    Lastfile = C;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(C).Name;
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (D == "")
                {
                    try
                    {
                        resultD = sort1.ShowDialog();
                        D = sort1.SelectedPath;
                    }
                    catch
                    {
                        D = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        timer1.Enabled = true;
                    }
                }
                if (resultD == DialogResult.OK || D != "")
                {
                    String destFile = System.IO.Path.Combine(D, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    Lastfile = D;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(D).Name;
                }
            }
            if (e.KeyCode == Keys.E)
            {
                if (E == "")
                {
                    try
                    {
                        resultE = sort1.ShowDialog();
                        E = sort1.SelectedPath;
                    }
                    catch
                    {
                        E = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (resultE == DialogResult.OK || E != "")
                {
                    String destFile = System.IO.Path.Combine(E, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    Lastfile = E;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(E).Name;
                }
            }
            if (e.KeyCode == Keys.F)
            {
                if (F == "")
                {
                    try
                    {
                        resultF = sort1.ShowDialog();
                        F = sort1.SelectedPath;
                    }
                    catch
                    {
                        F = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (resultF == DialogResult.OK || F != "")
                {
                    String destFile = System.IO.Path.Combine(F, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    Lastfile = F;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label3.Text = "Added to " + new DirectoryInfo(F).Name;
                }
            }
            if (e.KeyCode == Keys.G)
            {
                if (G == "")
                {
                    try
                    {
                        resultG=sort1.ShowDialog();
                        G = sort1.SelectedPath;
                    }
                    catch
                    {
                        G = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (resultG == DialogResult.OK || G != "")
                {
                    String destFile = System.IO.Path.Combine(G, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    Lastfile = G;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(G).Name;
                }
            }
            if (e.KeyCode == Keys.H)
            {
                if (H == "")
                {
                    try
                    {
                        resultH = sort1.ShowDialog();
                        H = sort1.SelectedPath;
                    }
                    catch
                    {
                        H = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (resultH == DialogResult.OK || H != "")
                {
                    String destFile = System.IO.Path.Combine(H, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    Lastfile = H;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(H).Name;
                }
            }
            if (e.KeyCode == Keys.I)
            {
                if (I == "")
                {
                    try
                    {
                        resultI = sort1.ShowDialog();
                        I = sort1.SelectedPath;
                    }
                    catch
                    {
                        I = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (resultI == DialogResult.OK || I != "")
                {
                    String destFile = System.IO.Path.Combine(I, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                    File.Copy(filesall[x], destFile, true);
                    button3.PerformClick();
                    Lastfile = I;
                    Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(I).Name;
                }
            }
            if (e.KeyCode == Keys.J)
            {
                if (J == "")
                {
                    try
                    {
                        resultJ = sort1.ShowDialog();
                        J = sort1.SelectedPath;
                    }
                    catch
                    {
                        J = "";
                        Random random = new Random();
                        int sheytema = random.Next(14);
                        MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                    if (resultJ == DialogResult.OK || J != "")
                    {
                        String destFile = System.IO.Path.Combine(J, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = J;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                    label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(J).Name;
                }
            }
            if (e.KeyCode == Keys.K)
            {
                    if (K == "")
                    {
                        try
                        {
                            resultK = sort1.ShowDialog();
                            K = sort1.SelectedPath;
                        }
                        catch
                        {
                            K = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                    if (resultK == DialogResult.OK || K != "")
                    {
                        String destFile = System.IO.Path.Combine(K, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = K;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(K).Name;
                }
            }
            if (e.KeyCode == Keys.L)
            {
                        if (L == "")
                        {
                            try
                            {
                            resultL = sort1.ShowDialog();
                                L = sort1.SelectedPath;
                            }
                            catch
                            {
                                L = "";
                                Random random = new Random();
                                int sheytema = random.Next(14);
                                MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                            if (resultL == DialogResult.OK || L != "")
                            {
                                String destFile = System.IO.Path.Combine(L, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                                File.Copy(filesall[x], destFile, true);
                                Lastfile = L;
                                Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                                button3.PerformClick();
                                label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(L).Name;
                }
            }
            if (e.KeyCode == Keys.M)
            {
                if (M == "")
                {
                        try
                        {
                            resultM = sort1.ShowDialog();
                            M = sort1.SelectedPath;
                        }
                        catch
                        {

                            M = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultM == DialogResult.OK || M != "")
                    {
                        String destFile = System.IO.Path.Combine(M, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = M;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(M).Name;
                }
            }
            if (e.KeyCode == Keys.N)
            {
                if (N == "")
                {
                        try
                        {
                            resultN = sort1.ShowDialog();
                            N = sort1.SelectedPath;
                        }
                        catch
                        {

                            N = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultN == DialogResult.OK || N != "")
                    {
                        String destFile = System.IO.Path.Combine(N, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = N;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(N).Name;
                }
            }
            if (e.KeyCode == Keys.O)
            {
                if (O == "")
                {
                        try
                        {
                            resultO = sort1.ShowDialog();
                            O = sort1.SelectedPath;
                        }
                        catch
                        {
                            O = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultO == DialogResult.OK || O != "")
                    {
                        String destFile = System.IO.Path.Combine(O, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = O;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(O).Name;
                }
            }
            if (e.KeyCode == Keys.P)
            {
                if (P == "")
                {
                        try
                        {
                            resultP = sort1.ShowDialog();
                            P = sort1.SelectedPath;
                        }
                        catch{
                            P = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultP == DialogResult.OK || P != "")
                    {
                        String destFile = System.IO.Path.Combine(P, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = P;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(P).Name;
                }
            }
            if (e.KeyCode == Keys.Q)
            {
                if (Q == "")
                {
                        try
                        {
                            resultQ = sort1.ShowDialog();
                            Q = sort1.SelectedPath;
                        }
                        catch
                        {
                            Q = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        timer1.Enabled = true;
                    }

                }
                    if (resultQ == DialogResult.OK || Q != "")
                    {
                        String destFile = System.IO.Path.Combine(Q, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = Q;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);    
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(Q).Name;
                }
            }
            if (e.KeyCode == Keys.R)
            {
                if (R == "")
                {
                        try
                        {
                            resultR = sort1.ShowDialog();
                            R = sort1.SelectedPath;
                        }
                        catch
                        {
                            R = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultR == DialogResult.OK || R != "")
                    {
                        String destFile = System.IO.Path.Combine(R, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = R;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(R).Name;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (S == "")
                {
                        try
                        {
                            resultS = sort1.ShowDialog();
                            S = sort1.SelectedPath;
                        }
                        catch
                        {
                            S = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultS == DialogResult.OK || S != "")
                    {
                        String destFile = System.IO.Path.Combine(S, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = S;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(S).Name;
                }
            }
            if (e.KeyCode == Keys.T)
            {
                if (T == "")
                {
                        try
                        {
                            resultT = sort1.ShowDialog();
                            T = sort1.SelectedPath;
                        }
                        catch
                        {
                            T = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultT == DialogResult.OK || T != "")
                    {
                        String destFile = System.IO.Path.Combine(T, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = T;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(T).Name;
                }
            }
            if (e.KeyCode == Keys.U)
            {
                if (U == "")
                {
                        try
                        {
                            resultU = sort1.ShowDialog();
                            U = sort1.SelectedPath;
                        }
                        catch
                        {
                            U = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultU == DialogResult.OK || U != "")
                    {
                        String destFile = System.IO.Path.Combine(U, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = U;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(U).Name;
                }
            }
            if (e.KeyCode == Keys.V)
            {
                if (V == "")
                {
                        try
                        {
                            resultV = sort1.ShowDialog();
                            V = sort1.SelectedPath;
                        }
                        catch
                        {
                            V = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultV == DialogResult.OK || V != "")
                    {
                        String destFile = System.IO.Path.Combine(V, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = V;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(V).Name;
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (W == "")
                {
                        try
                        {
                            resultW = sort1.ShowDialog();
                            W = sort1.SelectedPath;
                        }
                        catch
                        {
                            W = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultW == DialogResult.OK || W != "")
                    {
                        String destFile = System.IO.Path.Combine(W, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = W;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(W).Name;
                }
            }
            if (e.KeyCode == Keys.X)
            {
                    if (X == "")
                    {
                        try
                        {
                            resultX = sort1.ShowDialog();
                            X = sort1.SelectedPath;
                        }
                        catch
                        {
                            X = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                        if (resultX == DialogResult.OK || X != "")
                        {
                            String destFile = System.IO.Path.Combine(X, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                            File.Copy(filesall[x], destFile, true);
                            Lastfile = X;
                            Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                            button3.PerformClick();
                            label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(X).Name;
                }
            }
            if (e.KeyCode == Keys.Y)
            {
                if (Y == "")
                {
                        try
                        {
                            resultY = sort1.ShowDialog();
                            Y = sort1.SelectedPath;
                        }
                        catch
                        {
                            Y = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                    if (resultY == DialogResult.OK || Y != "")
                    {
                        String destFile = System.IO.Path.Combine(Y, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = Y;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                    timer1.Enabled = true;
                    label4.Text = "Added to " + new DirectoryInfo(Y).Name;
                }
            }
            if (e.KeyCode == Keys.Z)
            {  if (Z == "")
                    { 
                        try
                        {
                            resultZ = sort1.ShowDialog();
                            Z = sort1.SelectedPath;
                        }
                        catch
                        {
                            Z = "";
                            Random random = new Random();
                            int sheytema = random.Next(14);
                            MessageBox.Show("Choose File 3edl ya " + shatayem[sheytema], "Eh Yasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (resultZ == DialogResult.OK || Z !="")
                    {
                        String destFile = System.IO.Path.Combine(Z, Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]));
                        File.Copy(filesall[x], destFile, true);
                        Lastfile = Z;
                        Lastmeme = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]);
                        button3.PerformClick();
                        label2.Text = Path.GetFileNameWithoutExtension(filesall[x]) + "Meme" + (x + 1).ToString() + Path.GetExtension(filesall[x]) + "/" + filesall.Length.ToString();
                        label4.Text = "Added to " + new DirectoryInfo(Z).Name;
                        timer1.Enabled = true;
                }

            }
            if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
                button5.Focus();

            }

            if (e.KeyCode == Keys.Back)
            {
                button6.PerformClick();
                button6.Focus();

            }



            if (e.KeyCode == Keys.XButton1)
            {
                button1.PerformClick();
                button1.Focus();

            }
            if (e.KeyCode == Keys.XButton2)
            {
                button2.PerformClick();
                button2.Focus();

            }


        }
        
    }
}
