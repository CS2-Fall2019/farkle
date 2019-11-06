﻿//-----------------------------------------------------------------------
// <copyright file="MainMenu.xaml.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace farkle
{
    using System;
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
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainMenu" /> class.
        /// </summary>
        public MainMenu()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Start button click event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">RoutedEventArgs e.</param>
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rdoOnePlayer.IsChecked == true)
            {
                MainWindow farkleGame = new MainWindow();
                farkleGame.OnePlayer = true;
                farkleGame.Show();
            }
            else if ((bool)rdoTwoPlayer.IsChecked == true)
            {
                MainWindow farkleGame = new MainWindow();
                farkleGame.TwoPlayer = true;
                farkleGame.Show();
            }
            else if ((bool)rdoThreePlayer.IsChecked == true)
            {
                MainWindow farkleGame = new MainWindow();
                farkleGame.ThreePlayer = true;
                farkleGame.Show();
            }
            else
            {
                // Four players was selected.
                MainWindow farkleGame = new MainWindow();
                farkleGame.FourPlayer = true;
                farkleGame.Show();
            }

            // Close current form.
            this.Close();
        }

        /// <summary>
        /// Scoring button click event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">RoutedEventArgs e.</param>
        private void BtnScoring_Click(object sender, RoutedEventArgs e)
        {
            Scoring scoringLegend = new Scoring();
            scoringLegend.Show();
        }

        /// <summary>
        /// About button click event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">RoutedEventArgs e.</param>
        private void BtnAbout_Click(object sender, RoutedEventArgs e)
        {
            // Show message box with developers names and the rules to farkle.
            MessageBox.Show("Developers: Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze." + "Date: October 2019", "Information");

            MessageBox.Show(
                "First player to 10000 points wins." + "\n" +
                            "The player rolls all 6 of their dice at the start of their turn." + "\n" +
                            "After every roll at least 1 scorable die must be set aside." + "\n" +
                            "The player at this point could either end their turn to save their points or roll their remaining dice to try and increase their score." + "\n" +
                            "If the player has recieved a score on all 6 dice then the player gets to roll all 6 dice again, this is called 'Hot Dice'" + "\n" +
                            "There is no limit to the amount of 'Hot Dice' a player can get, but if the player rolls no scoreable dice then the player losses all their points from that round." + "\n" +
                            "If the player has no scoreable dice then there turn is over and the player recieves no point for that turn, this is called a 'farkle'.",
                     "Rules");
        }
    }
}