using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackFirst
{
    class Program
    {
        static void Main(string[] args) //card objects
        {
            Card twoClubs = new Card(1, "Two of Clubs", 2, true);  // public Card(int cardNum, string cardID, int rank, bool inDrawDeck) 
            Card twoDiamonds = new Card(2, "Two of Diamonds", 2, true);
            Card twoHearts = new Card(3, "Two of Hearts", 2, true);
            Card twoSpades = new Card(4, "Two of Spades", 2, true);
            Card threeClubs = new Card(5, "Three of Clubs", 3, true);
            Card threeDiamonds = new Card(6, "Three of Diamonds", 3, true);
            Card threeHearts = new Card(7, "Three of Hearts", 3, true);
            Card threeSpades = new Card(8, "Three of Spades", 3, true);
            Card fourClubs = new Card(9, "Four of Clubs", 4, true);
            Card fourDiamonds = new Card(10, "Four of Diamonds", 4, true);
            Card fourHearts = new Card(11, "Four of Hearts", 4, true);
            Card fourSpades = new Card(12, "Four of Spades", 4, true);
            Card fiveClubs = new Card(13, "Five of Clubs", 5, true);
            Card fiveDiamonds = new Card(14, "Five of Diamonds", 5, true);
            Card fiveHearts = new Card(15, "Five of Hearts", 5, true);
            Card fiveSpades = new Card(16, "Five of Spades", 5, true);
            Card sixClubs = new Card(17, "Six of Clubs", 6, true);
            Card sixDiamonds = new Card(18, "Six of Diamonds", 6, true);
            Card sixHearts = new Card(19, "Six of Hearts", 6, true);
            Card sixSpades = new Card(20, "Six of Spades", 6, true);
            Card sevenClubs = new Card(21, "Seven of Clubs", 7, true);
            Card sevenDiamonds = new Card(22, "Seven of Diamonds", 7, true);
            Card sevenHearts = new Card(23, "Seven of Hearts", 7, true);
            Card sevenSpades = new Card(24, "Seven of Spades", 7, true);
            Card eightClubs = new Card(25, "Eight of Clubs", 8, true);
            Card eightDiamonds = new Card(26, "Eight of Diamonds", 8, true);
            Card eightHearts = new Card(27, "Eight of Hearts", 8, true);
            Card eightSpades = new Card(28, "Eight of Spades", 8, true);
            Card nineClubs = new Card(29, "Nine of Clubs", 9, true);
            Card nineDiamonds = new Card(30, "Nine of Diamonds", 9, true);
            Card nineHearts = new Card(31, "Nine of Hearts", 9, true);
            Card nineSpades = new Card(32, "Nine of Spades", 9, true);
            Card tenClubs = new Card(33, "Ten of Clubs", 10, true);
            Card tenDiamonds = new Card(34, "Ten of Diamonds", 10, true);
            Card tenHearts = new Card(35, "Ten of Hearts", 10, true);
            Card tenSpades = new Card(36, "Ten of Spades", 10, true);
            Card jackClubs = new Card(37, "Jack of Clubs", 10, true);
            Card jackDiamonds = new Card(38, "Jack of Diamonds", 10, true);
            Card jackHearts = new Card(39, "Jack of Hearts", 10, true);
            Card jackSpades = new Card(40, "Jack of Spades", 10, true);
            Card queenClubs = new Card(41, "Queen of Clubs", 10, true);
            Card queenDiamonds = new Card(42, "Queen of Diamonds", 10, true);
            Card queenHearts = new Card(43, "Queen of Hearts", 10, true);
            Card queenSpades = new Card(44, "Queen of Spades", 10, true);
            Card kingClubs = new Card(45, "King of Clubs", 10, true);
            Card kingDiamonds = new Card(46, "King of Diamonds", 10, true);
            Card kingHearts = new Card(47, "King of Hearts", 10, true);
            Card kingSpades = new Card(48, "King of Spades", 10, true);
            Card aceClubs = new Card(49, "Ace of Clubs", 11, true);
            Card aceDiamonds = new Card(50, "Ace of Diamonds", 11, true);
            Card aceHearts = new Card(51, "Ace of Hearts", 11, true);
            Card aceSpades = new Card(52, "Ace of Spades", 11, true);



            int playerHand;
            int dealerHand;
            int showingDealerHand;
            float playerBet;
            char roundOutcome = 'c';
            char halHelp = 'c';
            int playerUnconvertedAces = 0;
            int dealerUnconvertedAces = 0;
            string dealerFaceDownCard;
            string dealerPronoun;
            int rankOfFirstCard;
            int rankOfSecondCard;
            float splitBet;
            int firstSplitHand;
            int splitHandState;
            string stringOfFirstCard;
            string stringOfSecondCard;
            int numberOfDoubles;
            float doubleBet;
            float doubleBet2;
            float firstBet;
            float secondBet;



            int dealerYChromosomes = GetGirlOrBoy();  // Dealer Gender, randomized one per program
            if (dealerYChromosomes == 0)
            {
                dealerPronoun = "her";
            }
            else
                dealerPronoun = "his";

            // ------- FULL SIT-DOWN SESSION UNTIL PLAYER QUITS -------
            while (true)
            {
                Console.WriteLine("\nHello there!  Welcome to the game of GlattJack!  It's just like BlackJack!\n\n");
                Console.WriteLine("Proceed through the program by pressing ENTER and by answering questions.");
                Console.WriteLine("\nPress ENTER now.");

                Console.ReadKey();

                Console.WriteLine("\n\nMeet my friend Hal.  He can help you make the best decisions if you'd like!\n");
                HalCheckpoint:
                Console.WriteLine("Hal says: \"Would you like my help?  Press 'y' for yes or 'n' for no.\"");
                if (char.TryParse(Console.ReadLine(), out halHelp))
                {
                    if (halHelp == 'y' || halHelp == 'n')
                    {
                        Console.WriteLine("\nHal says: \"Okay.\"");
                        goto CasinoCheckpoint;
                    }
                    else
                    {
                        Console.WriteLine("\nHal says: \"I'm sorry, I'm afraid I can't understand that.\"\n");
                        goto HalCheckpoint;
                    }

                }
                else
                {
                    Console.WriteLine("\nHal says: \"I'm sorry, I'm afraid I can't understand that.\"\n");
                    goto HalCheckpoint;
                }

                CasinoCheckpoint:
                float playerCash = GetPlayerCash();
                float dealerCash = GetDealerCash();

                //below is array of objects for selecting cards
                Card[] cards = { twoClubs, twoDiamonds, twoHearts, twoSpades, threeClubs, threeDiamonds,
                threeHearts, threeSpades, fourClubs, fourDiamonds, fourHearts,
                fourSpades, fiveClubs, fiveDiamonds, fiveHearts, fiveSpades, sixClubs, sixDiamonds, sixHearts,
                sixSpades, sevenClubs, sevenDiamonds, sevenHearts, sevenSpades, eightClubs, eightDiamonds, eightHearts,
                eightSpades, nineClubs, nineDiamonds, nineHearts, nineSpades, tenClubs, tenDiamonds, tenHearts, tenSpades,
                jackClubs, jackDiamonds, jackHearts, jackSpades, queenClubs, queenDiamonds, queenHearts, queenSpades,
                kingClubs, kingDiamonds, kingHearts, kingSpades, aceClubs, aceDiamonds, aceHearts, aceSpades};

                // ------- A FULL ROUND LOOP UNTIL SOMEONE BANKRUPTS -------  
                while (playerCash > 0 && dealerCash > 0) // Grabbing total chips from player and dealer.  They both need chips to play.
                {
                    playerHand = 0;
                    dealerHand = 0;
                    showingDealerHand = 0;
                    dealerFaceDownCard = "string";
                    roundOutcome = 'N';
                    playerUnconvertedAces = 0;
                    dealerUnconvertedAces = 0;
                    rankOfFirstCard = 0; //split
                    rankOfSecondCard = 0;  //split
                    splitHandState = 0;
                    firstSplitHand = 0;
                    stringOfFirstCard = "string";
                    stringOfSecondCard = "string";
                    numberOfDoubles = 0;
                    doubleBet = 0;
                    doubleBet2 = 0;
                    firstBet = 0;
                    secondBet = 0;



                    BetInputCheckpoint:
                    Console.WriteLine("You have " + playerCash + " total chips and the dealer has " + dealerCash + ".  \nHow many would you like to bet?"); // Primmer Proof
                    if (float.TryParse(Console.ReadLine(), out playerBet))
                    {
                    }
                    else
                    {
                        Console.WriteLine("\nThat's not money...");
                        goto BetInputCheckpoint;
                    }


                    // ------- ENSURE PLAYER'S BET IS LEGAL ------- 
                    if (playerBet > playerCash && playerBet <= dealerCash)
                    {
                        Console.WriteLine("\nYou don't have enough.  \nYou put your whole stack of " + playerCash + " chips on the table.");
                        playerBet = playerCash;
                        Console.ReadKey();
                    }
                    else if (playerBet <= playerCash && playerBet > dealerCash)
                    {
                        Console.WriteLine("\nThe dealer doesn't have that much.  \nYou bring your bet down to " + dealerCash + " chips to match " + dealerPronoun + " bank.");
                        playerBet = dealerCash;
                        Console.ReadKey();
                    }
                    else if (playerBet > playerCash && playerBet > dealerCash)
                    {
                        Console.WriteLine("\nNeither of you have that amount.");
                        if (playerCash > dealerCash)
                        {
                            Console.WriteLine("The dealer has less.  You bring your bet down to " + dealerCash + " chips to match " + dealerPronoun + " bank.");
                            playerBet = dealerCash;
                            Console.ReadKey();
                        }
                        if (playerCash < dealerCash)
                        {
                            Console.WriteLine("You have less.  You put your whole stack of " + playerCash + " chips on the table.");
                            playerBet = playerCash;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You both have " + playerCash + " available chips.  You are both all in!");
                            playerBet = playerCash;
                            Console.ReadKey();
                        }
                    }


                    Console.WriteLine("\n");

                    Random randCard = new Random();

                    // ------- SHUFFLE ------- 
                    foreach (var card in cards)
                    {
                        card.inDrawDeck = true;
                    }


                    // ------- PLAYER'S FIRST DRAWING LOOP ------- 
                    PlayerFirstDrawLoop:
                    int a = 1;
                    while (a <= 2) //  draw two cards     
                    {
                        var appearingCard = cards[randCard.Next(0, 52)];
                        if (appearingCard.inDrawDeck == true)
                        {
                            Console.WriteLine("You draw the " + appearingCard.cardID);
                            if (appearingCard.cardNum >= 49) //  For Aces to the player
                            {
                                playerUnconvertedAces++;
                                //Console.WriteLine("You got an Ace, watch it closely!\n");  // DEBUG TEXT
                            }
                            appearingCard.inDrawDeck = false;
                            playerHand += appearingCard.rank;  //add rank to playerhand

                            if (a == 1 && splitHandState == 0) // if, else-if for the split.  These set the individual cards to be comparred later.
                            {
                                rankOfFirstCard = appearingCard.rank;
                                stringOfFirstCard = appearingCard.cardID;
                            }
                            else if (a == 2 && splitHandState == 0)
                            {
                                rankOfSecondCard = appearingCard.rank;
                                stringOfSecondCard = appearingCard.cardID;
                            }

                            if (splitHandState == 1)// This should skip the second iteration of the loop with a card already in hand from split
                            {
                                Console.WriteLine("Added to your " + stringOfFirstCard + ", your hand total is: " + playerHand + ".\n");
                                Console.ReadKey();
                                a++;
                            }
                            else if (splitHandState == 2)// This should skip the second iteration of the loop with a card already in hand from split
                            {
                                Console.WriteLine("Added to your " + stringOfSecondCard + ", your hand total is: " + playerHand + ".\n");
                                Console.ReadKey();
                                a++;
                            }

                            a++;

                        }
                        if (playerHand == 21)
                            goto BlackJack;
                    }

                    if (splitHandState != 0) // If we have split and made it out of the player draw loop, go to player decision
                        goto PlayerDecision;

                    Console.WriteLine("Your hand total is:  " + playerHand + ".\n");
                    Console.ReadKey();


                    // ------- DEALER FIRST DRAWING LOOP -------
                    int b = 0;
                    while (b <= 1)
                    {
                        while (b == 0) // Dealer draws face up card
                        {
                            var appearingCard = cards[randCard.Next(0, 52)]; /////////////// //////////////// ///////////////// //////////////// /////////////// ///////////////// //////////////
                            if (appearingCard.inDrawDeck == true) // if card still in deck
                            {
                                Console.WriteLine("Dealer's face-up card: " + appearingCard.cardID);
                                if (appearingCard.cardNum >= 49) // (Level 4) For Aces to the dealer
                                {
                                    dealerUnconvertedAces++;
                                }
                                appearingCard.inDrawDeck = false;
                                dealerHand += appearingCard.rank;
                                showingDealerHand = appearingCard.rank;
                                b++;
                            }

                        }

                        if (b == 1) // Dealer draws face down card
                        {
                            var appearingCard = cards[randCard.Next(0, 52)];
                            if (appearingCard.inDrawDeck == true) // if card still in deck
                            {
                                if (appearingCard.cardNum >= 49)
                                {
                                    dealerUnconvertedAces++;
                                }
                                appearingCard.inDrawDeck = false;
                                dealerHand += appearingCard.rank;  //add rank to dealerHand
                                //Console.WriteLine("COMMENT: Facedown card is " + appearingCard.cardID + " and real hand is " + dealerHand); // DEBUG TEXT FOR TESTING ONLY
                                dealerFaceDownCard = appearingCard.cardID;  //so the player can see the face down card when the dealer flips it.                              
                                b++;
                            }
                        }
                    }

                    Console.WriteLine("Dealer's hand showing: " + showingDealerHand + "\n");
                    Console.ReadKey();

                    // ------- INSURANCE -------
                    if (showingDealerHand == 11)  // PostFix: Make for Aces and not all face cards (BlackJack mistake)
                    {
                        InsuranceQuestion:
                        Console.WriteLine("Would you like to buy Insurance?  Press 'y' or 'n.'");
                        Console.WriteLine("Insurance wager is half your bet and you win a full bet if dealer has BlackJack.");
                        if (halHelp == 'y')
                            Console.WriteLine("Hal:  \"I recommend you don't buy insurance.\"");

                        char insuranceChar;
                        if (char.TryParse(Console.ReadLine(), out insuranceChar))
                        {
                            if (insuranceChar == 'n')
                                goto AfterInsurance;
                            else if (insuranceChar == 'y')
                            {
                                float insuranceBet = (0.5f * playerBet);
                                Console.WriteLine("\nYou put " + insuranceBet + " down, betting on a dealer BlackJack.");
                                playerCash -= insuranceBet;  // PostFix: Add line to properly charge for insurance

                                Console.ReadKey();
                                if (dealerHand == 21)
                                {
                                    Console.ReadKey();
                                    Console.WriteLine("\nDealer checks for BlackJack...\n");
                                    Console.WriteLine("Dealer flips over the " + dealerFaceDownCard + " for a BlackJack\n");
                                    if (insuranceChar == 'y') // PostFix: pay player properly for BlackJack insurance
                                    {
                                        Console.WriteLine("You get your insurance wager back plus " + playerBet + " chips.");
                                        playerCash = playerCash + (insuranceBet + playerBet);
                                    }
                                    Console.ReadKey();
                                    goto MainHandWinLose;
                                }

                            }
                            else
                            {
                                Console.WriteLine("\nJust 'y' or 'n' please.\n");
                                goto InsuranceQuestion;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nJust 'y' or 'n' please.\n");
                            goto InsuranceQuestion;
                        }
                        Console.ReadKey();
                    }

                    AfterInsurance:
                    // ------- DEALER CHECKS FOR THEIR BLACKJACK -------
                    if (showingDealerHand >= 10)
                    {
                        Console.WriteLine("\nDealer checks for BlackJack...\n");
                        Console.ReadKey();
                        if (dealerHand == 21)
                        {
                            Console.WriteLine("Dealer flips over the " + dealerFaceDownCard + " for a BlackJack");
                            Console.ReadKey();
                            goto MainHandWinLose;
                        }
                        else
                            Console.WriteLine("Dealer doesn't have BlackJack.  The game continues...");
                        Console.ReadKey();
                    }



                    if (rankOfFirstCard == rankOfSecondCard)  // if cards can be split...
                    {
                        if ((playerCash - playerBet) < playerBet) // if player can't afford to split...
                        {
                            Console.WriteLine("You have two cards of the same value,\nbut you don't have enough chips to split.\n");
                        }
                        else
                        {
                            SplitCheckpoint:
                            Console.WriteLine("\nYour hand total is:  " + playerHand);
                            Console.WriteLine("Dealer hand showing: " + showingDealerHand);
                            Console.WriteLine("You have two cards of the same value.\nWould you like to split?  Press \"y\" or \"n.\""); // PrimmerProofed

                            if (halHelp == 'y')
                            {
                                // AFTER PROGRAM THOUGHT:  SWITCH WITH CASES WOULD HAVE BEEN BETTER

                                if (rankOfFirstCard == 2 && (showingDealerHand >= 4 && showingDealerHand <= 7)) // dealer up card between 4-7
                                    Console.WriteLine("Hal: \"I recommend you Split.\"");
                                else if (rankOfFirstCard == 2) // rest of pairs of 2's
                                    Console.WriteLine("Hal: \"I recommend you Hit.\"");
                                else if (rankOfFirstCard == 3 && (showingDealerHand >= 4 && showingDealerHand <= 7)) // 4-7
                                    Console.WriteLine("Hal: \"I recommend you Split.\"");
                                else if (rankOfFirstCard == 3) // rest of pairs of 3's
                                    Console.WriteLine("Hal: \"I recommend you Hit.\"");
                                else if (rankOfFirstCard == 4)  // all pairs of 4's
                                    Console.WriteLine("Hal: \"I recommend you Hit.\"");
                                else if (rankOfFirstCard == 5 && (showingDealerHand >= 10)) // 10 or Ace
                                    Console.WriteLine("Hal: \"I recommend you Hit.\"");
                                else if (rankOfFirstCard == 5) // rest of pairs of 5's
                                    Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                                else if (rankOfFirstCard == 6 && (showingDealerHand >= 3 && showingDealerHand <= 6)) // 3-6
                                    Console.WriteLine("Hal: \"I recommend you Split.\"");
                                else if (rankOfFirstCard == 6) // rest of pairs of 6's
                                    Console.WriteLine("Hal: \"I recommend you Hit.\"");
                                else if (rankOfFirstCard == 7 && showingDealerHand >= 8) // 8+
                                    Console.WriteLine("Hal: \"I recommend you Hit.\"");
                                else if (rankOfFirstCard == 7) // rest of pairs of 7's
                                    Console.WriteLine("Hal: \"I recommend you Split.\"");
                                else if (rankOfFirstCard == 8) // all pairs of 8's
                                    Console.WriteLine("Hal: \"I recommend you Split.\"");
                                else if (rankOfFirstCard == 9 && (showingDealerHand == 7 || showingDealerHand >= 10)) // 7, 10, or Ace
                                    Console.WriteLine("Hal: \"I recommend you Stand.\"");
                                else if (rankOfFirstCard == 9) // rest of pairs of 7's
                                    Console.WriteLine("Hal: \"I recommend you Split.\"");
                                else if (rankOfFirstCard == 10) // all pairs of 10's
                                    Console.WriteLine("Hal: \"I recommend you Stand.\"");
                                else if (rankOfFirstCard == 11) // all pairs of Aces
                                    Console.WriteLine("Hal: \"I recommend you Split.\"");
                            }

                            char splitChar;
                            if (char.TryParse(Console.ReadLine(), out splitChar))
                            {
                                if (splitChar == 'n')
                                {
                                    Console.WriteLine("\nYour hand total is:  " + playerHand);
                                    Console.WriteLine("Dealer hand showing: " + showingDealerHand + "\n");
                                    goto PlayerDecision;
                                }
                                else if (splitChar == 'y')
                                {
                                    Console.WriteLine("\nYou split your hand.");
                                    splitBet = playerBet;    // two bets of the same value
                                    playerHand = rankOfFirstCard;  // your hand now equals your first card
                                    firstSplitHand = playerHand;   // your split hand also equals that same amount                         
                                    splitHandState = 1;  // It will move to 2 in SplitFinish, which will allow for a second round of hitting.
                                    goto PlayerFirstDrawLoop;
                                }
                                else
                                {
                                    Console.WriteLine("\nJust 'y' or 'n' please.\n");
                                    goto SplitCheckpoint;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nJust 'y' or 'n' please.\n");
                                goto SplitCheckpoint;
                            }
                        }
                    }

                    // ------- PLAYER DECISIONS STAGE -------
                    PlayerDecision:
                    while (true) // (Level 3)
                    {
                        Console.WriteLine("\nYour hand total is:  " + playerHand);
                        Console.WriteLine("Dealer hand showing: " + showingDealerHand + "\n");
                        Console.WriteLine("Press \"h\" to Hit, \"s\" to Stand, \"d\" to Double Down."); // Primmer Proofed  REMOVETEXT

                        if (halHelp == 'y' && playerUnconvertedAces == 0) // These are "hard" hand with no Aces
                        {
                            // AFTER PROGRAM THOUGH:  SWITCH WITH CASES WOULD HAVE BEEN BETTER

                            if (playerHand >= 5 && playerHand <= 8) // all  player hands of 5-8
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 9 && (showingDealerHand >= 3 && showingDealerHand <= 6)) // dealer card is 3-6
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 9) // rest of 9 hands
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 10 && showingDealerHand >= 10) // dealer card is 10's and Aces
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 10) // rest of 10 hands
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 11) // all 11 hands
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 12 && (showingDealerHand >= 4 && showingDealerHand <= 6)) // dealer card 4-6
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                            else if (playerHand == 12) // rest of 12 hands
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 13 && showingDealerHand >= 7) // dealer card 7+
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 13) // rest of 13 hands
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                            else if (playerHand == 14 && showingDealerHand >= 7) // dealer card 7+
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 14) // rest of 14 hands
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                            else if (playerHand == 15 && showingDealerHand >= 7) // dealer card 7+
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 15) // rest of 15 hands
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                            else if (playerHand == 16 && showingDealerHand >= 7) // dealer card 7+ (could have combined playerHand counts 13-16 but this is more consistent)
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 16) // rest of 16 hands
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                            else if (playerHand == 17) // all 17 hands
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                            else if (playerHand <= 4)  // remainder, less than 5
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand >= 18)  // remainder, less than 5
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");


                        }
                        else if (halHelp == 'y' && playerUnconvertedAces > 0) // These are "soft" hands with one or more Aces
                        {
                            // AFTER PROGRAM THOUGH:  SWITCH WITH CASES WOULD HAVE BEEN BETTER

                            if (playerHand == 13 && (showingDealerHand >= 5 && showingDealerHand <= 6)) // dealer card 5-6
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 13) // rest of 13 hands
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 14 && (showingDealerHand >= 5 && showingDealerHand <= 6)) // dealer card 5-6
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 14) // rest of 14 hands
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 15 && (showingDealerHand >= 4 && showingDealerHand <= 6)) // dealer card 4-6
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 15) // rest of 15 hands
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 16 && (showingDealerHand >= 4 && showingDealerHand <= 6)) // dealer card 4-6
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 16) // rest of 16 hands
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 17 && (showingDealerHand >= 3 && showingDealerHand <= 6)) // dealer card 3-6
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 17) // rest of 17 hands
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 18 && showingDealerHand >= 9) // dearler card 9+
                                Console.WriteLine("Hal: \"I recommend you Hit.\"");
                            else if (playerHand == 18 && showingDealerHand <= 6) // dealer card 6 and lower
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 18) // rest of 18 hands (7-8)
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                            else if (playerHand == 19 && showingDealerHand == 6) // dealer card 6
                                Console.WriteLine("Hal: \"I recommend you Double Down.\"");
                            else if (playerHand == 19) // rest of 19 hands
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                            else if (playerHand == 20) // all 20 hands
                                Console.WriteLine("Hal: \"I recommend you Stand.\"");
                        }

                        char playerDecision;

                        if (char.TryParse(Console.ReadLine(), out playerDecision))
                        {
                            if (playerDecision == 'h') // HIT
                            {
                                int x = 0;
                                while (x < 1)  //this loop is to ensure we get a card from draw deck
                                {
                                    var appearingCard = cards[randCard.Next(0, 52)];
                                    if (appearingCard.inDrawDeck == true) // if card still in deck                      
                                    {
                                        Console.WriteLine("\nYou Hit and draw: " + appearingCard.cardID);
                                        if (appearingCard.cardNum >= 49) // (Level 4) For Aces to the player                                       
                                            playerUnconvertedAces++;

                                        appearingCard.inDrawDeck = false;
                                        playerHand += appearingCard.rank;
                                        x++;
                                    }
                                }

                                if (playerHand > 21) // (Level 5)
                                {
                                    if (playerUnconvertedAces > 0) // (Level 6) If busted and have an unconverted ace, it will drop
                                    {
                                        playerHand -= 10;
                                        playerUnconvertedAces -= 1;
                                        Console.WriteLine("Your Ace drops from 11 to 1.");
                                    }

                                    else
                                    {
                                        roundOutcome = 'L'; //Lose
                                        Console.WriteLine("Your hand total is:  " + playerHand);
                                        Console.WriteLine("Sorry, you busted. \n");
                                        Console.ReadKey();
                                        break;
                                    }
                                }
                                else if (playerHand == 21)
                                {
                                    Console.WriteLine("The dealer leaves your hand at 21.\n");
                                    Console.ReadKey();
                                    break;
                                }

                                //Console.WriteLine("Your hand total is:  " + playerHand);                  // results in two printouts (because we go back to loop beginning)
                                //Console.WriteLine("Dealer hand showing: " + showingDealerHand + "\n");
                            }
                            else if (playerDecision == 's') // Stand
                            {
                                Console.WriteLine("\nYou Stand with: " + playerHand + "\n");
                                goto PostPlayerDecision;
                            }
                            else if (playerDecision == 'd')  // DOUBLE DOWN
                                if ((playerCash - playerBet) < playerBet) // if player can't afford double down
                                {
                                    Console.WriteLine("\nYou cannot afford to double down.");
                                    goto PlayerDecision;
                                }
                                else
                                {
                                    if (splitHandState == 1)
                                        doubleBet = playerBet * 2f; //double only one of the split hands, not the base "playerBet"
                                    else if (splitHandState == 2)
                                        doubleBet2 = playerBet * 2f;
                                    else
                                        playerBet = playerBet * 2f; // double the bet

                                    int x = 0;
                                    while (x < 1)  //this loop is to ensure we get a card from draw deck
                                    {
                                        var appearingCard = cards[randCard.Next(0, 52)];
                                        if (appearingCard.inDrawDeck == true) // if card still in deck                                     
                                        {
                                            Console.WriteLine("\nYou Double Down your bet and get one card, the " + appearingCard.cardID);
                                            if (appearingCard.cardNum >= 49) // (Level 4) For Aces to the player
                                            {
                                                playerUnconvertedAces++;
                                            }
                                            appearingCard.inDrawDeck = false;
                                            playerHand += appearingCard.rank;  // ISSUE TO FIX: If starting with an Ace, this can give a false bust
                                            Console.WriteLine("Your hand total is:  " + playerHand + "\n");
                                            Console.ReadKey();
                                            x++;  // loop only terminates
                                        }
                                    }
                                    numberOfDoubles++;
                                    break; // doubling down ends the player decision stage loop
                                }

                            else
                            {
                                Console.WriteLine("\nNo funny business!  May I remind you that this game is on camera?\n");
                                goto PlayerDecision;
                            }


                        }
                        else
                        {
                            Console.WriteLine("\nNo funny business!  May I remind you that this game is on camera?\n");
                            goto PlayerDecision;
                        }
                    }

                    PostPlayerDecision:
                    if (splitHandState == 1)
                    {
                        splitHandState = 2;
                        firstSplitHand = playerHand;
                        playerHand = rankOfSecondCard;
                        goto PlayerFirstDrawLoop;
                    }

                    // ------- DEALER DECISIONS STAGE -------
                    if (roundOutcome == 'L' && splitHandState == 0)
                        goto Lose;


                    Console.WriteLine("Dealer flips over " + dealerPronoun + " face down card.  It's the " + dealerFaceDownCard);
                    Console.WriteLine("Dealer hand: " + dealerHand + "\n");
                    Console.ReadKey();

                    while (true)
                    {
                        if (dealerHand >= 18 && dealerHand <= 21)  // dealer Stands on 18 or more  
                        {
                            Console.WriteLine("Dealer Stands on " + dealerHand + "\n");
                            Console.ReadKey();
                            break;
                        }

                        else if (dealerHand == 17)
                        {
                            if (dealerUnconvertedAces > 0)  //dealer must hit on soft 17  
                            {
                                int x = 0;
                                while (x < 1)
                                {
                                    var appearingCard = cards[randCard.Next(0, 52)];
                                    if (appearingCard.inDrawDeck == true)
                                    {
                                        Console.WriteLine("Dealer's new card: " + appearingCard.cardID);
                                        if (appearingCard.cardNum >= 49) // For Aces to the dealer
                                        {
                                            dealerUnconvertedAces++;
                                        }
                                        appearingCard.inDrawDeck = false;
                                        dealerHand += appearingCard.rank;
                                        showingDealerHand = appearingCard.rank;
                                        x++;
                                    }
                                }
                                //dealerUnconvertedAces--; //dealer uses up an ace conversion                                   IS THIS RIGHT? WHAT IF DRAW A 2
                            }
                            else
                            {
                                Console.WriteLine("Dealer Stands on " + dealerHand + "\n");
                                break;

                            }

                        }
                        else if (dealerHand <= 16)
                        {
                            while (dealerHand <= 16)
                            {
                                int x = 0;
                                while (x < 1)
                                {
                                    var appearingCard = cards[randCard.Next(0, 52)];
                                    if (appearingCard.inDrawDeck == true)
                                    {
                                        Console.WriteLine("Dealer's new card: " + appearingCard.cardID);
                                        if (appearingCard.cardNum >= 49) //  For Aces to the dealer
                                        {
                                            dealerUnconvertedAces++;
                                            //    Console.WriteLine("COMENT: dealer has " + dealerUnconvertedAces + " unconverted aces."); // DEBUG TEXT
                                        }
                                        appearingCard.inDrawDeck = false;
                                        dealerHand += appearingCard.rank;
                                        Console.WriteLine("Dealer's hand: " + dealerHand + "\n");
                                        Console.ReadKey();
                                        x++;
                                    }
                                }
                            }
                        }

                        else if (dealerHand > 21)
                        {
                            if (dealerUnconvertedAces > 0) // (Level 6) If busted and have an unconverted ace, it will drop
                            {
                                //Console.WriteLine("COMENT: dealer has " + dealerUnconvertedAces + " unconverted aces.");  // DEBUG TEXT
                                dealerHand -= 10;
                                dealerUnconvertedAces -= 1;
                                Console.WriteLine("Dealer's Ace drops from 11 to 1.");
                                Console.WriteLine("Delaer's hand becomes: " + dealerHand);
                                //break;
                            }
                            else
                            {
                                Console.WriteLine("Dealer busts with hand: " + dealerHand);
                                if (splitHandState == 2)
                                    goto SplitWin;
                                goto Win;
                            }

                        }
                    }

                    if (splitHandState == 2)
                    {
                        if (firstSplitHand > 21)
                            goto SplitLose;
                        else if ((firstSplitHand <= 21) && (firstSplitHand > dealerHand || dealerHand > 21))  // have to change this logic if allowing a second player
                            goto SplitWin;
                        else if ((firstSplitHand < dealerHand) && dealerHand <= 21)
                            goto SplitLose;
                        else if (firstSplitHand == dealerHand)
                            goto SplitPush;
                    }


                    MainHandWinLose:  //only called after the first split hand is evaluated
                    if ((playerHand > dealerHand && playerHand <= 21) || dealerHand > 21)  // have to change this logic if allowing a second player
                        goto Win;
                    else if (playerHand < dealerHand && dealerHand <= 21)
                        goto Lose;
                    else if (playerHand == dealerHand)
                        goto Push;


                    Win:
                    {

                        if (numberOfDoubles == 2)
                        {
                            secondBet = doubleBet2;
                            playerCash += secondBet;
                            dealerCash -= secondBet;
                        }
                        else
                        {
                            secondBet = playerBet;
                            playerCash += secondBet;
                            dealerCash -= secondBet;
                        }

                        if (splitHandState == 2)  //fill this if in splitwin
                        {
                            if (playerBet == 1)
                            {
                                Console.WriteLine("You have won the second hand!  You win " + secondBet + " chip from the dealer.\n"); //single chip quote
                            }
                            else
                                Console.WriteLine("You have won the second hand!  You win " + secondBet + " chips from the dealer.\n");

                        }

                        else if (playerBet == 1)
                        {
                            Console.WriteLine("You have won!  You win " + playerBet + " chip from the dealer."); //single chip quote
                        }
                        else
                            Console.WriteLine("You have won!  You win " + playerBet + " chips from the dealer.");
                        Console.WriteLine("Press ENTER to start again.\n");
                        Console.ReadKey();
                        goto Finish;
                    }

                    Lose:
                    {

                        if (numberOfDoubles == 2)
                        {
                            secondBet = doubleBet2;
                            playerCash -= secondBet;
                            dealerCash += secondBet;
                        }
                        else
                        {
                            secondBet = playerBet;
                            playerCash -= secondBet;
                            dealerCash += secondBet;
                        }

                        if (splitHandState == 2)
                        {
                            if (playerBet == 1)
                            {
                                Console.WriteLine("You have lost your second hand. You lose " + secondBet + " chip to the dealer."); //single chip quote
                            }
                            else
                                Console.WriteLine("You have lost your second hand. You lose " + secondBet + " chips to the dealer.");
                            goto Finish;
                        }

                        if (playerBet == 1)
                        {
                            Console.WriteLine("You have lost. You lose " + playerBet + " chip to the dealer."); //single chip quote
                        }
                        else
                            Console.WriteLine("You have lost. You lose " + playerBet + " chips to the dealer.");

                        Console.WriteLine("Press ENTER to start again.\n");
                        Console.ReadKey();
                        goto Finish;
                    }

                    Push:
                    {
                        if (splitHandState == 2)
                            Console.WriteLine("You have pushed your second hand. You get your money back.  Press ENTER to start again.\n");
                        else
                            Console.WriteLine("You have pushed. You get your money back.  Press ENTER to start again.\n");

                        Console.ReadKey();
                        goto Finish;
                    }

                    BlackJack:
                    {
                        playerBet *= 1.5f;
                        playerCash += playerBet;
                        dealerCash -= playerBet;
                        if (splitHandState == 2)
                            Console.WriteLine("Blackjack!  You earn a 1.5 payout of " + (playerBet) + " chips\nfrom the dealer on your second hand.");
                        else
                            Console.WriteLine("Blackjack!  You earn a 1.5 payout of " + (playerBet) + " chips from the dealer.");

                        if (splitHandState == 1)
                        {
                            goto PlayerFirstDrawLoop;
                        }
                        goto Finish;
                    }

                    SplitWin:
                    {
                        if (numberOfDoubles == 1)
                        {
                            firstBet = doubleBet;
                            playerCash += firstBet;
                            dealerCash -= firstBet;
                        }
                        else
                        {
                            firstBet = playerBet;
                            playerCash += playerBet;
                            dealerCash -= playerBet;
                        }


                        if (playerBet == 1)
                        {
                            Console.WriteLine("You have won the first hand!  You win " + firstBet + " chip from the dealer."); //single chip quote
                        }
                        else
                            Console.WriteLine("You have won the first hand!  You win " + firstBet + " chips from the dealer.");

                        Console.WriteLine("Press ENTER to start again.\n");
                        Console.ReadKey();
                        goto MainHandWinLose;
                    }

                    SplitLose:
                    {

                        if (numberOfDoubles == 1)
                        {
                            firstBet = doubleBet;
                            playerCash -= firstBet;
                            dealerCash += firstBet;
                        }
                        else
                        {
                            firstBet = playerBet;
                            playerCash -= playerBet;
                            dealerCash += playerBet;
                        }

                        if (playerBet == 1)
                        {
                            Console.WriteLine("You have lost the first hand. You lose " + firstBet + " chip to the dealer.");
                        }
                        else
                            Console.WriteLine("You have lost the first hand. You lose " + firstBet + " chips to the dealer.");

                        Console.WriteLine("Press ENTER to start again.\n");
                        Console.ReadKey();
                        goto MainHandWinLose;
                    }


                    SplitPush:
                    {
                        Console.WriteLine("You have pushed the first hand. You get your money back.  Press ENTER to start again.\n");
                        Console.ReadKey();
                        goto MainHandWinLose;
                    }

                    Finish:
                    {
                    }

                }
                if (playerCash <= 0)
                {
                    Console.WriteLine("You lost all of your money.  Womp...");
                }
                else if (dealerCash <= 0)
                {
                    Console.WriteLine("You won all of the house's money.  History is made!");
                }

                AnotherSessionCheckpoint:
                Console.WriteLine("Do you want to start another session? \nPress 'y' or 'n' \n"); // Primmer Proofed
                char anotherSession;

                if (char.TryParse(Console.ReadLine(), out anotherSession))
                {
                    Console.WriteLine("\n");
                    if (anotherSession == 'y')
                        continue;
                    else if (anotherSession == 'n')
                    {
                        Console.WriteLine("\nThanks for Playing!  Press any key to exit.");
                        Console.ReadKey();
                        Environment.Exit(0); // Looked this up
                    }
                    else
                    {
                        Console.WriteLine("Just 'y' or 'n' please.\n");
                        goto AnotherSessionCheckpoint;
                    }

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Just 'y' or 'n' please.\n");
                    goto AnotherSessionCheckpoint;
                }
            }
        }

        // ------- METHODS TO CALL -------
        static float GetPlayerCash()  // get the player's chips
        {
            GetPlayerCashCheckpoint:
            Console.WriteLine("\nHow many total chips do you have in your stack?"); //good
            float playerCash = 0;

            if (float.TryParse(Console.ReadLine(), out playerCash))
            {
                Console.WriteLine("\nOkay, you now have " + playerCash + " chips.\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nWhole dollars please.\n");
                goto GetPlayerCashCheckpoint;
            }
            return playerCash;
        }

        static float GetDealerCash()   // get the dealer's chips
        {
            GetDealerCashCheckpoint:
            Console.WriteLine("How many chips are in the dealer's bank?"); //good
            float dealerCash = 0;

            if (float.TryParse(Console.ReadLine(), out dealerCash))
            {
                Console.WriteLine("\nThe dealer has " + dealerCash + " chips.\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nWhole dollars please.\n");
                goto GetDealerCashCheckpoint;
            }
            return dealerCash;
        }

        static int GetGirlOrBoy()
        {
            Random randGender = new Random();
            int dealerYChromosomes = randGender.Next(0, 2);
            return dealerYChromosomes;
        }
    }
}

