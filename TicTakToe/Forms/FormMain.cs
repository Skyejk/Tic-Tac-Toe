using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTakToe
{
    public partial class FormMain : Form
    {   
        // игровое поле
        private char[,] board = new char[3, 3];
        // текущий игрок
        private char currentPlayer = 'X';
        public FormMain()
        {
            InitializeComponent();
            // инициализация игрового поля
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
            SetStatusText();
        }
        private void btnPlayer_Click(object sender, EventArgs e)
        {
            

            Button button = (Button)sender;
            // получаем координаты нажатой кнопки на игровом поле
            int row = int.Parse(button.Name.Substring(3, 1));
            int col = int.Parse(button.Name.Substring(4, 1));

            // проверяем, что клетка не занята
            if (board[row, col] == ' ')
            {
                // помечаем клетку символом текущего игрока и меняем игрока
                board[row, col] = currentPlayer;
                button.Text = currentPlayer.ToString();
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                SetStatusText();

                // проверяем, есть ли победитель
                char winner = CheckWinner();
                if (winner != ' ')
                {
                    MessageBox.Show($"Победил игрок {winner}!");
                    ResetBoard();
                }
                else
                {
                    // проверяем, закончилась ли игра вничью
                    bool draw = true;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (board[i, j] == ' ')
                            {
                                draw = false;
                                break;
                            }
                        }
                        if (!draw)
                        {
                            break;
                        }
                    }
                    if (draw)
                    {
                        MessageBox.Show("Игра закончилась вничью.");
                        ResetBoard();
                    }
                }
            }
        }

        //Установка значения в mainText(отображаемый статус текущего игрока)
        private void SetStatusText() {
            statusText.Text = $"Ход игрока: {currentPlayer}";
        }
        // проверка, есть ли победитель
        private char CheckWinner()
        {
            // проверяем горизонтали
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                {
                    return board[i, 0];
                }
            }

            // проверяем вертикали
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                {
                    return board[0, i];
                }
            }

            // проверяем диагонали
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                return board[0, 0];
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            {
                return board[0, 2];
            }

            // если победителя нет, возвращаем пустой символ
            return ' ';
        }

        // сброс игрового поля
        private void ResetBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                    string buttonName = $"btn{i}{j}";
                    Controls.Find(buttonName, true)[0].Text = " ";
                }
            }
            currentPlayer = 'X';
            SetStatusText();
        }
    }
}