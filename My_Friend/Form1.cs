using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
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
            slist.Add(new string[] { "hi", "test", "it works", "how", "are you","who","plastic","laptop","system","table" });
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
            if (e.Result.Text == "exit")
            {
                Application.Exit();
            }
            else
            {
               Command.Text = Command.Text + " " + e.Result.Text.ToString()+", ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
