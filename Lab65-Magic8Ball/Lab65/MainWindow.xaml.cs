﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace Lab65
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void answer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Thread.Sleep(TimeSpan.FromSeconds(1));

            AnswerGenerator generator = new AnswerGenerator();
            answerBox.Text = generator.GetRandomAnswer(questionBox.Text);
            this.Cursor = null;

        }
    }
}
