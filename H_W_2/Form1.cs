namespace H_W_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayGuessingGame();
        }

        private void PlayGuessingGame()
        {
            int min = 1;
            int max = 2000;
            int attempts = 0;
            bool playAgain = true;

            while (playAgain)
            {
                int guess;
                bool guessed = false;
                attempts = 0;

                while (!guessed)
                {
                    guess = (min + max) / 2;
                    attempts++;

                    DialogResult result = MessageBox.Show(
                        $"Вы задумали число {guess}?",
                        "Угадывание числа",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        guessed = true;
                        MessageBox.Show(
                            $"Число угадано за {attempts} попыток!",
                            "Победа!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        result = MessageBox.Show(
                            $"Задуманное число больше {guess}?",
                            "Уточнение",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            min = guess + 1;
                        }
                        else
                        {
                            max = guess - 1;
                        }
                    }
                }

                DialogResult playAgainResult = MessageBox.Show(
                    "Хотите сыграть ещё раз?",
                    "Новая игра",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                playAgain = (playAgainResult == DialogResult.Yes);
                min = 1;
                max = 2000;
            }
        }
    }
}