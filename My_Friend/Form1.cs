﻿using System;
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
    public partial class My_Friend : Form
    {
        public My_Friend()
        {
            
            InitializeComponent();
                      
        }
        SpeechSynthesizer speech = new SpeechSynthesizer();
        PromptBuilder builder = new PromptBuilder();
        SpeechRecognitionEngine recognize = new SpeechRecognitionEngine();
        private void Form1_Load(object sender, EventArgs e)
        {
            Visualiser.Hide();

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

            InfoBox.Hide();
            Speak_here.Enabled = false;
            Speak_here.Enabled = true;
          //Visualiser.Show(); 
            Choices slist = new Choices();
            slist.Add(new string[]{"Exit","How are you","What is time","Tell me your name","Who is your developer",
            "Where is islamabad located","Who is president of USA","Tell me few products of Pepsi",
            "Who is your favourite star", "Who is best Apple or Samsung", "Who is founder of Apple company"});
            Grammar gr = new Grammar(new GrammarBuilder(slist));
            try
            {
           // visualizer2.Show(); 
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
            Visualiser.Show();  
           // visualizer2.Hide(); 
             
            if (e.Result.Text == "Exit")
            {
                Application.Exit();
            }
            else
            {
                Command.Clear();
                Reply.Clear();
                Command.Text = Command.Text + " " + e.Result.Text.ToString() + " ";
                String question = e.Result.Text.ToString();
                if (question.Contains("How are you"))
                {
                    Reply.Text = Reply.Text + " I am fine";
                    speech.Speak(" I am fine");
                }
                else if (question.Contains("What is time"))
                {
                    Reply.Text = Reply.Text + " Check right bottom of your screen";
                    speech.Speak(" Check right bottom of your screen");
                }
                else if (question.Contains("Tell me your name"))
                {
                    Reply.Text = Reply.Text + "My name is My_Friend";
                    speech.Speak(" My name is My_Friend");
                }
                else if (question.Contains("Who is your developer"))
                {
                    Reply.Text = Reply.Text + "You are my developer";
                    speech.Speak(" You are my developer");
                }
                else if (question.Contains("Where is Islamabad located"))
                {
                    Reply.Text = Reply.Text + "Islamabad is located in Pakistan";
                    speech.Speak(" Islamabad is located in Pakistan");
                }
                else if (question.Contains("Who is president of USA"))
                {
                    Reply.Text = Reply.Text + "Barack Obama is the President of USA";
                    speech.Speak(" Barack Obama is the President of USA");
                }
                else if (question.Contains("Tell me few products of Pepsi"))
                {
                    Reply.Text = Reply.Text + "Dew, Pepsi Fanta are Pepsi's product";
                    speech.Speak("Dew, Pepsi Fanta are Pepsi's product");
                }
                else if (question.Contains("Who is your favourite star"))
                {
                    Reply.Text = Reply.Text + "Johnny Depp is my favourite star";
                    speech.Speak(" Johnny Depp is my favourite star");
                }
                else if (question.Contains("Who is best Apple or Samsung"))
                {
                    Reply.Text = Reply.Text + "Both are best but my choice is Apple";
                    speech.Speak(" Both are best but my choice is Apple");
                }
                else if (question.Contains("Who is founder of Apple company"))
                {
                    Reply.Text = Reply.Text + "Steve Jobs is the fouder of Apple company";
                    speech.Speak(" Steve Jobs is the fouder of Apple company");
                }
                Visualiser.Hide();
            }
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
