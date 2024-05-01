using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Програма_для_вивчення_нових_термінів.QuestionsClasses;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class MatchForm : Form
    {

        private Timer timer;
        private DateTime startTime = DateTime.Now;

        StudySet workingSet;
        Button[] buttons;
        string[,] allTermDefinitionPairs = new string[12, 2];

        Button FirstSelectedButton;
        Button SecondSelectedButton;

        int indexFirst;
        int indexSecond;

        int countAll = 0;

        public MatchForm(StudySet studySet)
        {
            InitializeComponent();
            workingSet = studySet;
            labelTitleCount.Text = workingSet.Title;

            CreateButtons();
            GenerateQuestions();

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void ConfigureButton(Button button, int index)
        {
            button.Name = $"buttonm{index}";
            button.Dock = DockStyle.Fill;
            button.BackColor = Color.FromArgb(189, 173, 161);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(36, 10, 5);
            button.ForeColor = Color.FromArgb(36, 10, 5);
            button.Cursor = Cursors.Hand;
        }

        private void CreateButtons()
        {
            tableLayoutPanel1.Controls.Clear();

            buttons = new Button[12];

            for (int i = 0; i < 12; i++)
            {
                buttons[i] = new Button();
                ConfigureButton(buttons[i], i);
            }

            int index = 0;
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    if (index < buttons.Length)
                    {
                        tableLayoutPanel1.Controls.Add(buttons[index], col, row);
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            string formattedTime = $"{elapsedTime.Seconds}.{elapsedTime.Milliseconds:000}";
            timerLabel.Text = formattedTime + " s";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormShowSet newf = new FormShowSet(workingSet);
            FormForMain mainForm = AppContext.GetMainForm();
            mainForm.OpenChildForm(newf);
            mainForm.Show();
            this.Close();
        }

        private void GenerateQuestions()
        {
            Random random = new Random();
            List<Card> allCards = workingSet.Cards.ToList();
            allCards.Shuffle(random);

            //обирається 6 карток
            List<Card> selectedCards = allCards.Take(6).ToList();

            List<(string, string)> termDefinitionPairs = new List<(string, string)>();

            foreach (var card in selectedCards)
            {
                termDefinitionPairs.Add((card.Term, card.Definition));
                termDefinitionPairs.Add((card.Definition, card.Term));
            }
            termDefinitionPairs.Shuffle(random);

            for (int i = 0; i < 12; i++)
            {
                var pair = termDefinitionPairs[i];
                allTermDefinitionPairs[i, 0] = pair.Item1;
                allTermDefinitionPairs[i, 1] = pair.Item2;
                //buttons[i].Text = pair.Item1;
                buttons[i].Text = pair.Item1.Length > 25 ? pair.Item1.Substring(0, 25) + "..." : pair.Item1;
                buttons[i].Font = new Font(buttons[i].Font.FontFamily, 20);
                buttons[i].Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonIndex = ExtractButtonIndex(clickedButton);

            if (FirstSelectedButton == null)
            {
                SelectFirstButton(clickedButton, buttonIndex);
            }
            else if (SecondSelectedButton == null)
            {
                SelectSecondButton(clickedButton, buttonIndex);
                if (FirstSelectedButton == SecondSelectedButton)
                {
                    ResetSelection();
                    return;
                }
                CheckMatchAndRespond();
            }
        }

        private int ExtractButtonIndex(Button button)
        {
            string buttonName = button.Name;
            string digits = new string(buttonName.Where(char.IsDigit).ToArray());
            return int.Parse(digits);
        }

        private void SelectFirstButton(Button button, int index)
        {
            FirstSelectedButton = button;
            FirstSelectedButton.BackColor = Color.AliceBlue;
            indexFirst = index;
        }

        private void SelectSecondButton(Button button, int index)
        {
            SecondSelectedButton = button;
            SecondSelectedButton.BackColor = Color.AliceBlue;
            indexSecond = index;
        }

        private void CheckMatchAndRespond()
        {
            if (IsMatch(indexFirst, indexSecond))
            {
                MarkAsCorrect();
                if (countAll == 6)
                {
                    EndGame();
                }
                ResetSelection();
            }
            else
            {
                MarkAsIncorrect();
                StartResetTimer();                
            }

        }

        private bool IsMatch(int index1, int index2)
        {
            return allTermDefinitionPairs[index2, 0] == allTermDefinitionPairs[index1, 1] ||
                   allTermDefinitionPairs[index2, 1] == allTermDefinitionPairs[index1, 0];
        }

        private void MarkAsCorrect()
        {
            SecondSelectedButton.BackColor = Color.DarkGreen;
            FirstSelectedButton.BackColor = Color.DarkGreen;
            SecondSelectedButton.Visible = false;
            FirstSelectedButton.Visible = false;
            countAll++;
        }

        private void MarkAsIncorrect()
        {
            FirstSelectedButton.BackColor = Color.FromArgb(0xf1, 0x96, 0x96);
            SecondSelectedButton.BackColor = Color.FromArgb(0xf1, 0x96, 0x96);
        }

        private void StartResetTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 300;
            timer.Tick += (s, ev) =>
            {
                buttons[indexFirst].BackColor = Color.FromArgb(189, 173, 161);
                buttons[indexSecond].BackColor = Color.FromArgb(189, 173, 161);

                timer.Stop();
                timer.Dispose();
                ResetSelection();
            };
            timer.Start();
        }

        private void EndGame()
        {
            timer.Stop();
            RightWrongAnswer resultminiform = new RightWrongAnswer(timerLabel.Text);
            resultminiform.ShowDialog();
            buttonClose_Click(this, EventArgs.Empty);
        }

        private void ResetSelection()
        {
            FirstSelectedButton.BackColor = Color.FromArgb(189, 173, 161);
            FirstSelectedButton = null;
            SecondSelectedButton = null;       
        }

        //    private void Button_Click(object sender, EventArgs e)
        //    {
        //        Button clickedButton = (Button)sender;
        //        string buttonName = clickedButton.Name;
        //        string digitString = new string(buttonName.Where(char.IsDigit).ToArray());
        //        int digit = int.Parse(digitString);

        //        if (FirstSelectedButton == null)
        //        {
        //            FirstSelectedButton = clickedButton;
        //            FirstSelectedButton.BackColor = Color.AliceBlue;
        //            indexFirst = digit;
        //        }
        //        else if (SecondSelectedButton == null)
        //        {
        //            SecondSelectedButton = clickedButton;             
        //            indexSecond = digit;

        //            if (FirstSelectedButton == SecondSelectedButton)
        //            {
        //                FirstSelectedButton = null;
        //                SecondSelectedButton = null;
        //                buttons[indexFirst].BackColor = Color.FromArgb(189, 173, 161);
        //                buttons[indexSecond].BackColor = Color.FromArgb(189, 173, 161);
        //                return;
        //            }

        //            //if (allTermDefinitionPairs[indexSecond,0] == allTermDefinitionPairs[indexFirst, 1] &&
        //            //    allTermDefinitionPairs[indexSecond, 1] == allTermDefinitionPairs[indexFirst, 0])
        //            if (allTermDefinitionPairs[indexSecond, 0] == allTermDefinitionPairs[indexFirst, 1] ||
        //               allTermDefinitionPairs[indexSecond, 1] == allTermDefinitionPairs[indexFirst, 0])
        //            {
        //                SecondSelectedButton.BackColor = Color.DarkGreen;
        //                FirstSelectedButton.BackColor = Color.DarkGreen;

        //                SecondSelectedButton.Visible = false;
        //                FirstSelectedButton.Visible = false;
        //                countAll++;

        //                if (countAll == 6)
        //                {
        //                    timer.Stop();
        //                    RightWrongAnswer resultminiform = new RightWrongAnswer(timerLabel.Text);
        //                    resultminiform.ShowDialog();
        //                    buttonClose_Click(sender, e);
        //                }

        //            }

        //            else
        //            {
        //                SecondSelectedButton.BackColor = Color.FromArgb(0xf1, 0x96, 0x96);
        //                FirstSelectedButton.BackColor = Color.FromArgb(0xf1, 0x96, 0x96);
        //                Timer timer = new Timer();
        //                timer.Interval = 300; 
        //                timer.Tick += (s, ev) =>
        //                {
        //                    buttons[indexFirst].BackColor = Color.FromArgb(189, 173, 161); ;
        //                    buttons[indexSecond].BackColor = Color.FromArgb(189, 173, 161); ;

        //                    timer.Stop();
        //                    timer.Dispose();
        //                };
        //                timer.Start();
        //            }
        //            FirstSelectedButton = null;
        //            SecondSelectedButton = null;
        //        }
        //    }
        //}
    }
}




//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static Програма_для_вивчення_нових_термінів.QuestionsClasses;

//namespace Програма_для_вивчення_нових_термінів
//{
//    public partial class MatchForm : Form
//    {
//        StudySet workingSet;
//        ButtonForMatch[] buttons;

//        ButtonForMatch FirstSelectedButton;
//        ButtonForMatch SecondSelectedButton;

//        public MatchForm(StudySet studySet)
//        {
//            InitializeComponent();
//            workingSet = studySet;
//            labelTitleCount.Text = workingSet.Title;


//            buttons = new ButtonForMatch[12];
//            for (int i = 0; i < 12; i++)
//            {
//                string buttonName = "buttonForMatch" + (i + 1);
//                ButtonForMatch button = (ButtonForMatch)Controls.Find(buttonName, true)[0];
//                buttons[i] = button;
//            }

//            //for (int i = 0; i < 12; i++)
//            //{
//            //    buttons[i] = new ButtonForMatch();
//            //    buttons[i].Name = $"buttonForMatch{i + 1}"; 
//            //    buttons[i].Dock = DockStyle.Fill;        
//            //}

//            //int index = 0;
//            //for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
//            //{
//            //    for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
//            //    {
//            //        if (index < buttons.Length)
//            //        {
//            //            tableLayoutPanel1.Controls.Add(buttons[index], col, row);
//            //            index++;
//            //        }
//            //        else
//            //        {
//            //            break;
//            //        }
//            //    }
//            //}
//            GenerateQuestions();
//        }


//        private void buttonClose_Click(object sender, EventArgs e)
//        {
//            FormShowSet newf = new FormShowSet(workingSet);
//            FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().Where(x => x.Name == "FormForMain").FirstOrDefault();
//            mainForm.OpenChildForm(newf);
//            this.Close();
//        }

//        private void GenerateQuestions()
//        {
//            Random random = new Random();
//            List<Card> allCards = workingSet.Cards.ToList();
//            allCards.Shuffle(random); 

//            List<Card> selectedCards = allCards.Take(6).ToList();

//            List<(string, string)> termDefinitionPairs = new List<(string, string)>();

//            foreach (var card in selectedCards)
//            {
//                termDefinitionPairs.Add((card.Term, card.Definition));
//                termDefinitionPairs.Add((card.Definition, card.Term));
//            }
//            termDefinitionPairs.Shuffle(random);

//            for (int i = 0; i < 12; i++)
//            {
//                var pair = termDefinitionPairs[i]; // Отримуємо пару термін-визначення за індексом
//                buttons[i].setTextButton(pair.Item1, pair.Item2);
//                buttons[i].button1.Click += Button_ClickProxy;
//                //buttons[i].Click += Button_Click;
//                //Button_Click(buttons[i], new EventArgs());
//                //buttons[i].setButtonClick(Button_Click);
//            }
//        }


//        private void buttonForMatch1_Load(object sender, EventArgs e)
//        {

//        }

//        private void Button_Click(object sender, EventArgs e)
//        {
//            ButtonForMatch clickedButton = (ButtonForMatch)sender;

//            if (FirstSelectedButton == null)
//            {
//                // Це перше натискання
//                FirstSelectedButton = clickedButton;
//                //FirstSelectedButton.Ch(Color.Blue); // Підсвітити першу кнопку
//            }
//            else if (SecondSelectedButton == null)
//            {
//                // Це друге натискання
//                SecondSelectedButton = clickedButton;

//                // Перевіряємо, чи збігаються терміни або визначення з першою обраною кнопкою
//                if (SecondSelectedButton.firstT == FirstSelectedButton.secondT &&
//                    SecondSelectedButton.secondT == FirstSelectedButton.firstT)
//                {
//                    // Відповідає, підсвічуємо кнопки зеленим
//                    SecondSelectedButton.ChangeColor(Color.Green);
//                    FirstSelectedButton.ChangeColor(Color.Green);
//                    // Зникають кнопки
//                    SecondSelectedButton.Visible = false;
//                    FirstSelectedButton.Visible = false;
//                }
//                else
//                {
//                    // Не відповідає, підсвічуємо кнопки червоним
//                    SecondSelectedButton.ChangeColor(Color.Red);
//                    FirstSelectedButton.ChangeColor(Color.Red);
//                    // Почекайте 1 секунду, потім зняти підсвічування та очистити обрані кнопки
//                    Timer timer = new Timer();
//                    timer.Interval = 1000; // 1 секунда
//                    timer.Tick += (s, ev) =>
//                    {
//                        SecondSelectedButton.ResetButton();
//                        FirstSelectedButton.ResetButton();
//                        FirstSelectedButton = null;
//                        SecondSelectedButton = null;
//                        timer.Stop();
//                        timer.Dispose();
//                    };
//                    timer.Start();
//                }
//            }
//        }


//        private void Button_ClickProxy(object sender, EventArgs e)
//        {
//            ButtonForMatch button = sender as ButtonForMatch;
//            Button_Click(button, e);
//        }


//    }
//}

