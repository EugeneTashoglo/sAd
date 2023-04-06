

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using DurakLibrary;


namespace DurakClient
{
    public partial class DurakClientForm : Form
    {
        //initialize components of the form
        public DurakClientForm()
        {
            InitializeComponent();
 
        }

        //declares all variables
        #region  Declaration of Variables and Game Reset     
        GameDeck myDeck = new GameDeck();
        GameRiver myRiver = new GameRiver();
        static PlayerHand myHandOne = new PlayerHand();
        static PlayerHand myHandTwo = new PlayerHand();
        Player myPlayerOne = new Player("PlayerOne", myHandOne, true, false);
        //Player myPlayerTwo = new Player("PlayerTwo", myHandTwo, false, true);
        PlayerAI myPlayerTwo = new PlayerAI("PlayerTwo", myHandTwo, false, true);
        CardList DeckDisplayList = new CardList();
        CardList HandOneDisplayList = new CardList();
        CardList HandTwoDisplayList = new CardList();
        CardList PlayerOneDisplayList = new CardList();
        CardList PlayerTwoDisplayList = new CardList();
        CardList RiverDisplayList = new CardList();
        CardList trumpCardDisplayList = new CardList();
        CardList discardDisplayList = new CardList();
    

        int deckSize = 52;
        int roundNumber = 0;
        int playerOneWins = 0;
        int playerOneLosses = 0;
        int playerTwoWins = 0;
        int playerTwoLosses = 0;
                
        
        //resets game
        public void ResetGame()
        {
            lblHumanAttacking.Visible = true;
            lblComputerAttacking.Visible = false;
          
            flpDeck.Controls.Clear();
            flpComputerHand.Controls.Clear();
            flpHumanHand.Controls.Clear();
            flpRiver.Controls.Clear();
            flpTrumpCard.Controls.Clear();
         
            CardImageControl startingCardControl = new CardImageControl();
           flpDeck.Controls.Add(startingCardControl);
            myDeck = new GameDeck(deckSize);
            myRiver = new GameRiver();
            myHandOne = new PlayerHand();
            myHandTwo = new PlayerHand();
            myPlayerOne = new Player("PlayerOne", myHandOne, true, false);
            myPlayerTwo = new PlayerAI("PlayerTwo", myHandTwo, false, true);
            DeckDisplayList = new CardList();
            HandOneDisplayList = new CardList();
            HandTwoDisplayList = new CardList();
            PlayerOneDisplayList = new CardList();
            PlayerTwoDisplayList = new CardList();
            RiverDisplayList = new CardList();
            trumpCardDisplayList = new CardList();
            discardDisplayList = new CardList();
            myDeck.Shuffle(deckSize);

     
       
        
      

            btnPickUp.Enabled = false;
            btnCeaseAttack.Enabled = true;

            roundNumber = 0;

        }
        #endregion

        //on form load reset game
        private void DurakClientForm_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        //starts a new game
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
            myDeck.setTrumpCard(myDeck);
            myPlayerOne.RefillHand(myDeck);
            myPlayerTwo.RefillHand(myDeck);
            DisplayAllCardLists();
        }                       
        public void AttackDefendPhase()
        {       
            DisplayAllCardLists();
        }           
        private void Card_Click(object sender, EventArgs e)
        {
            CardImageControl clickedCardControl = new CardImageControl();
            clickedCardControl = (CardImageControl)sender;
                           
            if (myPlayerTwo.getIsDefending() == true)
            {
                myPlayerOne.AttackingPhase(myRiver, (clickedCardControl.Card));

                myPlayerTwo.DefendingPhase(myRiver, myDeck.getTrumpCard());

                if (myPlayerTwo.getIsDefending() == false)
                {
                    roundNumber +=  1;

               


                    for (int i = 0; i < myRiver.length(); i++)
                    {
                        myHandTwo.AddCardToHand(myRiver.GetCard(i));
                    }
                    myRiver.ClearRiver();
                    lblComputerAttacking.Visible = true;
                    lblHumanAttacking.Visible = false;
                    try
                    {
                        myPlayerOne.RefillHand(myDeck);
                        myPlayerTwo.RefillHand(myDeck);
                    }
                    catch (Exception)
                    {
                
                    }

                    btnPickUp.Enabled = true;
                    btnCeaseAttack.Enabled = false;

                    myPlayerTwo.AttackingPhase(myRiver);
                }
            }
            //human is defending, from computer attacks
            else
            {                
                myPlayerOne.DefendingPhase(myRiver, myDeck.getTrumpCard(), (clickedCardControl.Card));
                myPlayerTwo.AttackingPhase(myRiver);

                //if human no longer defending, round over and reset, computer is now defending
                if (myPlayerTwo.getIsDefending() == true)
                {
                    roundNumber += 1;

           

                    for (int i = 0; i < myRiver.length(); i++)
                    {
                        discardDisplayList.Add(myRiver.GetCard(i));
                    }
                    myRiver.ClearRiver();
                    lblComputerAttacking.Visible = false;
                    lblHumanAttacking.Visible = true;
                    try
                    {
                        myPlayerOne.RefillHand(myDeck);
                        myPlayerTwo.RefillHand(myDeck);
                    }
                    catch (Exception)
                    {

                    }
                    btnPickUp.Enabled = false;
                    btnCeaseAttack.Enabled = true;
                }

            }
             
            DisplayAllCardLists();
            //logs who won the game and win/loss ratios
            if (myPlayerOne.getHand().length() == 0)
            {
                playerOneWins += 1;
                playerTwoLosses += 1;
                MessageBox.Show("Игра окончена вы победили");
            
                ResetGame();
            }

            if (myPlayerTwo.getHand().length() == 0)
            {
                playerTwoWins += 1;
                playerOneLosses += 1;
                MessageBox.Show("Игра окончена вы проиграли");

                ResetGame();
            }          
        }


