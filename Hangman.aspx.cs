﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hangman_GUI;
using HangmanGUI_11;

namespace Hangman_WebForm
{
    public partial class Hangman : System.Web.UI.Page
    {

        private List<string> SecretWordTiles
        {
            get { return (List<string>)ViewState["SecretWordTiles"]; }
            set { ViewState["SecretWordTiles"] = value; }
        }

        private string SecretWord
        {
            get { return ViewState["SecretWord"].ToString(); }
            set { ViewState["SecretWord"] = value; }
        }


        private string[] GuessedWord
        {
            get { return(string[]) ViewState["GuessedWord"]; }
            set { ViewState["GuessedWord"] = value; }
        }

        private int WrongGuesses
        {
            get { return(int) ViewState["WrongGuessesWord"]; }
            set { ViewState["WrongGuessesWord"] = value; }
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            //redirecting to login if user is not logged in
            if (!Context.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Account/Login.aspx");
            }

            if (!IsPostBack)
            {
                NewGame();
            }

            else
            {
                DisplaySeceretWordTiles();
            }

        }

        protected void btnA_Click(object sender, ImageClickEventArgs e)
        {
            if (GameOver) return;

            ImageButton pushedButton = (ImageButton)sender;
            pushedButton.Enabled = false;
            ProcessGuess(pushedButton.AlternateText);
        }




        private void ProcessGuess(string strPlayerGuess  )
        {
            
            
                int nWrongGuess = 1;//assume guess is wrong

                //search through secret word Tiles looking for a match
                for(int n=0; n < SecretWord.Length;n++)
                {
                    if (SecretWord[n].ToString().ToUpper()==strPlayerGuess)
                    {
                        Control imgLetter = this.Master.FindControl("MainContent").FindControl(SecretWordTiles[n]);//----Find image on the hangman page

                        ((Image)imgLetter).ImageUrl = GetTileImage(strPlayerGuess);
                        GuessedWord[n] = "#";
                        nWrongGuess = 0;

                      

                    }

                }

                //increment WrongGuesses
                WrongGuesses += nWrongGuess;
                pbGallows.ImageUrl = HangmanGallows.GetGallowImage(WrongGuesses);

                CheckForWinLoss();

            }
        private string GetTileImage(string strPlayerGuess)
        {
            switch (strPlayerGuess)
            {
                case "A": return "./Resources/A.png";
                case "B": return "./Resources/B.png";
                case "C": return "./Resources/C.png";
                case "D": return "./Resources/D.png";
                case "E": return "./Resources/E.png";
                case "F": return "./Resources/F.png";
                case "G": return "./Resources/G.png";
                case "H": return "./Resources/H.png";
                case "I": return "./Resources/I.png";
                case "J": return "./Resources/J.png";
                case "K": return "./Resources/K.png";
                case "L": return "./Resources/L.png";
                case "M": return "./Resources/M.png";
                case "N": return "./Resources/N.png";
                case "O": return "./Resources/O.png";
                case "P": return "./Resources/P.png";
                case "Q": return "./Resources/Q.png";
                case "R": return "./Resources/R.png";
                case "S": return "./Resources/S.png";
                case "T": return "./Resources/T.png";
                case "U": return "./Resources/U.png";
                case "V": return "./Resources/V.png";
                case "W": return "./Resources/W.png";
                case "X": return "./Resources/X.png";
                case "Y": return "./Resources/Y.png";
                case "Z": return "./Resources/Z.png";
                default:
                    return "./Resources/BLANK.png";
            }
        }

        private void CheckForWinLoss()
        {
            string strMessage = "";

            // check for loss
            if (WrongGuesses == 10)
            {
                strMessage = "You lost...";
                CurrentGamer.AddLoss();

            }
            else if (GuessedIt())
            {
                strMessage = "You Won!!!";
                CurrentGamer.AddWin(SecretWord);
                pbGallows.ImageUrl = "./Resources/StageWon.png";
            }
            else
            {
                return;
            }

            UpdateGamer();
            GameOver = true;
            pnlNewGame.Visible = true;
            lblMessage.Text = strMessage + "The word was " + SecretWord + ".Would you like to play Again?";
             
            
        }

