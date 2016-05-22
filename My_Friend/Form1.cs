using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.IO;
using SHDocVw;
using System.Drawing.Imaging;
namespace My_Friend
{

    public partial class My_Friend : Form
    {
        public Choices slist = new Choices();
        public String path;
        string[] result = File.ReadAllLines("file.txt");
        bool check;
        Server obj;
        string processType;
        ShellWindows _shellWindows = new SHDocVw.ShellWindows();
        public My_Friend()
        {
            InitializeComponent();
          
        }
        SpeechSynthesizer speech = new SpeechSynthesizer();
     //   PromptBuilder builder = new PromptBuilder();
        SpeechRecognitionEngine recognize = new SpeechRecognitionEngine();
        private void Form1_Load(object sender, EventArgs e)
        {
          obj = new Server();

            label1.Text= obj.myip();
            check = false;
            if (result.Length > 1)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    slist.Add(new string[] { result[i++] });
                }
                slist.Add(new string[] { "What is time" });
            }
            bool value=obj.StartServer();
         //   label1.Text = value.ToString();
            //Visualiser.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //private void button1_Click(object sender, EventArgs e)
        //{

        //    builder.ClearContent();
        //    builder.AppendText(Command.Text);
        //    speech.Speak(builder);
        //}

        //private void pictureBox1_Click_1(object sender, EventArgs e)
        //{
            
        //}
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            check = true;
            try
            {
                Grammar gr = new Grammar(new GrammarBuilder(slist));
                recognize.RequestRecognizerUpdate();
                recognize.LoadGrammar(gr);
                recognize.SpeechRecognized += recognize_SpeechRecognized;
                recognize.SetInputToDefaultAudioDevice();
                recognize.RecognizeAsync(RecognizeMode.Multiple);
                //Visualiser.Show();

            }
            catch
            {
                return;
            }

        }
        private void recognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
          
            
            if (e.Result.Text == "Exit")
            {
                Application.Exit();
            }
            else
            {
               // Command.Clear();
               // Reply1.Clear();
               // Command.Text = Command.Text + " " + e.Result.Text.ToString() + " ";
                String question = e.Result.Text.ToString();
                reply(question);
                //Visualiser.Hide();
            }
        }

        public void reply(string question)
        {
            check = true;
            speech.Speak(question);
          
            if (result.Length > 1 && check == true)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (question.Contains(result[i]))
                    {
                        check = false;
                        Process.Start(@result[i + 1]);
                    }
                }
              
               if (question.Contains("what are you doing"))
                {
                   // Reply1.Text = Reply1.Text + " I am fine";
                    speech.Speak(" I am fine");
                }

                else if (question.Contains("how are you"))
                {
                   // Reply.Text = Reply.Text + " Answering your questions";
                    //speech.Speak(" Answering your questions");

                    //DateTime date = new DateTime();
                    string custom = DateTime.Now.ToLongTimeString();
                    //MessageBox.Show(custom);
                   // Reply1.Text = Reply1.Text + "Its " + custom;
                    speech.Speak("Its " + custom);
                }

                else if (question.Contains("what is time"))
                {
                    //DateTime date = new DateTime();
                    string custom = DateTime.Now.ToLongTimeString();
                    //MessageBox.Show(custom);
                    //Reply.Text = Reply.Text + "Its " + custom;
                    speech.Speak("Its " + custom);
                }
                else if (question.Contains("shutdown"))
                {                   
                    Process.Start("shutdown", "/s /t 0"); Process.Start("Shutdown", "-s -t 10");
                }
                else if (question.Contains("Facebook"))
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.UseShellExecute = true;
                   
                    System.Diagnostics.Process.Start("http://www.facebook.com");
                    
                }
               else if (question.Contains("facebook"))
               {
                   System.Diagnostics.Process process = new System.Diagnostics.Process();
                   process.StartInfo.UseShellExecute = true;

                   System.Diagnostics.Process.Start("http://www.facebook.com");

               }
               else if (question.Contains("open Google"))
               {
                   System.Diagnostics.Process process = new System.Diagnostics.Process();
                   process.StartInfo.UseShellExecute = true;

                   System.Diagnostics.Process.Start("http://www.google.com");

               }
               else if (question.Contains("open google"))
               {
                   System.Diagnostics.Process process = new System.Diagnostics.Process();
                   process.StartInfo.UseShellExecute = true;

                   System.Diagnostics.Process.Start("http://www.google.com");

               }
               else if (question.Contains("open Gmail"))
               {
                   System.Diagnostics.Process process = new System.Diagnostics.Process();
                   process.StartInfo.UseShellExecute = true;

                   System.Diagnostics.Process.Start("http://www.gmail.com");

               }
               else if (question.Contains("open e"))
               {
                   System.Diagnostics.Process process = new System.Diagnostics.Process();
                   process.StartInfo.UseShellExecute = true;
                   process = Process.Start("explorer.exe",@"E:\" );

               }

               else if (question.Contains("open paint"))
               {
                   System.Diagnostics.Process process = new System.Diagnostics.Process();
                   process.StartInfo.UseShellExecute = true;
                   process = Process.Start("explorer.exe", @"C:\Windows\system32\mspaint.exe");
               }

               else if (question.Contains("screenshot"))
               {
                   Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                   Graphics graphics = Graphics.FromImage(printscreen as Image);
                   graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
                   printscreen.Save(@"C:\Temp\printscreen.jpg", ImageFormat.Jpeg);

                   System.Diagnostics.Process process = new System.Diagnostics.Process();
                   process.StartInfo.UseShellExecute = true;
                   process = Process.Start("explorer.exe", @"C:\Temp\printscreen.jpg");
               }

               else if (question.Contains("open snipping tool"))
               {
                   if (!Environment.Is64BitProcess)
                       System.Diagnostics.Process.Start("C:\\Windows\\sysnative\\SnippingTool.exe");
                   else
                       System.Diagnostics.Process.Start("C:\\Windows\\system32\\SnippingTool.exe");
               }


                else if (question.Contains("Exit"))
                {
                    Application.Exit();

                }
                else if (question.Contains("Take Care"))
                {
                    Application.Exit();

                }
                else if (question.Contains("Ok take care"))
                {
                    Application.Exit();

                }
                else if (question.Contains("Ok good by"))
                {
                    Application.Exit();

                }
                else if (question.Contains("Ok thats it"))
                {
                    Application.Exit();

                }
                else if (question.Contains("Ok thats enough"))
                {
                    Application.Exit();

                }
                else if (question.Contains("Good by"))
                {
                    Application.Exit();

                }
                else if (question.Contains("Thats it"))
                {
                    Application.Exit();

                }
                else if (question.Contains("Thats enough"))
                {
                    Application.Exit();

                }

            }

        

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Binder obj = new Binder();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}