        //will display all card lists on the windows form
        public void DisplayAllCardLists()
        {
            DisplayPlayerOneCards();
            DisplayPlayerTwoCards();
            DisplayRiverCards();

          
         
    
            DisplayTrumpCards();
            DisplayDiscardCards();
        }

        //displays discard cards
        public void DisplayDiscardCards()
        {
            if (discardDisplayList.Count() > 0)
            {
                CardImageControl startingCardControl = new CardImageControl();
             
            }
        }

        //displays trump card
        public void DisplayTrumpCards()
        {
            flpTrumpCard.Controls.Clear();
            trumpCardDisplayList.Clear();

            for (int i = 0; i < 1; i++)
            {
                trumpCardDisplayList.Add(myDeck.getTrumpCard());
            }
            foreach (Card card in trumpCardDisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flpTrumpCard.Controls.Add(myCardControl);

            }
        }

        //displays player one cards
        public void DisplayPlayerOneCards()
        {
            //PlayerOne Display Cards

            flpHumanHand.Controls.Clear();
            PlayerOneDisplayList.Clear();

            for (int i = 0; i < myPlayerOne.getHand().length(); i++)
            {
                PlayerOneDisplayList.Add(myPlayerOne.getHand().GetCard(i));
            }
            foreach (Card card in PlayerOneDisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flpHumanHand.Controls.Add(myCardControl);

               //stores a card click event method for each card 
               myCardControl.CardClicked += new EventHandler(Card_Click);
            }
        }

        //displays player two cards
        public void DisplayPlayerTwoCards()
        {
            //PlayerTwo Display Cards

            flpComputerHand.Controls.Clear();
            PlayerTwoDisplayList.Clear();

            for (int i = 0; i < myPlayerTwo.getHand().length(); i++)
            {
                PlayerTwoDisplayList.Add(myPlayerTwo.getHand().GetCard(i));
            }
            foreach (Card card in PlayerTwoDisplayList)
            {

                CardImageControl startingCardControl = new CardImageControl();
                flpComputerHand.Controls.Add(startingCardControl);

            }
        }

        //displays river cards
        public void DisplayRiverCards()
        {
            //River Display Cards

            flpRiver.Controls.Clear();
            RiverDisplayList.Clear();

            for (int i = 0; i < myRiver.length(); i++)
            {
                RiverDisplayList.Add(myRiver.GetCard(i));
            }
            foreach (Card card in RiverDisplayList)
            {
                CardImageControl myCardControl = new CardImageControl();
                myCardControl.Card = card;
                flpRiver.Controls.Add(myCardControl);
            }
        }

        //button pickup clicked ends human turn and picks up cards
        private void btnPickUp_Click(object sender, EventArgs e)
        {
            roundNumber += 1;



            for (int i = 0; i < myRiver.length(); i++)
            {
                myHandOne.AddCardToHand(myRiver.GetCard(i));
            }
            myRiver.ClearRiver();
            try
            {


                myPlayerOne.RefillHand(myDeck);
                myPlayerTwo.RefillHand(myDeck);
            }
            catch (Exception)
            {

            }

            myPlayerTwo.setIsDefending(true);


            lblComputerAttacking.Visible = false;
            lblHumanAttacking.Visible = true;

            btnPickUp.Enabled = false;
            btnCeaseAttack.Enabled = true;

            DisplayAllCardLists();

            
        }

        private void btnCeaseAttack_Click(object sender, EventArgs e)
        {
            roundNumber += 1;

     

            for (int i = 0; i < myRiver.length(); i++)
            {
                discardDisplayList.Add(myRiver.GetCard(i));
            }
            myRiver.ClearRiver();
            try
            {
                myPlayerOne.RefillHand(myDeck);
                myPlayerTwo.RefillHand(myDeck);
            }
            catch (Exception)
            {

            }

            myPlayerTwo.setIsDefending(false);

            lblComputerAttacking.Visible = true;
            lblHumanAttacking.Visible = false;

            btnPickUp.Enabled = true;
            btnCeaseAttack.Enabled = false;

            myPlayerTwo.AttackingPhase(myRiver);

            DisplayAllCardLists();
                 
        }

        //52 deck
        private void btn52Deck_Click(object sender, EventArgs e)
        {
            deckSize = 52;
            myDeck = new GameDeck(deckSize);
            ResetGame();
        }

        private void txtDeckCardsRemaining_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
