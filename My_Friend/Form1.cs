using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
namespace My_Friend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Command.Show();           
        }
        SpeechSynthesizer speech = new SpeechSynthesizer();
        PromptBuilder builder = new PromptBuilder();
        SpeechRecognitionEngine recognize = new SpeechRecognitionEngine();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            builder.ClearContent();
            builder.AppendText(Command.Text);
            speech.Speak(builder);
        }

        //private void pictureBox1_Click_1(object sender, EventArgs e)
        //{
            
        //}

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Hide();
            Speak_here.Enabled = false;
            Speak_here.Enabled = true;
            Choices slist = new Choices();
            slist.Add(new string[]{"How are you","What is time","Tell me your name","Who is your developer",
            "Where is islamabad located","Who is president of USA","Tell me few products of Pepsi",
            "Who is your favourite star", "Who is best Apple or Samsung", "Who is founder of Apple company"});
            Grammar gr = new Grammar(new GrammarBuilder(slist));
            try
            {
            
            recognize.RequestRecognizerUpdate();
            recognize.LoadGrammar(gr);
            recognize.SpeechRecognized += recognize_SpeechRecognized;
            recognize.SetInputToDefaultAudioDevice();
            recognize.RecognizeAsync(RecognizeMode.Multiple);

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
                Command.Text = Command.Text + " " + e.Result.Text.ToString() + " ";
                String question = e.Result.Text.ToString();
                if (question.Contains("How are you"))
                {
                    Command1.Text = Command1.Text + " I am fine";
                }
                else if (question.Contains("What is time"))
                {
                    Command1.Text = Command1.Text + " Check right bottom of your screen";
                }
                else if (question.Contains("Tell me your name"))
                {
                    Command1.Text = Command1.Text + "My name is My_Friend";
                }
                else if (question.Contains("Who is your developer"))
                {
                    Command1.Text = Command1.Text + "You are my developer";
                }
                else if (question.Contains("Where is Islamabad located"))
                {
                    Command1.Text = Command1.Text + "Islamabad is located in Pakistan";
                }
                else if (question.Contains("Who is president of USA"))
                {
                    Command1.Text = Command1.Text + "Barack Obama is the President of USA";
                }
                else if (question.Contains("Tell me few products of Pepsi"))
                {
                    Command1.Text = Command1.Text + "Dew, Pepsi Fanta are Pepsi's product";
                }
                else if (question.Contains("Who is your favourite star"))
                {
                    Command1.Text = Command1.Text + "Johnny Depp is my favourite star";
                }
                else if (question.Contains("Who is best Apple or Samsung"))
                {
                    Command1.Text = Command1.Text + "Both are best but my choice is Apple";
                }
                else if (question.Contains("Who is founder of Apple company"))
                {
                    Command1.Text = Command1.Text + "Steve Jobs is the fouder of Apple company";
                }
            }
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
