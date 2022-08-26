using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Millionaire
{
    public struct Answer
    {
        public Answer (string Answer, bool Correct)
        {
            answer = Answer; correct = Correct;
        }

        public string answer;
        public bool correct;
    }
    public struct Question
    {
        public Question (string Question, Answer[] Answers)
        {
            question = Question; answers = Answers;
        }
        public string question;
        public Answer[] answers;
    }
    public struct Game
    {
        public Game(Question[] Questions, string Theme)
        {
            questions = Questions;
            theme = Theme;
            loose = false;
        }
        public bool loose;
        public string theme;
        public Question[] questions;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //_ = JObject.Parse(File.ReadAllText(@"./gameConfig.json"));
        }
    }
}