        private HangmanGamer CurrentGamer
        {
                    get { return (HangmanGamer)ViewState["CurrentGamer"]; }
                    set { ViewState["CurrentGamer"] = value; }
                
        }

        private bool GameOver
        {
                  get{  return (bool)ViewState["GameOver"]; }
                  set { ViewState["GameOver"] = value; }

        }

        private void UpdateGamer()
        {
            
            
                HangmanGamerRepository _db = new HangmanGamerRepository();
                _db.UpdateGamer(CurrentGamer);
                _db.Save();


        }

        private bool GuessedIt()
        {
            // check all SecretWordTile picture boxes
            foreach ( string letter in GuessedWord. Where(pb => pb != "#"))
            {

                //if tag doesn't have a #, then the word hasn't been guessed yet

                {
                    return false;
                }
            }

            //if every picture box was checked and this method didn't return false
            return true;


        }
        private void NewGame()
        {

            WrongGuesses = 0;
            AddGamer();
            LoadSecretWord();
            GameOver = false;
            pbGallows.ImageUrl = "./Resources/Stage0.png";
            EnableButtons();

        }

        private void EnableButtons()
        {
            foreach (Control control in pnlAlphabet.Controls)
            {
                if (control.GetType() == typeof(ImageButton))

                {
                    ((ImageButton)control).Enabled = true;
                }
            }
        }

        private void AddGamer()
        {
            HangmanGamerRepository _db = new HangmanGamerRepository();
            CurrentGamer = _db.GetGamerByName(Context.User.Identity.Name);
            if (CurrentGamer == null)
            {
                CurrentGamer = new HangmanGamer(Context.User.Identity.Name);
                _db.AddGamer(CurrentGamer);
                _db.Save();
            }
            lblGamerNamer. Text = CurrentGamer. Name;
            lblLongestWord.Text = "Longest Solved Word:" + CurrentGamer.LongestWordSolved;
            lblGamesPlayed.Text = "Game Played:" + CurrentGamer.GamePlayed.ToString();
            lblWins.Text = "Wins:" + CurrentGamer.Wins.ToString();
            lblCurrentWinStreak.Text = "Current Win Streak:" + CurrentGamer.CurrentWinStreak.ToString();
            lblLongestWinStreak.Text = "Longest Win Streak:" + CurrentGamer.LongWinStreak.ToString();
        }








        protected void btnPlayAgain_Click(object sender, EventArgs e)
        {
            NewGame();
            pnlNewGame.Visible = false;
        }

      

        private void LoadSecretWord()
        {
            try
            {
                fileAccessor wordbank = new fileAccessor(@"C:\Projects\SD-104-CSharp\Hangman-WebForm\Resources\wordbank.txt");
                SecretWord = wordbank.GetRandomLine();
                SecretWordTiles = new List<string>();
                GuessedWord = new string[SecretWord.Length];

                DisplaySeceretWordTiles();
               
            }
            catch (Exception ex)
            {
                Response.Redirect("default.aspx");
                lblMessage.Text = "Error loading a new word." + ex.ToString();
                pnlNewGame.Visible = true;


               
            }
        }

        private void DisplaySeceretWordTiles()
        {

            SecretWordTiles.Clear();
            pnlWord.Controls.Clear();

            //create picture boxes for the secret word.
            for (int n = 0; n < SecretWord.Length; n++)
            {
                Image nextLetter = new Image();
                nextLetter.ID = "imgWord" + n;

                if (SecretWord[n] == '-')
                {
                    nextLetter.ImageUrl = "./Resources/-.png";
                    
                }
                else
                {
                    nextLetter.ImageUrl = "./Resources/Blank.jpg";
                    
                }
                nextLetter.Width =  60;
                nextLetter.Height = 60;
                pnlWord.Controls.Add(nextLetter);
                SecretWordTiles.Add(nextLetter.ID);
            }

        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
    }

   
        

        

        
    
