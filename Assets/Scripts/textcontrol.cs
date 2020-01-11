using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textcontrol : MonoBehaviour
{
    //THIS SCRIPT IS ABOUT WHOLE STORY AND GAMEPLAY

    //PLAYER
    public PlayerStats thisIsPlayer;
    //MUZIKUE
    public audioSourceCntrl thisIsMusic;



    //TXTBOXES that can be used
    public Text txtBotLeft;
    public Text txtBotRight;
    public Text txtTopLeft;
    public Text txtTopRight;
    public Text txtMidDown;
    public Text txtMidTop;
    //town1&2
    public Text txtTownHP;
    public Text txtTownGold;
    //combat
    public Text txtCombatPlayerHP;
    public Text txtCombatEnemyHP;
    public Text txtCombatReward;
    //Inn
    public Text txtInn1Quest;

        

    //BUTTONS FOR START GAME SCREEN
    public GameObject btnStartGameT;
    public GameObject btnDescriptionT;
    //BUTTONS FOR CHARACTER MAKER
    public GameObject btnSelectItems;
    public GameObject btnSelectSword;
    public GameObject btnSelectMace;
    public GameObject btnSelectBreastplate;
    public GameObject btnSelectCloth;
    //BUTTONS FOR TOWN 1
    public GameObject btnTown1Alchemist;
    public GameObject btnTown1Inn;
    public GameObject btnTown1Shop;

    public GameObject btnTownExit;




    //all images:
    public Image UniwielTitle;
    public Image imgDescriptionTekst;
    public Image imgStartGameBackground;
        //Character Maker Scene
    public Image chmkBackground;
            //leftside
    public Image chmkMeeple;
    public Image chmkCircleLT;
    public Image chmkCircleLB;
    public Image chmkCircleRT;
    public Image chmkCircleRB;
            //rightside
    public Image chmkSword2;
    public Image chmkMace2;
    public Image chmkBrestplate2;
    public Image chmkClothrope2;
            //even more right
    public Image chmkDice1Sword;
    public Image chmkDice2Sword;
    public Image chmkDice2Shield;
    public Image chmkDice3Sword;
    public Image chmkDice3Shield;
    public Image chmkDice4Shield;
    public Image chmkDiceImg;

        //in town 1
    public Image town1Background;


    //EVERYTHING FOR ALCHEMIST TOWN 1
    public Image town1AlchemistBackground;
    public GameObject btnAlchemistHeal;
    public GameObject btnAlchemistMaxHPUP;
    public GameObject btnAlchemistDMGUP;
    public GameObject btnAlchemistAccept;

    //EVERYTHING FOR INN TOWN 1
    public Image town1InnBackground;
    public GameObject btnTown1TrainingCombat;
    public GameObject btnTown1BountyHunt;
    public GameObject btnTown1MainQuest;
    public GameObject btnTown1AcceptQuest;
    public GameObject btnTown1InnDrink;


    //EVERYTHING FOR SHOP TOWN 1
    public Image town1Shop1Background;
    public GameObject btnShop1BUY;

    public GameObject btnShop1BTN1;
    public GameObject btnShop1BTN2;
    public GameObject btnShop1BTN3;
    public GameObject btnShop1BTN4;
    public GameObject btnShop1BTN5;
    public GameObject btnShop1BTN6;
    public GameObject btnShop1BTN7;
    public GameObject btnShop1BTN8;
    public GameObject btnShop1BTN9;
    public GameObject btnShop1BTN10;
    public GameObject btnShop1BTN11;
    public GameObject btnShop1BTN12;
    public GameObject btnShop1BTN13;
    public GameObject btnShop1BTN14;
    public GameObject btnShop1BTN15;
    public GameObject btnShop1BTN16;

    public Image shop1Meeple;
    public Image shop1HeadItem;
    public Image shop1RightHandItem;
    public Image shop1LeftHandItem;
    public Image shop1ArmorItem;
    public Image shop1DrinkItem;
    public Image shop1DiceCross;
    public Image shop1DiceSide1;
    public Image shop1DiceSide2;
    public Image shop1DiceSide3;
    public Image shop1DiceSide4;
    public Image shop1DiceSide5;
    public Image shop1DiceSide6;




    //ITEMS COST

    int[] ItemCost = new int[25];


    //EVERYTHING FOR COMBAT TRAINING - and COMBAT DEFAULT
    public Image trainBackground;
    public Image bountyHuntBackground;
    public Image combatMeepleEnemy;
    public Image combatMeeplePlayer;
    public Image combatPlayerItemHead;
    public Image combatPlayerItemRightHand;
    public Image combatPlayerItemLeftHand;
    public Image combatPlayerItemArmor;
    public Image combatPlayerDrinkItem;

    //Enemy items in combat
    public Image combatEnemyItemHead;
    public Image combatEnemyItemRightHand;
    public Image combatEnemyItemLeftHand;
    public Image combatEnemyItemArmor;

    public GameObject combatRunButton;
    public GameObject combatRollButton;

    //Reward screen:
    public GameObject combatRewardButton;
    public Image combatRewardBackground;


    //MAIN MISSION part
    public Image combatMeepleEnemyTown1Quest1;
    public Image combatMeepleEnemyTown1Quest2;
    public Image combatMeepleEnemyTown1Quest3;
    public Image combatBackgroundTown1Quest1;
    public Image combatBackgroundTown1Quest2;
    public Image combatBackgroundTown1Quest3;





    //ITEM SPRITES:     -----------------------LOOK IN PLAYER SCRIPT FOR ITEM NUMBERS
    public Sprite[] ItemHeadSP;
    public Sprite[] ItemRightHandSP;
    public Sprite[] ItemLeftHandSP;
    public Sprite[] ItemArmorSP;
    //                                                      function is:      combatPlayerIteamHead.sprite = ItemHeadSP[number];
    /*public SpriteRenderer ItemHeadSR;
    public SpriteRenderer ItemRightHandSR;
    public SpriteRenderer ItemLeftHandSR;
    public SpriteRenderer ItemArmorSR;*/

    //DICE SPRITES:   ---------------------------LOOK IN PLAYER SCRIPT FOR NUMBERS
    public Sprite[] DiceSymbolSP;
    public Image combatDiceBackgroundPlayer;
    public Image combatDiceBackgroundEnemy;
    public Image combatDiceSymbolPlayer;
    public Image combatDiceSymbolEnemy;
    //                                                      function is:      combatDiceSymbolPlayer.sprite = DiceSymbolSP[number];




    //GAME MENU IMGS AND BUTTONS UND TXT
    public Image menuBackground;
    public GameObject menuItemButton;
    public GameObject menuExitGameButton;
    public Image menuMeeple;
    public Image menuHeadItem;
    public Image menuRightHandItem;
    public Image menuLeftHandItem;
    public Image menuArmorItem;
    public Image menuDrinkItem;
    public Image menuDiceCross;
    public Image menuDiceSide1;
    public Image menuDiceSide2;
    public Image menuDiceSide3;
    public Image menuDiceSide4;
    public Image menuDiceSide5;
    public Image menuDiceSide6;
    public Text txtMenuHP;
    public Text txtMenuGold;
    public Text txtMenuDMG;






    //ALL STATES game can be in!!
    private enum States
    {
        startingScreen, characterMaker, town1, town2, shop1, shop2, inn1, inn2, alchemist1, alchemist2, combatTraining, combatBountyHunt1, town1Quest1, dead, reward, endgame1, endGameLost
    };
    private States myState;




    //Booleans
    private bool STARTGAME = false;
    private bool DESCRIPTION = false;
    private bool SELECTED = false;
    private bool GAMEMENU = false;
    private bool swordEquiped = false;
    private bool maceEquiped = false;
    private bool clothEquiped = false;
    private bool breastplateEquiped = false;
    private bool DRUNK = false;
    //IN TOWN 1
    private bool shop1Clicked = false;
    private bool inn1Clicked = false;
    private bool alchemist1Clicked = false;



    //Int variables
    private int x = 0, y = 0;
    private int mainQuestTown1;  // goes +1 each time you do main mission
    public int INNSWAPER = 0;  //used to check what did player click on in INN
    public int ALCHEMYSWAPPER = 0; //used to check what did player click in alchemyst
    //private int hpPotionCost = 3;
    private int maxhpPotionCost = 7;
    private int dmgPotionCost = 10;
    public int SHOPSWAPPER = 0; // Used to check what did player click in shop

    private int enemyHP;
    private int enemyDmg;
    private int playerDice;
    private int enemyDice;
    private int punishment;
    //private int rewardStatus = 0; //0 default, 1 when you win fight, 2 when you run away from fight, 3 when you die in fight.
    private int numRHItems;
    private int numLHItems;
    private int numHeadItems;
    private int numArmorItems;





    // START FUNK
    void Start()
    {
        UniwielTitle.enabled = true;

        //number of items in base
        numRHItems = 5;
        numLHItems = 4;
        numHeadItems = 4;
        numArmorItems = 2;
        DRUNK = false;
        mainQuestTown1 = 1;
        //hpPotionCost = 3;
        maxhpPotionCost = 7;
        dmgPotionCost = 10;

        //ITEM COSTS
        ItemCost[1] = 6;
        ItemCost[2] = 5;
        ItemCost[3] = 12;
        ItemCost[4] = 15;
        ItemCost[5] = 8;
        ItemCost[6] = 12;
        ItemCost[7] = 6;
        ItemCost[8] = 12;
        ItemCost[9] = 7;
        ItemCost[10] = 7;
        ItemCost[11] = 14;
        ItemCost[12] = 17;
        ItemCost[13] = 21;
        ItemCost[14] = 9;
        ItemCost[15] = 9;
        ItemCost[16] = 0;

        //MENU ITEMS
        GAMEMENU = false;
        menuBackground.enabled = false;
        menuItemButton.SetActive(false);
        menuExitGameButton.SetActive(false);
        menuMeeple.enabled = false;
        menuHeadItem.enabled = false;
        menuRightHandItem.enabled = false;
        menuLeftHandItem.enabled = false;
        menuArmorItem.enabled = false;
        menuDrinkItem.enabled = false;
        menuDiceCross.enabled = false;
        menuDiceSide1.enabled = false;
        menuDiceSide2.enabled = false;
        menuDiceSide3.enabled = false;
        menuDiceSide4.enabled = false;
        menuDiceSide5.enabled = false;
        menuDiceSide6.enabled = false;

        //PLAYER
        thisIsPlayer.ChangeItemHead(0);
        thisIsPlayer.ChangeItemRightHand(0);
        thisIsPlayer.ChangeItemLeftHand(0);
        thisIsPlayer.ChangeItemArmor(0);

        //Turn off images for Character Maker scene
        chmkBackground.enabled = false;

        chmkMeeple.enabled = false;
        chmkSword2.enabled = false;
        chmkMace2.enabled = false;
        chmkBrestplate2.enabled = false;
        chmkClothrope2.enabled = false;

        chmkCircleRT.enabled = false;
        chmkCircleRB.enabled = false;
        chmkCircleLT.enabled = false;
        chmkCircleLB.enabled = false;

        btnSelectItems.SetActive(false);
        btnSelectSword.SetActive(false);
        btnSelectMace.SetActive(false);
        btnSelectBreastplate.SetActive(false);
        btnSelectCloth.SetActive(false);

        chmkDice1Sword.enabled = false;
        chmkDice2Sword.enabled = false;
        chmkDice2Shield.enabled = false;
        chmkDice3Sword.enabled = false;
        chmkDice3Shield.enabled = false;
        chmkDice4Shield.enabled = false;
        chmkDiceImg.enabled = false;

        //town 1
        town1Background.enabled = false;
        btnTown1Alchemist.SetActive(false);
        btnTown1Inn.SetActive(false);
        btnTown1Shop.SetActive(false);
        btnTownExit.SetActive(false);

        txtTownHP.enabled = false;
        txtTownGold.enabled = false;

        //Alchemist town 1
        town1AlchemistBackground.enabled = false;
        btnAlchemistHeal.SetActive(false);
        btnAlchemistMaxHPUP.SetActive(false);
        btnAlchemistDMGUP.SetActive(false);
        btnAlchemistAccept.SetActive(false);

        //Inn town 1
        town1InnBackground.enabled = false;
        btnTown1TrainingCombat.SetActive(false);
        btnTown1BountyHunt.SetActive(false);
        btnTown1MainQuest.SetActive(false);
        btnTown1AcceptQuest.SetActive(false);
        btnTown1InnDrink.SetActive(false);


        //Shop1 town 1
        town1Shop1Background.enabled = false;
        btnShop1BUY.SetActive(false);

        btnShop1BTN1.SetActive(false);
        btnShop1BTN2.SetActive(false);
        btnShop1BTN3.SetActive(false);
        btnShop1BTN4.SetActive(false);
        btnShop1BTN5.SetActive(false);
        btnShop1BTN6.SetActive(false);
        btnShop1BTN7.SetActive(false);
        btnShop1BTN8.SetActive(false);
        btnShop1BTN9.SetActive(false);
        btnShop1BTN10.SetActive(false);
        btnShop1BTN11.SetActive(false);
        btnShop1BTN12.SetActive(false);
        btnShop1BTN13.SetActive(false);
        btnShop1BTN14.SetActive(false);
        btnShop1BTN15.SetActive(false);
        btnShop1BTN16.SetActive(false);

        shop1Meeple.enabled = false;
        shop1HeadItem.enabled = false;
        shop1RightHandItem.enabled = false;
        shop1LeftHandItem.enabled = false;
        shop1ArmorItem.enabled = false;
        shop1DrinkItem.enabled = false;
        shop1DiceCross.enabled = false;
        shop1DiceSide1.enabled = false;
        shop1DiceSide2.enabled = false;
        shop1DiceSide3.enabled = false;
        shop1DiceSide4.enabled = false;
        shop1DiceSide5.enabled = false;
        shop1DiceSide6.enabled = false;


        //Combat training - and Defaults
        trainBackground.enabled = false;
        combatMeepleEnemy.enabled = false;
        combatMeeplePlayer.enabled = false;
        bountyHuntBackground.enabled = false;
        

        //ITEMS in combat
        combatPlayerItemHead.sprite = ItemHeadSP[0];
        combatPlayerItemRightHand.sprite = ItemRightHandSP[0];
        combatPlayerItemLeftHand.sprite = ItemLeftHandSP[0];
        combatPlayerItemArmor.sprite = ItemArmorSP[0];
        combatPlayerItemHead.enabled = false;
        combatPlayerItemRightHand.enabled = false;
        combatPlayerItemLeftHand.enabled = false;
        combatPlayerItemArmor.enabled = false;
        combatPlayerDrinkItem.enabled = false;
        //Enemy items in combat
        combatEnemyItemHead.sprite = ItemHeadSP[0];
        combatEnemyItemRightHand.sprite = ItemRightHandSP[0];
        combatEnemyItemLeftHand.sprite = ItemLeftHandSP[0];
        combatEnemyItemArmor.sprite = ItemArmorSP[0];
        combatEnemyItemHead.enabled = false;
        combatEnemyItemRightHand.enabled = false;
        combatEnemyItemLeftHand.enabled = false;
        combatEnemyItemArmor.enabled = false;
        //Dice in combat
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[0];
        combatDiceSymbolEnemy.sprite = DiceSymbolSP[0];
        combatDiceBackgroundPlayer.enabled = false;
        combatDiceBackgroundEnemy.enabled = false;
        combatDiceSymbolPlayer.enabled = false;
        combatDiceSymbolEnemy.enabled = false;
        //combat buttons
        combatRunButton.SetActive(false);
        combatRollButton.SetActive(false);
        //Reward screen
        combatRewardButton.SetActive(false);
        combatRewardBackground.enabled = false;
        //MissionsTown1
        combatMeepleEnemyTown1Quest1.enabled = false;
        combatMeepleEnemyTown1Quest2.enabled = false;
        combatMeepleEnemyTown1Quest3.enabled = false;
        combatBackgroundTown1Quest1.enabled = false;
        combatBackgroundTown1Quest2.enabled = false;
        combatBackgroundTown1Quest3.enabled = false;


        myState = States.startingScreen;
    }

    // Update is called once per frame
    void Update()
    {
        //print (myState);

        if (myState != States.startingScreen && myState != States.characterMaker && myState != States.dead && myState != States.endgame1)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                //START EXIT MENU
                if (GAMEMENU == false)
                {
                    GAMEMENU = true;
                    menuBackground.enabled = true;
                    menuItemButton.SetActive(true);
                    menuExitGameButton.SetActive(true);
                }
                else
                {
                    GAMEMENU = false;
                    menuBackground.enabled = false;
                    menuItemButton.SetActive(false);
                    menuExitGameButton.SetActive(false);

                    menuMeeple.enabled = false;
                    menuHeadItem.enabled = false;
                    menuRightHandItem.enabled = false;
                    menuLeftHandItem.enabled = false;
                    menuArmorItem.enabled = false;
                    menuDrinkItem.enabled = false;
                    menuDiceCross.enabled = false;
                    menuDiceSide1.enabled = false;
                    menuDiceSide2.enabled = false;
                    menuDiceSide3.enabled = false;
                    menuDiceSide4.enabled = false;
                    menuDiceSide5.enabled = false;
                    menuDiceSide6.enabled = false;

                    txtMenuHP.text = "";
                    txtMenuGold.text = "";
                    txtMenuDMG.text = "";
                }
            }
        }

        if (myState == States.characterMaker)
        {
            characterMaker();
        }
        else if (myState == States.town1)
        {
            town1();
        }
        else if (myState == States.shop1)
        {
            shop1();
        }
        else if (myState == States.inn1)
        {
            inn1();
        }
        else if (myState == States.alchemist1)
        {
            alchemist1();
        }
        else if (myState == States.combatTraining)
        {
            combatTraining();
        }
        else if (myState == States.combatBountyHunt1)
        {
            combatBountyHunt1();
        }
        else if (myState == States.town1Quest1)
        {
            town1Quest1();
        }
        else if (myState == States.reward)
        {
            reward();
        }
        else if (myState == States.dead)
        {
            dead();
        }
        else if (myState == States.endgame1)
        {
            endgame1();
        }
        else if (myState == States.endGameLost)
        {
            endGameLost();
        }
        else
        {
            startingScreen();
        }


    }


//<---------------------------------------------------------------------------GAME MENU-------------------------------------------------------------------------------->
    public void menuExitGameButtonFUNKTION()
    {
        Application.Quit();
    }
    public void menuItemButtonFUNKTION()
    {
        menuItemButton.SetActive(false);
        menuExitGameButton.SetActive(false);

        menuMeeple.enabled = true;
        menuHeadItem.sprite = ItemHeadSP[thisIsPlayer.GetItemHead()];
        menuRightHandItem.sprite = ItemRightHandSP[thisIsPlayer.GetItemRightHand()];
        menuLeftHandItem.sprite = ItemLeftHandSP[thisIsPlayer.GetItemLeftHand()];
        menuArmorItem.sprite = ItemArmorSP[thisIsPlayer.GetItemArmor()];
        menuHeadItem.enabled = true;
        menuRightHandItem.enabled = true;
        menuLeftHandItem.enabled = true;
        menuArmorItem.enabled = true;
        if (DRUNK == true)
        {
            menuDrinkItem.enabled = true;
        }

        menuDiceCross.enabled = true;
        menuDiceSide1.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(1)];
        menuDiceSide2.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(2)];
        menuDiceSide3.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(3)];
        menuDiceSide4.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(4)];
        menuDiceSide5.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(5)];
        menuDiceSide6.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(6)];
        menuDiceSide1.enabled = true;
        menuDiceSide2.enabled = true;
        menuDiceSide3.enabled = true;
        menuDiceSide4.enabled = true;
        menuDiceSide5.enabled = true;
        menuDiceSide6.enabled = true;

        txtMenuHP.text = "HP: ";
        txtMenuHP.text += thisIsPlayer.GetHP().ToString();
        txtMenuHP.text += "/";
        txtMenuHP.text += thisIsPlayer.GetMaxHP().ToString();
        txtMenuGold.text = "Gold: ";
        txtMenuGold.text += thisIsPlayer.GetGold().ToString();
        txtMenuDMG.text = "Atk Dmg: ";
        txtMenuDMG.text += thisIsPlayer.GetDmg().ToString();
    }

//<---------------------------------------------------------------------------STARTING SCENE--------------------------------------------------------------------------->
    // STARTING SCREEN OF GAME
    void startingScreen()
    {
        txtClean();
        imgStartGameBackground.enabled = true;

        if (DESCRIPTION)
        {
            btnStartGameT.SetActive(false);
            btnDescriptionT.SetActive(false);
            imgDescriptionTekst.enabled = true;
        }
        else
        {

            imgDescriptionTekst.enabled = false;
            btnStartGameT.SetActive(true);
            btnDescriptionT.SetActive(true);
            //btnStartGameT.GetComponent<Button>().interactable = true;
            //btnStartGameT.GetComponent<Button>().enabled = true;
        }

        if (STARTGAME)
        {
            txtClean();

            imgStartGameBackground.enabled = false;
            btnStartGameT.SetActive(false);
            btnDescriptionT.SetActive(false);
            UniwielTitle.enabled = false;

            // When you click start button you start game by going to characterMaker!

            prepairingCharacterMakerState();
            myState = States.characterMaker;
        }

        
        //press ESCAPE to exit Description IMG
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            DESCRIPTION = false;
        }

                
    }

    public void startButtonFunk()
    {
        STARTGAME = true;
    }
    public void descButtonFunk()
    {
        DESCRIPTION = true;
    }



    //<---------------------------------------------------------------------------CHARACTER MAKER SCENE----------------------------------------------------------------------->
    void prepairingCharacterMakerState()
    {
        txtClean();

        txtMidTop.text = "Get yourself a starting gear";

        chmkMeeple.enabled = true;


        btnSelectSword.SetActive(true);
        btnSelectMace.SetActive(true);
        btnSelectBreastplate.SetActive(true);
        btnSelectCloth.SetActive(true);

        chmkDiceImg.enabled = true;
        chmkBackground.enabled = true;

        //Button that selects items
        btnSelectItems.SetActive(true);

    }
    void characterMaker()
    {
        txtMidTop.text = "Get yourself a starting gear";
        txtTownHP.text = "HP: 8";


        if (swordEquiped)
        {
            chmkSword2.enabled = true;

            chmkDice1Sword.enabled = true;
            chmkDice2Shield.enabled = false;
            chmkDice2Sword.enabled = true;

            x = 1;
        }
        else chmkSword2.enabled = false;

        if (maceEquiped)
        {
            chmkMace2.enabled = true;

            chmkDice1Sword.enabled = true;
            chmkDice2Sword.enabled = false;
            chmkDice2Shield.enabled = true;

            x = 2;
            txtTownHP.text += "+2";
        }
        else chmkMace2.enabled = false;


        if (breastplateEquiped)
        {
            chmkBrestplate2.enabled = true;

            chmkDice3Sword.enabled = false;
            chmkDice3Shield.enabled = true;
            chmkDice4Shield.enabled = true;

            y = 1;
            txtTownHP.text += "+4";
        }
        else chmkBrestplate2.enabled = false;

        if (clothEquiped)
        {
            chmkClothrope2.enabled = true;

            chmkDice3Sword.enabled = true;
            chmkDice3Shield.enabled = false;
            chmkDice4Shield.enabled = true;

            y = 2;
            txtTownHP.text += "+2";
        }
        else chmkClothrope2.enabled = false;

        if (SELECTED == true)
        {
            //first turn off all
            btnSelectItems.SetActive(false);
            chmkBackground.enabled = false;

            chmkSword2.enabled = false;
            chmkMace2.enabled = false;
            chmkBrestplate2.enabled = false;
            chmkClothrope2.enabled = false;

            chmkMeeple.enabled = false;

            chmkCircleRT.enabled = false;
            chmkCircleRB.enabled = false;
            chmkCircleLT.enabled = false;
            chmkCircleLB.enabled = false;

            btnSelectSword.SetActive(false);
            btnSelectMace.SetActive(false);
            btnSelectBreastplate.SetActive(false);
            btnSelectCloth.SetActive(false);

            chmkDiceImg.enabled = false;
            chmkDice1Sword.enabled = false;
            chmkDice2Sword.enabled = false;
            chmkDice2Shield.enabled = false;
            chmkDice3Sword.enabled = false;
            chmkDice3Shield.enabled = false;
            chmkDice4Shield.enabled = false;

            txtTownHP.text = "";


            // call func from PlayerStats->CreatingCharacter(x,y)
            thisIsPlayer.CreatingCharacter(x, y);
            //next state---->town
            prepairingtown1();
            myState = States.town1;
        }

    }

    public void swordBtn()
    {
        swordEquiped = true;
        maceEquiped = false;
        chmkCircleLT.enabled = true;
        chmkCircleRT.enabled = false;
        txtClean();
    }
    public void maceBtn()
    {
        maceEquiped = true;
        swordEquiped = false;
        chmkCircleLT.enabled = false;
        chmkCircleRT.enabled = true;
        txtClean();
    }
    public void breastplateBtn()
    {
        breastplateEquiped = true;
        clothEquiped = false;
        chmkCircleLB.enabled = true;
        chmkCircleRB.enabled = false;
        txtClean();
    }
    public void clothBtn()
    {
        clothEquiped = true;
        breastplateEquiped = false;
        chmkCircleLB.enabled = false;
        chmkCircleRB.enabled = true;
        txtClean();
    }
    
    public void btnSelectItemsFUNK()
    {
        if (y > 0 && x > 0)
        {
            SELECTED = true;
        }
        else
        {
            txtMidDown.text = "You have to select one weapon and one armor item!";
        }
    }




//<---------------------------------------------------------------------------------TOWN ONE SCENE----------------------------------------------------------------------->
    void prepairingtown1()
    {
        thisIsMusic.PlaySong(1);
        txtClean();
        town1Background.enabled = true;
        btnTown1Alchemist.SetActive(true);
        btnTown1Inn.SetActive(true);
        btnTown1Shop.SetActive(true);

        shop1Clicked = false;
        inn1Clicked = false;
        alchemist1Clicked = false;

        txtTownHP.enabled = true;
        txtTownGold.enabled = true;

        btnTownExit.SetActive(false);

    }
    void UNprepairingtown1()
    {
        txtClean();
        town1Background.enabled = false;
        btnTown1Alchemist.SetActive(false);
        btnTown1Inn.SetActive(false);
        btnTown1Shop.SetActive(false);

        txtTownHP.enabled = false;
        txtTownGold.enabled = false;

        btnTownExit.SetActive(true);

    }
    void town1()
    {
        txtMidDown.text = "Choose where you want to go. Shop is where you can buy new items,\nAlchemist is where you can heal yourself and Inn is where you take quests!";
        int gld = thisIsPlayer.GetGold();
        int hp = thisIsPlayer.GetHP();

        txtTownHP.text = hp.ToString();
        txtTownGold.text = gld.ToString();

        if (shop1Clicked)
        {
            UNprepairingtown1();
            prepairingshop1();
            myState = States.shop1;
        }
        if (inn1Clicked)
        {
            UNprepairingtown1();
            prepairinginn1();
            myState = States.inn1;
        }
        if (alchemist1Clicked)
        {
            UNprepairingtown1();
            prepairingalchemist1();
            myState = States.alchemist1;
        }
        if (mainQuestTown1 == 4)
        {
            UNprepairingtown1();
            myState = States.endgame1;
        }
    }

    public void town1AlchemistClicked()
    {
        alchemist1Clicked = true;
    }
    public void town1InnClicked()
    {
        inn1Clicked = true;
    }
    public void town1ShopClicked()
    {
        shop1Clicked = true;
    }


    public void town1ExitClicked()
    {
        Unprepairingshop1();
        Unprepairingalchemist1();
        Unprepairinginn1();

        prepairingtown1();
        myState = States.town1;

    }

    //<----------------------------------------------------------------------SHOP 1----------------------------------------------------------------------------->
    void prepairingshop1()
    {
        thisIsMusic.PlaySong(4);
        shop1Clicked = false;
        SHOPSWAPPER = 0;
        town1Shop1Background.enabled = true;

        shop1HeadItem.sprite = ItemHeadSP[thisIsPlayer.GetItemHead()];
        shop1RightHandItem.sprite = ItemRightHandSP[thisIsPlayer.GetItemRightHand()];
        shop1LeftHandItem.sprite = ItemLeftHandSP[thisIsPlayer.GetItemLeftHand()];
        shop1ArmorItem.sprite = ItemArmorSP[thisIsPlayer.GetItemArmor()];
        shop1DiceSide1.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(1)];
        shop1DiceSide2.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(2)];
        shop1DiceSide3.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(3)];
        shop1DiceSide4.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(4)];
        shop1DiceSide5.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(5)];
        shop1DiceSide6.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(6)];


        btnShop1BTN1.SetActive(true);
        btnShop1BTN2.SetActive(true);
        btnShop1BTN3.SetActive(true);
        btnShop1BTN4.SetActive(true);
        btnShop1BTN5.SetActive(true);
        btnShop1BTN6.SetActive(true);
        btnShop1BTN7.SetActive(true);
        btnShop1BTN8.SetActive(true);
        btnShop1BTN9.SetActive(true);
        btnShop1BTN10.SetActive(true);
        btnShop1BTN11.SetActive(true);
        btnShop1BTN12.SetActive(true);
        btnShop1BTN13.SetActive(true);
        btnShop1BTN14.SetActive(true);
        btnShop1BTN15.SetActive(true);
        //btnShop1BTN16.SetActive(true);

        shop1Meeple.enabled = true;
        shop1HeadItem.enabled = true;
        shop1RightHandItem.enabled = true;
        shop1LeftHandItem.enabled = true;
        shop1ArmorItem.enabled = true;
        if (DRUNK == true)
        {
            shop1DrinkItem.enabled = true;
        }
        shop1DiceCross.enabled = true;
        shop1DiceSide1.enabled = true;
        shop1DiceSide2.enabled = true;
        shop1DiceSide3.enabled = true;
        shop1DiceSide4.enabled = true;
        shop1DiceSide5.enabled = true;
        shop1DiceSide6.enabled = true;


        txtTownHP.enabled = true;
        txtTownGold.enabled = true;
    }
    void Unprepairingshop1()
    {
        town1Shop1Background.enabled = false;
        btnShop1BUY.SetActive(false);
        SHOPSWAPPER = 0;

        btnShop1BTN1.SetActive(false);
        btnShop1BTN2.SetActive(false);
        btnShop1BTN3.SetActive(false);
        btnShop1BTN4.SetActive(false);
        btnShop1BTN5.SetActive(false);
        btnShop1BTN6.SetActive(false);
        btnShop1BTN7.SetActive(false);
        btnShop1BTN8.SetActive(false);
        btnShop1BTN9.SetActive(false);
        btnShop1BTN10.SetActive(false);
        btnShop1BTN11.SetActive(false);
        btnShop1BTN12.SetActive(false);
        btnShop1BTN13.SetActive(false);
        btnShop1BTN14.SetActive(false);
        btnShop1BTN15.SetActive(false);
        btnShop1BTN16.SetActive(false);

        shop1Meeple.enabled = false;
        shop1HeadItem.enabled = false;
        shop1RightHandItem.enabled = false;
        shop1LeftHandItem.enabled = false;
        shop1ArmorItem.enabled = false;
        shop1DrinkItem.enabled = false;
        shop1DiceCross.enabled = false;
        shop1DiceSide1.enabled = false;
        shop1DiceSide2.enabled = false;
        shop1DiceSide3.enabled = false;
        shop1DiceSide4.enabled = false;
        shop1DiceSide5.enabled = false;
        shop1DiceSide6.enabled = false;

        txtTownHP.enabled = false;
        txtTownGold.enabled = false;
    }
    void shop1()
    {
        if (SHOPSWAPPER > 0)
        {
            btnShop1BUY.SetActive(true);
            txtMidDown.text = "Are you sure you want to buy this item ?";
            int gld = thisIsPlayer.GetGold();
            txtTownGold.text = gld.ToString();
            txtTownGold.text += "-";
            txtTownGold.text += ItemCost[SHOPSWAPPER].ToString();
        }
        else
        {
            int gld = thisIsPlayer.GetGold();
            txtTownGold.text = gld.ToString();
            btnShop1BUY.SetActive(false);
            txtMidDown.text = "Welcome to the shop, how may I help you?\nFeel free to look at all of my items.";
        }
        
    }

    //<-------------ALL OF SHOP BUTTONS-------------->
    // HEAD ITEMS
    public void shop1HeadItem1()
    {
        shopLookRefresh();
        SHOPSWAPPER = 1;
        shop1HeadItem.sprite = ItemHeadSP[SHOPSWAPPER];
        shop1DiceSide5.sprite = DiceSymbolSP[1];
        btnShop1BUY.SetActive(true);
    }
    public void shop1HeadItem2()
    {
        shopLookRefresh();
        SHOPSWAPPER = 2;
        shop1HeadItem.sprite = ItemHeadSP[SHOPSWAPPER];
        shop1DiceSide5.sprite = DiceSymbolSP[3];
        btnShop1BUY.SetActive(true);
    }
    public void shop1HeadItem3()
    {
        shopLookRefresh();
        SHOPSWAPPER = 3;
        shop1HeadItem.sprite = ItemHeadSP[SHOPSWAPPER];
        shop1DiceSide5.sprite = DiceSymbolSP[4];
        btnShop1BUY.SetActive(true);
    }
    public void shop1HeadItem4()
    {
        shopLookRefresh();
        SHOPSWAPPER = 4;
        shop1HeadItem.sprite = ItemHeadSP[SHOPSWAPPER];
        shop1DiceSide5.sprite = DiceSymbolSP[5];
        btnShop1BUY.SetActive(true);
    }
    // LEFT HAND ITEMS
    public void shop1LHItemDagger5()
    {
        shopLookRefresh();
        SHOPSWAPPER = 5;
        shop1LeftHandItem.sprite = ItemLeftHandSP[SHOPSWAPPER - 4];
        shop1DiceSide6.sprite = DiceSymbolSP[1];
        btnShop1BUY.SetActive(true);
    }
    public void shop1LHItemArrows6()
    {
        shopLookRefresh();
        SHOPSWAPPER = 6;
        shop1LeftHandItem.sprite = ItemLeftHandSP[SHOPSWAPPER - 4];
        shop1DiceSide6.sprite = DiceSymbolSP[2];
        btnShop1BUY.SetActive(true);
    }
    public void shop1LHItemShieldMele7()
    {
        shopLookRefresh();
        SHOPSWAPPER = 7;
        shop1LeftHandItem.sprite = ItemLeftHandSP[SHOPSWAPPER - 4];
        shop1DiceSide6.sprite = DiceSymbolSP[3];
        btnShop1BUY.SetActive(true);
    }
    public void shop1LHItemShieldRange8()
    {
        shopLookRefresh();
        SHOPSWAPPER = 8;
        shop1LeftHandItem.sprite = ItemLeftHandSP[SHOPSWAPPER - 4];
        shop1DiceSide6.sprite = DiceSymbolSP[4];
        btnShop1BUY.SetActive(true);
    }
    // RIGHT HAND ITEMS
    public void shop1RHItemSword9()
    {
        shopLookRefresh();
        SHOPSWAPPER = 9;
        shop1RightHandItem.sprite = ItemRightHandSP[SHOPSWAPPER - 8];
        shop1DiceSide1.sprite = DiceSymbolSP[1];
        shop1DiceSide2.sprite = DiceSymbolSP[1];
        btnShop1BUY.SetActive(true);
    }
    public void shop1RHItemMace10()
    {
        shopLookRefresh();
        SHOPSWAPPER = 10;
        shop1RightHandItem.sprite = ItemRightHandSP[SHOPSWAPPER - 8];
        shop1DiceSide1.sprite = DiceSymbolSP[1];
        shop1DiceSide2.sprite = DiceSymbolSP[3];
        btnShop1BUY.SetActive(true);
    }
    public void shop1RHItemSpear11()
    {
        shopLookRefresh();
        SHOPSWAPPER = 11;
        shop1RightHandItem.sprite = ItemRightHandSP[SHOPSWAPPER - 8];
        shop1DiceSide1.sprite = DiceSymbolSP[1];
        shop1DiceSide2.sprite = DiceSymbolSP[2];
        btnShop1BUY.SetActive(true);
    }
    public void shop1RHItemBow12()
    {
        shopLookRefresh();
        SHOPSWAPPER = 12;
        shop1RightHandItem.sprite = ItemRightHandSP[SHOPSWAPPER - 8];
        shop1DiceSide1.sprite = DiceSymbolSP[2];
        shop1DiceSide2.sprite = DiceSymbolSP[2];
        btnShop1BUY.SetActive(true);
    }
    public void shop1RHItemCrossbow13()
    {
        shopLookRefresh();
        SHOPSWAPPER = 13;
        shop1RightHandItem.sprite = ItemRightHandSP[SHOPSWAPPER - 8];
        shop1DiceSide1.sprite = DiceSymbolSP[8];
        shop1DiceSide2.sprite = DiceSymbolSP[2];
        btnShop1BUY.SetActive(true);
    }
    // ARMOR ITEMS
    public void shop1ArmorItemBreastplate14()
    {
        shopLookRefresh();
        SHOPSWAPPER = 14;
        shop1ArmorItem.sprite = ItemArmorSP[1];
        shop1DiceSide3.sprite = DiceSymbolSP[3];
        shop1DiceSide4.sprite = DiceSymbolSP[3];
        btnShop1BUY.SetActive(true);
    }
    public void shop1ArmorItemCloth15()
    {
        shopLookRefresh();
        shop1ArmorItem.sprite = ItemArmorSP[2];
        shop1DiceSide3.sprite = DiceSymbolSP[1];
        shop1DiceSide4.sprite = DiceSymbolSP[3];
        SHOPSWAPPER = 15;
        btnShop1BUY.SetActive(true);
    }



    //BUY BUTTON
    public void shop1BuyFUNK()
    {
        int g = thisIsPlayer.GetGold();
        if (g < ItemCost[SHOPSWAPPER])
        {
            txtMidTop.text = "You can not afford this item. It costs ";
            txtMidTop.text += ItemCost[SHOPSWAPPER].ToString();
            txtMidTop.text += " gold.";

        }
        else
        {
            switch (SHOPSWAPPER)
            {
                case 1://head items
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemHead(SHOPSWAPPER);
                    thisIsPlayer.ChangeDiceSide(5, 1);
                    break;
                case 2:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemHead(SHOPSWAPPER);
                    thisIsPlayer.ChangeDiceSide(5, 3);
                    break;
                case 3:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemHead(SHOPSWAPPER);
                    thisIsPlayer.ChangeDiceSide(5, 4);
                    break;
                case 4:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemHead(SHOPSWAPPER);
                    thisIsPlayer.ChangeDiceSide(5, 5);
                    break;
                case 5://LeftHand Items
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemLeftHand((SHOPSWAPPER - 4));
                    thisIsPlayer.ChangeDiceSide(6, 1);
                    break;
                case 6:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemLeftHand((SHOPSWAPPER - 4));
                    thisIsPlayer.ChangeDiceSide(6, 2);
                    break;
                case 7:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemLeftHand((SHOPSWAPPER - 4));
                    thisIsPlayer.ChangeDiceSide(6, 3);
                    break;
                case 8:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemLeftHand((SHOPSWAPPER - 4));
                    thisIsPlayer.ChangeDiceSide(6, 4);
                    break;
                case 9://RightHand Items
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemRightHand((SHOPSWAPPER - 8));
                    thisIsPlayer.ChangeDiceSide(1, 1);
                    thisIsPlayer.ChangeDiceSide(2, 1);
                    break;
                case 10:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemRightHand((SHOPSWAPPER - 8));
                    thisIsPlayer.ChangeDiceSide(1, 1);
                    thisIsPlayer.ChangeDiceSide(2, 3);
                    break;
                case 11:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemRightHand((SHOPSWAPPER - 8));
                    thisIsPlayer.ChangeDiceSide(1, 1);
                    thisIsPlayer.ChangeDiceSide(2, 2);
                    break;
                case 12:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemRightHand((SHOPSWAPPER - 8));
                    thisIsPlayer.ChangeDiceSide(1, 2);
                    thisIsPlayer.ChangeDiceSide(2, 2);
                    break;
                case 13:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemRightHand((SHOPSWAPPER - 8));
                    thisIsPlayer.ChangeDiceSide(1, 8);
                    thisIsPlayer.ChangeDiceSide(2, 2);
                    break;
                case 14: //ARMOR ITEMS
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemArmor(1);
                    thisIsPlayer.ChangeDiceSide(3, 3);
                    thisIsPlayer.ChangeDiceSide(4, 3);
                    break;
                case 15:
                    thisIsPlayer.ChangeGold((-1) * ItemCost[SHOPSWAPPER]);
                    thisIsPlayer.ChangeItemArmor(2);
                    thisIsPlayer.ChangeDiceSide(3, 1);
                    thisIsPlayer.ChangeDiceSide(4, 3);
                    break;
                default:
                    txtMidTop.text = "Missing item...";
                    break;
            }
        }
        shopLookRefresh();
        btnShop1BUY.SetActive(false);
        SHOPSWAPPER = 0;
    }

    private void shopLookRefresh()
    {
        shop1HeadItem.sprite = ItemHeadSP[thisIsPlayer.GetItemHead()];
        shop1RightHandItem.sprite = ItemRightHandSP[thisIsPlayer.GetItemRightHand()];
        shop1LeftHandItem.sprite = ItemLeftHandSP[thisIsPlayer.GetItemLeftHand()];
        shop1ArmorItem.sprite = ItemArmorSP[thisIsPlayer.GetItemArmor()];
        shop1DiceSide1.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(1)];
        shop1DiceSide2.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(2)];
        shop1DiceSide3.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(3)];
        shop1DiceSide4.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(4)];
        shop1DiceSide5.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(5)];
        shop1DiceSide6.sprite = DiceSymbolSP[thisIsPlayer.GetDiceSide(6)];
    }






    //<----------------------------------------------------------------------ALCHEMIST 1----------------------------------------------------------------------------->
    void prepairingalchemist1()
    {
        thisIsMusic.PlaySong(3);
        alchemist1Clicked = false;

        town1AlchemistBackground.enabled = true;
        btnAlchemistHeal.SetActive(true);
        btnAlchemistMaxHPUP.SetActive(true);
        btnAlchemistDMGUP.SetActive(true);
        btnAlchemistAccept.SetActive(false);
        txtMidTop.text = "Welcome to my shop traveler, interested in my potions?";

        txtTownHP.enabled = true;
        txtTownGold.enabled = true;

        ALCHEMYSWAPPER = 0;
    }
    void Unprepairingalchemist1()
    {
        town1AlchemistBackground.enabled = false;
        btnAlchemistHeal.SetActive(false);
        btnAlchemistMaxHPUP.SetActive(false);
        btnAlchemistDMGUP.SetActive(false);
        btnAlchemistAccept.SetActive(false);

        txtTownHP.enabled = false;
        txtTownGold.enabled = false;
    }
    void alchemist1()
    {
        int gld = thisIsPlayer.GetGold();
        int hp = thisIsPlayer.GetHP();
        txtTownHP.text = hp.ToString();
        txtTownGold.text = gld.ToString();
    }
    public void btnAlchemist1Heal()
    {
        ALCHEMYSWAPPER = 1;
        btnAlchemistAccept.SetActive(true);

        //hpPotionCost = 3; CONSTANT

        txtMidTop.text = "This potion will heal you for 2 HP\nfor price of only 3 gold coins.";

    }
    public void btnAlchemist1MaxHP()
    {
        ALCHEMYSWAPPER = 2;
        btnAlchemistAccept.SetActive(true);

        txtMidTop.text = "This potion will increese your maximum HP by 2\nfor price of only ";
        txtMidTop.text += maxhpPotionCost.ToString();
        txtMidTop.text += " gold coins.";

    }
    public void btnAlchemist1DMG()
    {
        ALCHEMYSWAPPER = 3;
        btnAlchemistAccept.SetActive(true);

        txtMidTop.text = "This potion will boost your attack damage by 1\nfor price of only ";
        txtMidTop.text += dmgPotionCost.ToString();
        txtMidTop.text += " gold coins.";
    }


    public void btnAlchemist1ACCEPT()
    {
        if (ALCHEMYSWAPPER == 1) // HEAL CHOSEN AND ACCEPT CLICKED
        {
            int gld = thisIsPlayer.GetGold();
            int hp = thisIsPlayer.GetHP();

            if (hp == thisIsPlayer.GetMaxHP())
            {
                txtMidTop.text = "I am afraid potion can not do much for you at the moment.\nIt would be waste of gold.";
                txtMidDown.text = "Your HP is at maximum!";
            }
            else if ((gld - 3) < 0)
            {
                txtMidTop.text = "I am afraid you do not have what I need to buy my potions.\nEach potion costs 3 gold pieces.";
                txtMidDown.text = "You do not have enaugh gold!";
            }
            else
            {
                txtMidTop.text = "Thank you kind sir. Do you need more potions?";
                txtMidDown.text = "";
                thisIsPlayer.ChangeHP(2);
                thisIsPlayer.ChangeGold(-3);
            }
        }
        else if (ALCHEMYSWAPPER == 2) // MAX HP UP CHOSEN AND ACCEPT CLICKED
        {
            int gld = thisIsPlayer.GetGold();

            if ((gld - maxhpPotionCost) < 0)
            {
                txtMidTop.text = "I am afraid you do not have what I need to buy my maxHP potion.\nEach potion costs ";
                txtMidTop.text += maxhpPotionCost.ToString();
                txtMidTop.text += " gold pieces.";
                txtMidDown.text = "You do not have enaugh gold!";
            }
            else
            {
                thisIsPlayer.ChangeMaxHP(2);
                thisIsPlayer.ChangeGold(-maxhpPotionCost);
                maxhpPotionCost = maxhpPotionCost + 1;
                txtMidTop.text = "Thank you kind sir.Now your maximum HP is ";
                txtMidTop.text += thisIsPlayer.GetMaxHP().ToString();
                txtMidTop.text += ".\nDo you need anything else?";
                txtMidDown.text = "";
                
            }
        }
        else // DMG UP CHOSEN AND ACCEPT CLICKED
        {
            int gld = thisIsPlayer.GetGold();

            if ((gld - dmgPotionCost) < 0)
            {
                txtMidTop.text = "I am afraid you do not have what I need to buy my attack boost potion.\nEach potion costs ";
                txtMidTop.text += dmgPotionCost.ToString();
                txtMidTop.text += " gold pieces.";
                txtMidDown.text = "You do not have enaugh gold!";
            }
            else
            {
                thisIsPlayer.ChangeDmg(1);
                thisIsPlayer.ChangeGold(-10);
                dmgPotionCost = dmgPotionCost + 2;
                txtMidTop.text = "Thank you kind sir. Now your attack dmg is ";
                txtMidTop.text += thisIsPlayer.GetDmg().ToString();
                txtMidTop.text += ".\nDo you need anything else?";
                txtMidDown.text = "";
                
            }
        }
    }

    //<----------------------------------------------------------------------INN 1----------------------------------------------------------------------------->
    void prepairinginn1()
    {
        thisIsMusic.PlaySong(2);
        inn1Clicked = false;

        town1InnBackground.enabled = true;
        btnTown1TrainingCombat.SetActive(true);
        btnTown1BountyHunt.SetActive(true);
        btnTown1MainQuest.SetActive(true);
        btnTown1InnDrink.SetActive(true);

        txtTownHP.enabled = true;
        txtTownGold.enabled = true;

        txtMidTop.text = "Welcome to the inn, how may I help you?";
        txtMidDown.text = "Click on quests to ask about them\nor click on inn keeper to buy some drink for 3 gold.";

        if (mainQuestTown1 == 1)
        {
            txtInn1Quest.text = "Adron: 10G";
        }
        else if (mainQuestTown1 == 2)
        {
            txtInn1Quest.text = "Thelin: 14G";
        }
        else
        {
            txtInn1Quest.text = "Deimwen: 20G";
        }
    }
    void Unprepairinginn1()
    {
        txtTownHP.enabled = false;
        txtTownGold.enabled = false;

        town1InnBackground.enabled = false;
        btnTown1TrainingCombat.SetActive(false);
        btnTown1BountyHunt.SetActive(false);
        btnTown1MainQuest.SetActive(false);
        btnTown1InnDrink.SetActive(false);

        btnTown1AcceptQuest.SetActive(false);
    }
    void inn1()
    {
        int gld = thisIsPlayer.GetGold();
        int hp = thisIsPlayer.GetHP();
        txtTownHP.text = hp.ToString();
        txtTownGold.text = gld.ToString();
    }


    public void FUNKTown1InnDrink()
    {
        int gld = thisIsPlayer.GetGold();
        btnTown1AcceptQuest.SetActive(false);

        if (DRUNK == true)
        {
            txtMidTop.text = "You have already drank too much...";
        }
        else if (gld >= 3 && DRUNK != true)
        {
            DRUNK = true;
            thisIsPlayer.ChangeGold(-3);
            txtMidTop.text = "You bought a drink for 3 gold.\nYour attack damage in next fight will be ";
            txtMidTop.text += (thisIsPlayer.GetDmg()+1).ToString();
            txtMidTop.text += ".";
        }
        else
        {
            txtMidTop.text = "You do not have enaugh gold to buy drink. Need anything else ?";
        }

    }


    public void FUNKTown1TrainingBattle()
    {
        btnTown1AcceptQuest.SetActive(true);
        INNSWAPER = 1;

        txtMidTop.text = "Town folks organize friendly fights for entertainment.\nWinner gets 2 gold. Please do not kill anyone, ok?";

    }
    public void FUNKTown1BountyHunt()
    {
        btnTown1AcceptQuest.SetActive(true);
        INNSWAPER = 2;

        txtMidTop.text = "There are a lot of thieves going around this town.\nEach of them is worth 5 gold if you bring them. You can kill them.\nNo one cares if they are dead...";
    }
    public void FUNKTown1MainQuest()
    {
        btnTown1AcceptQuest.SetActive(true);
        INNSWAPER = 3;

        if (mainQuestTown1 == 1)
        {
            txtMidTop.text = "This is Adron, Corporal of Gold, leader of thieves around this parts.\nHe has bounty of 10 gold at the moment, dead or alive.\nAre you up for it ?";
        }
        else if (mainQuestTown1 == 2)
        {
            txtMidTop.text = "This is Thelin, Count of Watch, crossbow master.\nHe has bounty of 12 gold at the moment, dead or alive.\nAre you up for it ?";
        }
        else
        {
            txtMidTop.text = "This is Deimwen, the Archpriest of Purity, leader of cult.\nHe has bounty of 20 gold at the moment, dead or alive.\nAre you up for it ?";
        }

    }

    public void FUNKTown1AcceptQuest()
    {
        btnTownExit.SetActive(false);
        if (DRUNK == true)
        {
            thisIsPlayer.ChangeDmg(1);
        }

        if (INNSWAPER == 1)
        {
            //starts training combat
            Unprepairinginn1();
            prepairingCombatTraining();
            myState = States.combatTraining;
        }
        else if (INNSWAPER == 2)
        {
            //mystate bounty hunt town 1
            Unprepairinginn1();
            prepairingCombatBountyHunt1();
            myState = States.combatBountyHunt1;
        }
        else
        {
            //ALL STARTED IN SAME FUNCTION but int mainQuestTown1 seperates differences
            Unprepairinginn1();
            prepairingTown1Quest1();
            myState = States.town1Quest1;

        }

    }


    //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->
    //<----------------------------------------------------------------------COMBAT SCENES----------------------------------------------------------------------------->
    //<---------------------------------------------------------------------------------------------------------------------------------------------------------------->

    private void prepairingCombatTraining()
    {
        thisIsMusic.PlaySong(5);
        txtClean();
        INNSWAPER = 1;
        enemyHP = 5;
        enemyDmg = 1;

        trainBackground.enabled = true;
        combatMeepleEnemy.enabled = true;
        combatMeeplePlayer.enabled = true;

        //ITEMS in combat
        combatPlayerItemHead.sprite = ItemHeadSP[thisIsPlayer.GetItemHead()];
        combatPlayerItemRightHand.sprite = ItemRightHandSP[thisIsPlayer.GetItemRightHand()];
        combatPlayerItemLeftHand.sprite = ItemLeftHandSP[thisIsPlayer.GetItemLeftHand()];
        combatPlayerItemArmor.sprite = ItemArmorSP[thisIsPlayer.GetItemArmor()];
        combatPlayerItemHead.enabled = true;
        combatPlayerItemRightHand.enabled = true;
        combatPlayerItemLeftHand.enabled = true;
        combatPlayerItemArmor.enabled = true;
        if (DRUNK == true)
        {
            combatPlayerDrinkItem.enabled = true;
        }

        //Enemy items
        //Enemy items in combat
        combatEnemyItemHead.sprite = ItemHeadSP[0];
        x = Random.Range(0, 2);
        combatEnemyItemRightHand.sprite = ItemRightHandSP[x];
        combatEnemyItemLeftHand.sprite = ItemLeftHandSP[0];
        x = Random.Range(0, 2);
        combatEnemyItemArmor.sprite = ItemArmorSP[x];
        combatEnemyItemHead.enabled = true;
        combatEnemyItemRightHand.enabled = true;
        combatEnemyItemLeftHand.enabled = true;
        combatEnemyItemArmor.enabled = true;

        //Dice in combat
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[0];
        combatDiceSymbolEnemy.sprite = DiceSymbolSP[0];
        combatDiceBackgroundPlayer.enabled = true;
        combatDiceBackgroundEnemy.enabled = true;
        combatDiceSymbolPlayer.enabled = true;
        combatDiceSymbolEnemy.enabled = true;

        //buttons
        combatRunButton.SetActive(true);
        combatRollButton.SetActive(true);

    }

    private void UnprepairingCombatTraining()
    {
        txtClean();
        trainBackground.enabled = false;
        combatMeepleEnemy.enabled = false;
        combatMeeplePlayer.enabled = false;

        //ITEMS in combat
        combatPlayerItemHead.enabled = false;
        combatPlayerItemRightHand.enabled = false;
        combatPlayerItemLeftHand.enabled = false;
        combatPlayerItemArmor.enabled = false;
        combatPlayerDrinkItem.enabled = false;

        //Enemy items in combat
        combatEnemyItemHead.enabled = false;
        combatEnemyItemRightHand.enabled = false;
        combatEnemyItemLeftHand.enabled = false;
        combatEnemyItemArmor.enabled = false;

        //Dice in combat
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[0];
        combatDiceSymbolEnemy.sprite = DiceSymbolSP[0];
        combatDiceBackgroundPlayer.enabled = false;
        combatDiceBackgroundEnemy.enabled = false;
        combatDiceSymbolPlayer.enabled = false;
        combatDiceSymbolEnemy.enabled = false;

        //buttons
        combatRunButton.SetActive(false);
        combatRollButton.SetActive(false);


    }

    private void combatTraining()
    {
        //provjera hp-a obojci i dodjela nagrade ako je pobjeda --heal + gold
        txtCombatPlayerHP.text = thisIsPlayer.GetHP().ToString();
        txtCombatPlayerHP.text += " HP";
        txtCombatEnemyHP.text = enemyHP.ToString();
        txtCombatEnemyHP.text += " HP";

        if (enemyHP <= 0)
        {
            UnprepairingCombatTraining();
            txtCombatReward.text = "You have won 2 Gold and got healed 2 HP.\nGood luck in your next fights!";
            if (thisIsPlayer.GetHP() == 0)
            {
                thisIsPlayer.ChangeHP(1);
            }
            thisIsPlayer.ChangeGold(2);
            thisIsPlayer.ChangeHP(2);
            myState = States.reward;
        }
        else if (thisIsPlayer.GetHP() <= 0)
        {
            UnprepairingCombatTraining();
            //You died state.
            myState = States.dead;
        }

    }


    //-------------DEFAULT COMBAT FUNCTIONS------------
    public void combatRoll()
    {
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[0];
        combatDiceSymbolEnemy.sprite = DiceSymbolSP[0];
        //ALL --- ENEMYS --- AI.
        int enemyDiceRandom = Random.Range(1, 7);

        //Check which combat mod is on
        if (INNSWAPER == 1)
        {
            //TRAINING COMBAT ---- 1-Mele Attack, 2&3-Block Mele, 4&5&6-Miss
            if (enemyDiceRandom == 1)
            {
                combatDiceSymbolEnemy.sprite = DiceSymbolSP[1];
                enemyDice = 1;
            }
            else if (enemyDiceRandom == 2 || enemyDiceRandom == 3)
            {
                combatDiceSymbolEnemy.sprite = DiceSymbolSP[3];
                enemyDice = 3;
            }
            else
            {
                combatDiceSymbolEnemy.sprite = DiceSymbolSP[6];
                enemyDice = 6;
            }
        }
        else if (INNSWAPER == 2)
        {
            //this is for BOUNTY HUNT ---- 1-Mele Attack, 2&3-Block Mele, 4-Range Attack, 5&6-Miss
            if (enemyDiceRandom == 1)
            {
                combatDiceSymbolEnemy.sprite = DiceSymbolSP[1];
                enemyDice = 1;
            }
            else if (enemyDiceRandom == 2 || enemyDiceRandom == 3)
            {
                combatDiceSymbolEnemy.sprite = DiceSymbolSP[3];
                enemyDice = 3;
            }
            else if (enemyDiceRandom == 4)
            {
                combatDiceSymbolEnemy.sprite = DiceSymbolSP[2];
                enemyDice = 2;
            }
            else
            {
                combatDiceSymbolEnemy.sprite = DiceSymbolSP[6];
                enemyDice = 6;
            }
        }
        else if (INNSWAPER == 3)
        {
            //THIS IS FOR MAIN MISION
            if (mainQuestTown1 == 1)
            {
                //this is for MISSION 1 TOWN 1 ---- 1-Mele Attack, 2&3-Block Mele, 4-Range Attack, 5-Mele Attack, 6-Miss
                if (enemyDiceRandom == 1)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[1];
                    enemyDice = 1;
                }
                else if (enemyDiceRandom == 2 || enemyDiceRandom == 3)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[3];
                    enemyDice = 3;
                }
                else if (enemyDiceRandom == 4)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[2];
                    enemyDice = 2;
                }
                else if (enemyDiceRandom == 5)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[1];
                    enemyDice = 1;
                }
                else
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[6];
                    enemyDice = 6;
                }
            }
            else if (mainQuestTown1 == 2)
            {
                //this is for MISSION 2 TOWN 1 ---- 1-Range Attack, 2&3-Block Range, 4-Heal, 5-Counter Mele Attack, 6-Mele Attack
                if (enemyDiceRandom == 1)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[2];
                    enemyDice = 2;
                }
                else if (enemyDiceRandom == 2 || enemyDiceRandom == 3)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[4];
                    enemyDice = 4;
                }
                else if (enemyDiceRandom == 4)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[5];
                    enemyDice = 5;
                }
                else if (enemyDiceRandom == 5)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[9];
                    enemyDice = 9;
                }
                else
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[1];
                    enemyDice = 1;
                }
            }
            else
            {
                //this is for MISSION 3 TOWN 1 ---- 1-Mele Attack, 2-Mele Attack, 3-Heal, 4-Counter Mele Attack, 5-Counter Range Attack, 6-Block Mele
                if (enemyDiceRandom == 1 || enemyDiceRandom == 2)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[1];
                    enemyDice = 1;
                }
                else if (enemyDiceRandom == 3)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[9];
                    enemyDice = 9;
                }
                else if (enemyDiceRandom == 4)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[5];
                    enemyDice = 5;
                }
                else if (enemyDiceRandom == 5)
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[10];
                    enemyDice = 10;
                }
                else
                {
                    combatDiceSymbolEnemy.sprite = DiceSymbolSP[2];
                    enemyDice = 2;
                }
            }
        }

        //RANDOMISE A NUMBER AND RETURN SYMBOL ON DICE --- PLAYER
        playerDice = thisIsPlayer.diceRoled();
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[playerDice];

        //GET RESULT OF WHAT HAPENED:------------------------------<<
        outcomeOfRoll();
    }
    public void combatRun()
    {
        UnprepairingCombatTraining();
        UnprepairingCombatBountyHunt1();
        UnprepairingTown1Quest1();

        //lose gold || lose item || lose hp
        
        //PUNISHMENT FOR TRAINING
        if (INNSWAPER == 1)
        {
            punishment = Random.Range(1, 11);
            // --20% chance to lose hp --30% chance to lose gold
            if (punishment >= 8)
            {
                thisIsPlayer.ChangeGold(-2);
                if (thisIsPlayer.GetGold() < 0)
                {
                    thisIsPlayer.ChangeGold(thisIsPlayer.GetGold() * (-1)); //this should set gold to 0...
                }
                txtCombatReward.text = "You ran away but you lost 2 gold. You now have ";
                txtCombatReward.text += thisIsPlayer.GetGold().ToString();
                txtCombatReward.text += " gold.";

            }
            else if (punishment >= 6)
            {
                if ((thisIsPlayer.GetHP() - 2) <= 0)
                {
                    txtCombatReward.text = "You ran away but you lost one item.";
                    deleteRandomItem();
                }
                else
                {
                    thisIsPlayer.ChangeHP(-2); //if player can take 2 dmg than it takes 2 dmg, if 2 dmg would kill player than he loses one item...
                    txtCombatReward.text = "You ran away but you lost 2 HP. You now have ";
                    txtCombatReward.text += thisIsPlayer.GetHP().ToString();
                    txtCombatReward.text += " HP.";
                }
            }
            else
            {
                txtCombatReward.text = "You ran away and you luckily did not lost anything.";
            }
        }
        //PUNISHMENT FOR BOUNTY HUNT
        else if (INNSWAPER == 2)
        {
            punishment = Random.Range(1, 11);
            // --40% chance to lose hp --40% chance to lose gold
            if (punishment >= 7)
            {
                thisIsPlayer.ChangeGold(-3);
                if (thisIsPlayer.GetGold() < 0)
                {
                    thisIsPlayer.ChangeGold(thisIsPlayer.GetGold() * (-1)); //this should set gold to 0...
                }
                txtCombatReward.text = "You ran away but you lost 3 gold. You now have ";
                txtCombatReward.text += thisIsPlayer.GetGold().ToString();
                txtCombatReward.text += " gold.";

            }
            else if (punishment >= 3)
            {
                if ((thisIsPlayer.GetHP() - 3) <= 0)
                {
                    txtCombatReward.text = "You ran away but you lost one item.";
                    deleteRandomItem();
                }
                else
                {
                    thisIsPlayer.ChangeHP(-3); //if player can take 3 dmg than it takes 3 dmg, if 3 dmg would kill player than he loses one item...
                    txtCombatReward.text = "You ran away but you lost 3 HP. You now have ";
                    txtCombatReward.text += thisIsPlayer.GetHP().ToString();
                    txtCombatReward.text += " HP.";
                }
            }
            else
            {
                txtCombatReward.text = "You ran away and you luckily did not lost anything.";
            }
        }
        //PUNISHMENT FOR MAIN MISSION in first town
        else
        {
            punishment = Random.Range(1, 21);
            // --45% chance to lose hp --45% chance to lose gold --5% chance to lose item
            if (punishment >= 12)
            {
                thisIsPlayer.ChangeGold(-5);
                if (thisIsPlayer.GetGold() < 0)
                {
                    thisIsPlayer.ChangeGold(thisIsPlayer.GetGold() * (-1)); //this should set gold to 0...
                }
                txtCombatReward.text = "You ran away but you lost 5 gold. You now have ";
                txtCombatReward.text += thisIsPlayer.GetGold().ToString();
                txtCombatReward.text += " gold.";

            }
            else if (punishment >= 3)
            {
                if ((thisIsPlayer.GetHP() - 4) <= 0)
                {
                    txtCombatReward.text = "You ran away but you lost one item.";
                    deleteRandomItem();
                }
                else
                {
                    thisIsPlayer.ChangeHP(-4); //if player can take 4 dmg than it takes 4 dmg, if 4 dmg would kill player than he loses one item...
                    txtCombatReward.text = "You ran away but you lost 4 HP. You now have ";
                    txtCombatReward.text += thisIsPlayer.GetHP().ToString();
                    txtCombatReward.text += " HP.";
                }
            }
            else if (punishment >= 2)
            {
                deleteRandomItem();
                txtCombatReward.text = "You ran away but you lost one item.";
            }
            else
            {
                txtCombatReward.text = "You ran away but you lost one item.";
                deleteRandomItem();
            }
        }

        myState = States.reward;
    }

    private void deleteRandomItem()
    {
        bool getMeOutALoop = true;
        if (thisIsPlayer.GetItemHead() == 0 && thisIsPlayer.GetItemRightHand() == 0 && thisIsPlayer.GetItemLeftHand() == 0 && thisIsPlayer.GetItemArmor() == 0)
        {
            getMeOutALoop = false;
            myState = States.endGameLost;
        }

        do
        {
            punishment = Random.Range(1, 7);
            if ((punishment == 1 || punishment == 2) && thisIsPlayer.GetItemHead() != 0) // player loses head item
            {
                thisIsPlayer.ChangeItemHead(0);
                thisIsPlayer.ChangeDiceSide(5, 6);
                getMeOutALoop = false;
            }
            else if (punishment == 3 && thisIsPlayer.GetItemRightHand() != 0) // player loses right hand item
            {
                thisIsPlayer.ChangeItemRightHand(0);
                thisIsPlayer.ChangeDiceSide(1, 6);
                thisIsPlayer.ChangeDiceSide(2, 6);
                getMeOutALoop = false;
            }
            else if ((punishment == 4 || punishment == 5) && thisIsPlayer.GetItemLeftHand() != 0) // player loses left hand item
            {
                thisIsPlayer.ChangeItemLeftHand(0);
                thisIsPlayer.ChangeDiceSide(6, 6);
                getMeOutALoop = false;
            }
            else if (punishment == 6 && thisIsPlayer.GetItemArmor() != 0) // player loses right hand item
            {
                thisIsPlayer.ChangeItemArmor(0);
                thisIsPlayer.ChangeDiceSide(3, 6);
                thisIsPlayer.ChangeDiceSide(4, 6);
                getMeOutALoop = false;
            }
        } while (getMeOutALoop);
    }

    private void outcomeOfRoll()
    {
        //variable names are: enemyDice and playerDice
        // this function should do the combat outcome
        txtTopRight.text = "";
        //--------------------------------------------------PLAYER PART
        if (playerDice == 1) //Player mele attack
        {
            if (enemyDice == 3 || enemyDice == 4)
            {
                txtTopRight.text += "\nEnemy blocked your attack!";
            }
            else if (enemyDice == 9 || enemyDice == 10)
            {
                txtTopRight.text += "";
            }
            else
            {
                txtTopRight.text += "\nYou hit enemy with mele attack for ";
                txtTopRight.text += thisIsPlayer.GetDmg().ToString();
                txtTopRight.text += " dmg.";
                enemyHP = enemyHP - thisIsPlayer.GetDmg();
            }
        }
        else if (playerDice == 2) //player range attack
        {
            if (enemyDice == 4)
            {
                txtTopRight.text += "\nEnemy blocked your range attack!";
            }
            else if (enemyDice == 10)
            {
                txtTopRight.text += "";
            }
            else
            {
                txtTopRight.text += "\nYou hit enemy with range attack for ";
                txtTopRight.text += thisIsPlayer.GetDmg().ToString();
                txtTopRight.text += " dmg.";
                enemyHP = enemyHP - thisIsPlayer.GetDmg();
            }
        }
        else if (playerDice == 5) //player HP UP
        {
            if ((thisIsPlayer.GetHP() >= thisIsPlayer.GetMaxHP() && (enemyDice != 1) && (enemyDice != 2)))
            {
                txtTopRight.text += "\nYou are at full HP, cant heal at the moment";
            }
            else
            {
                txtTopRight.text += "\nYou healed yourself for 1 HP.";
                thisIsPlayer.ChangeHP(1);
            }
        }
        else if (playerDice == 7) //player 2x mele atack
        {
            if (enemyDice == 3 || enemyDice == 4 || enemyDice == 9 || enemyDice == 10)
            {
                txtTopRight.text += "\nEnemy blocked one of your mele attacks!";
                txtTopRight.text += "\nYou hit enemy with one mele attack for ";
                txtTopRight.text += thisIsPlayer.GetDmg().ToString();
                txtTopRight.text += " dmg.";
                enemyHP = enemyHP - thisIsPlayer.GetDmg();
            }
            else
            {
                txtTopRight.text += "\nYou hit enemy with both mele attacks for ";
                txtTopRight.text += (thisIsPlayer.GetDmg() * 2).ToString();
                txtTopRight.text += " dmg.";
                enemyHP = enemyHP - (thisIsPlayer.GetDmg() * 2);
            }
        }
        else if (playerDice == 8) //player 2x range atack
        {
            if (enemyDice == 4 || enemyDice == 10)
            {
                txtTopRight.text += "\nEnemy blocked one of your range attacks!";
                txtTopRight.text += "\nYou hit enemy with one range attack for ";
                txtTopRight.text += thisIsPlayer.GetDmg().ToString();
                txtTopRight.text += " dmg.";
                enemyHP = enemyHP - thisIsPlayer.GetDmg();
            }
            else
            {
                txtTopRight.text += "\nYou hit enemy with both range attacks for ";
                txtTopRight.text += (thisIsPlayer.GetDmg() * 2).ToString();
                txtTopRight.text += " dmg.";
                enemyHP = enemyHP - (thisIsPlayer.GetDmg() * 2);
            }
        }
        else if (playerDice == 9) //player Mele counter attack -- block
        {
            if (enemyDice == 1 || enemyDice == 7)
            {
                txtTopRight.text += "\nYou blocked enemy attack and successfully counter attack him.";
                txtTopRight.text += "\nYou hit enemy with one mele attack for ";
                txtTopRight.text += thisIsPlayer.GetDmg().ToString();
                txtTopRight.text += " dmg.";
                enemyHP = enemyHP - thisIsPlayer.GetDmg();
            }
            else
            {
                txtTopRight.text += "\nYou tried to counter enemy attack but failed.";
            }
        }
        else if (playerDice == 10) //player Range counter attack -- block
        {
            if (enemyDice == 1 || enemyDice == 2 || enemyDice == 7 || enemyDice == 8)
            {
                txtTopRight.text += "\nYou blocked enemy attack and successfully counter attack him.";
                txtTopRight.text += "\nYou hit enemy with one mele attack for ";
                txtTopRight.text += thisIsPlayer.GetDmg().ToString();
                txtTopRight.text += " dmg.";
                enemyHP = enemyHP - thisIsPlayer.GetDmg();
            }
            else
            {
                txtTopRight.text += "\nYou tried to counter enemy attack but failed.";
            }
        }
        
        //BORING COMBINATIONS LIKE BLOCK-BLOCK, MISS-BLOCK, MISS-MISS
        if ((playerDice == 3 || playerDice == 4 || playerDice == 6) && (enemyDice == 3 || enemyDice == 4 || enemyDice == 6))
        {
            txtTopRight.text += "\nNothing happened, both of you are playing defensive.";
        }
        //fali 11,12

        //--------------------------------------------------ENEMY PART
        if (enemyDice == 1) //Enemy mele attack
        {
            if (playerDice == 3 || playerDice == 4)
            {
                txtTopRight.text += "\nYou blocked enemy mele attack!";
            }
            else if (playerDice == 9 || playerDice == 10)
            {
                txtTopRight.text += ""; //add nothing
            }
            else
            {
                txtTopRight.text += "\nYou took hit from enemy mele attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg*(-1)));
            }
        }
        else if (enemyDice == 2) //Enemy range attack
        {
            if (playerDice == 4)
            {
                txtTopRight.text += "\nYou blocked enemy range attack!";
            }
            else if (playerDice == 10)
            {
                txtTopRight.text += ""; //add nothing
            }
            else
            {
                txtTopRight.text += "\nYou took hit from enemy range attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
        }
        else if (enemyDice == 5) //Enemy heal
        {
            txtTopRight.text += "\nEnemy healed for 1 HP!";
            enemyHP = enemyHP - 1;
        }
        else if (enemyDice == 7) //Enemy 2x mele atack
        {
            if (playerDice == 3 || playerDice == 4)
            {
                txtTopRight.text += "\nYou blocked one enemy mele attack!";
                txtTopRight.text += "\nYou took hit from enemy mele attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
            else if (playerDice == 9 || playerDice == 10)
            {
                txtTopRight.text += "\nBut you took hit from second enemy mele attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
            else
            {
                txtTopRight.text += "\nYou took hit from both enemy mele attacks for ";
                txtTopRight.text += (enemyDmg*2).ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1) * 2));
            }
        }
        else if (enemyDice == 8) //Enemy 2x range atack
        {
            if (playerDice == 4)
            {
                txtTopRight.text += "\nYou blocked one enemy range attack!";
                txtTopRight.text += "\nYou took hit from enemy range attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
            else if (playerDice == 10)
            {
                txtTopRight.text += "\nBut you took hit from second enemy range attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
            else
            {
                txtTopRight.text += "\nYou took hit from both enemy range attacks for ";
                txtTopRight.text += (enemyDmg * 2).ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1) * 2));
            }
        }
        else if (enemyDice == 9) //enemy Mele counter attack -- block
        {
            if (playerDice == 1)
            {
                txtTopRight.text += "\nEnemy blocked your attack and successfully counter attacked you.";
                txtTopRight.text += "\nEnemy hit you with one mele attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
            else if (playerDice == 7)
            {
                txtTopRight.text += "\nBut you took hit from enemy counter attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
            else
            {
                txtTopRight.text += "\nEnemy tried to counter attack but failed.";
            }
        }
        else if (enemyDice == 10) //enemy Range counter attack -- block
        {
            if (playerDice == 1 || playerDice == 2)
            {
                txtTopRight.text += "\nEnemy blocked your attack and successfully counter attacked you.";
                txtTopRight.text += "\nEnemy hit you with one range attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
            else if (playerDice == 7 || playerDice == 8)
            {
                txtTopRight.text += "\nBut you took hit from enemy counter attack for ";
                txtTopRight.text += enemyDmg.ToString();
                txtTopRight.text += " dmg.";
                thisIsPlayer.ChangeHP((enemyDmg * (-1)));
            }
            else
            {
                txtTopRight.text += "\nEnemy tried to counter attack but failed.";
            }
        }
        // 11, 12 missing
    }

    //------------------------------------REWARD SCREEN---------------------------------------
    private void reward()
    {
        
        combatRewardButton.SetActive(true);
        combatRewardBackground.enabled = true;

        if (DRUNK == true)
        {
            DRUNK = false;
            thisIsPlayer.ChangeDmg(-1);
        }

        txtClean();
    }
    public void rewardButtonClicked()
    {
        combatRewardButton.SetActive(false);
        combatRewardBackground.enabled = false;
        txtCombatReward.text = "";
        prepairingtown1();
        INNSWAPER = 0;
        myState = States.town1;
    }


    //------------------------------------------------------------------COMBAT BOUNTY HUNT---------------------------------------------------------------------->
    private void prepairingCombatBountyHunt1()
    {
        thisIsMusic.PlaySong(6);
        txtClean();
        INNSWAPER = 2;
        enemyHP = 11;
        enemyDmg = 1;

        bountyHuntBackground.enabled = true;
        combatMeepleEnemy.enabled = true;
        combatMeeplePlayer.enabled = true;

        //ITEMS in combat
        combatPlayerItemHead.sprite = ItemHeadSP[thisIsPlayer.GetItemHead()];
        combatPlayerItemRightHand.sprite = ItemRightHandSP[thisIsPlayer.GetItemRightHand()];
        combatPlayerItemLeftHand.sprite = ItemLeftHandSP[thisIsPlayer.GetItemLeftHand()];
        combatPlayerItemArmor.sprite = ItemArmorSP[thisIsPlayer.GetItemArmor()];
        combatPlayerItemHead.enabled = true;
        combatPlayerItemRightHand.enabled = true;
        combatPlayerItemLeftHand.enabled = true;
        combatPlayerItemArmor.enabled = true;
        if (DRUNK == true)
        {
            combatPlayerDrinkItem.enabled = true;
        }

        //Dice in combat
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[0];
        combatDiceSymbolEnemy.sprite = DiceSymbolSP[0];
        combatDiceBackgroundPlayer.enabled = true;
        combatDiceBackgroundEnemy.enabled = true;
        combatDiceSymbolPlayer.enabled = true;
        combatDiceSymbolEnemy.enabled = true;

        //Enemy items in combat
        x = Random.Range(0, (numHeadItems));
        combatEnemyItemHead.sprite = ItemHeadSP[x];
        x = Random.Range(0, (numRHItems));
        combatEnemyItemRightHand.sprite = ItemRightHandSP[x];
        x = Random.Range(0, (numLHItems + 1));
        combatEnemyItemLeftHand.sprite = ItemLeftHandSP[x];
        x = Random.Range(0, (numArmorItems + 1));
        combatEnemyItemArmor.sprite = ItemArmorSP[x];
        combatEnemyItemHead.enabled = true;
        combatEnemyItemRightHand.enabled = true;
        combatEnemyItemLeftHand.enabled = true;
        combatEnemyItemArmor.enabled = true;

        //buttons
        combatRunButton.SetActive(true);
        combatRollButton.SetActive(true);
        
    }

    private void UnprepairingCombatBountyHunt1()
    {
        txtClean();
        bountyHuntBackground.enabled = false;
        combatMeepleEnemy.enabled = false;
        combatMeeplePlayer.enabled = false;

        //ITEMS in combat
        combatPlayerItemHead.enabled = false;
        combatPlayerItemRightHand.enabled = false;
        combatPlayerItemLeftHand.enabled = false;
        combatPlayerItemArmor.enabled = false;
        combatPlayerDrinkItem.enabled = false;

        //Dice in combat
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[0];
        combatDiceSymbolEnemy.sprite = DiceSymbolSP[0];
        combatDiceBackgroundPlayer.enabled = false;
        combatDiceBackgroundEnemy.enabled = false;
        combatDiceSymbolPlayer.enabled = false;
        combatDiceSymbolEnemy.enabled = false;

        //Enemy items in combat
        combatEnemyItemHead.enabled = false;
        combatEnemyItemRightHand.enabled = false;
        combatEnemyItemLeftHand.enabled = false;
        combatEnemyItemArmor.enabled = false;

        //buttons
        combatRunButton.SetActive(false);
        combatRollButton.SetActive(false);
    }


    private void combatBountyHunt1()
    {
        //check hp of player and enemy and go to reward screen if enemy is dead
        txtCombatPlayerHP.text = thisIsPlayer.GetHP().ToString();
        txtCombatPlayerHP.text += " HP";
        txtCombatEnemyHP.text = enemyHP.ToString();
        txtCombatEnemyHP.text += " HP";

        if (enemyHP <= 0)
        {
            
            UnprepairingCombatBountyHunt1();
            txtCombatReward.text = "You have won and colected this bounty prize.\nYou received 5 Gold and got healed 2 HP. Good luck hunting!";
            if (thisIsPlayer.GetHP() == 0)
            {
                thisIsPlayer.ChangeHP(1);
            }
            thisIsPlayer.ChangeGold(5);
            thisIsPlayer.ChangeHP(2);
            myState = States.reward;
        }
        else if (thisIsPlayer.GetHP() <= 0)
        {
            UnprepairingCombatBountyHunt1();
            //You died state.
            myState = States.dead;
        }

    }


    //------------------------------------------------------------------COMBAT MAIN MISSION 1---------------------------------------------------------------------->

    private void prepairingTown1Quest1()
    {

        //SAME FOR ANY MISSION
        combatMeeplePlayer.enabled = true;
        txtClean();
        INNSWAPER = 3;
        //ITEMS in combat - Player
        combatPlayerItemHead.sprite = ItemHeadSP[thisIsPlayer.GetItemHead()];
        combatPlayerItemRightHand.sprite = ItemRightHandSP[thisIsPlayer.GetItemRightHand()];
        combatPlayerItemLeftHand.sprite = ItemLeftHandSP[thisIsPlayer.GetItemLeftHand()];
        combatPlayerItemArmor.sprite = ItemArmorSP[thisIsPlayer.GetItemArmor()];
        combatPlayerItemHead.enabled = true;
        combatPlayerItemRightHand.enabled = true;
        combatPlayerItemLeftHand.enabled = true;
        combatPlayerItemArmor.enabled = true;
        if (DRUNK == true)
        {
            combatPlayerDrinkItem.enabled = true;
        }



        if (mainQuestTown1 == 1)
        {
            thisIsMusic.PlaySong(7);
            enemyHP = 14;
            enemyDmg = 2;

            combatBackgroundTown1Quest1.enabled = true;
            combatMeepleEnemyTown1Quest1.enabled = true;
        }
        else if (mainQuestTown1 == 2)
        {
            thisIsMusic.PlaySong(8);
            enemyHP = 18;
            enemyDmg = 3;

            combatBackgroundTown1Quest2.enabled = true;
            combatMeepleEnemyTown1Quest2.enabled = true;
        }
        else
        {
            thisIsMusic.PlaySong(9);
            enemyHP = 24;
            enemyDmg = 4;

            combatBackgroundTown1Quest3.enabled = true;
            combatMeepleEnemyTown1Quest3.enabled = true;
        }
        


        //Dice in combat
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[0];
        combatDiceSymbolEnemy.sprite = DiceSymbolSP[0];
        combatDiceBackgroundPlayer.enabled = true;
        combatDiceBackgroundEnemy.enabled = true;
        combatDiceSymbolPlayer.enabled = true;
        combatDiceSymbolEnemy.enabled = true;


        //buttons
        combatRunButton.SetActive(true);
        combatRollButton.SetActive(true);

    }

    private void UnprepairingTown1Quest1()
    {
        txtClean();
        combatMeeplePlayer.enabled = false;

        combatMeepleEnemyTown1Quest1.enabled = false;
        combatMeepleEnemyTown1Quest2.enabled = false;
        combatMeepleEnemyTown1Quest3.enabled = false;
        combatBackgroundTown1Quest1.enabled = false;
        combatBackgroundTown1Quest2.enabled = false;
        combatBackgroundTown1Quest3.enabled = false;

        //ITEMS in combat
        combatPlayerItemHead.enabled = false;
        combatPlayerItemRightHand.enabled = false;
        combatPlayerItemLeftHand.enabled = false;
        combatPlayerItemArmor.enabled = false;
        combatPlayerDrinkItem.enabled = false;
        

        //Dice in combat
        combatDiceSymbolPlayer.sprite = DiceSymbolSP[0];
        combatDiceSymbolEnemy.sprite = DiceSymbolSP[0];
        combatDiceBackgroundPlayer.enabled = false;
        combatDiceBackgroundEnemy.enabled = false;
        combatDiceSymbolPlayer.enabled = false;
        combatDiceSymbolEnemy.enabled = false;

        //Enemy items in combat -- not used in main mission

        //buttons
        combatRunButton.SetActive(false);
        combatRollButton.SetActive(false);
    }

    private void town1Quest1()
    {
        //check hp of player and enemy and go to reward screen if enemy is dead
        txtCombatPlayerHP.text = thisIsPlayer.GetHP().ToString();
        txtCombatPlayerHP.text += " HP";
        txtCombatEnemyHP.text = enemyHP.ToString();
        txtCombatEnemyHP.text += " HP";

        if (enemyHP <= 0)
        {

            UnprepairingTown1Quest1();

            //Different rewards for each mission
            if (mainQuestTown1 == 1)
            {
                txtCombatReward.text = "You have won fight against Adron, Corporal of Gold and colected this bounty prize.\nYou received 10 Gold and got healed 3 HP. Carry on!";
                if (thisIsPlayer.GetHP() == 0)
                {
                    thisIsPlayer.ChangeHP(1);
                }
                thisIsPlayer.ChangeGold(10);
                thisIsPlayer.ChangeHP(3);
                mainQuestTown1 = 2;
                myState = States.reward;
            }
            else if (mainQuestTown1 == 2)
            {
                txtCombatReward.text = "You have won fight against Thelin, Count of Watch and colected this bounty prize.\nYou received 14 Gold and got healed 4 HP. Carry on!";
                if (thisIsPlayer.GetHP() == 0)
                {
                    thisIsPlayer.ChangeHP(1);
                }
                thisIsPlayer.ChangeGold(14);
                thisIsPlayer.ChangeHP(4);
                mainQuestTown1 = 3;
                myState = States.reward;
            }
            else
            {
                txtCombatReward.text = "You have slain last criminal leader Deimwen the Archpriest of Purity."; //+ 20 G
                if (thisIsPlayer.GetHP() == 0)
                {
                    thisIsPlayer.ChangeHP(1);
                }
                thisIsPlayer.ChangeGold(20);
                thisIsPlayer.ChangeHP(5);
                mainQuestTown1 = 4;
                myState = States.reward;
            }
            
        }
        else if (thisIsPlayer.GetHP() <= 0)
        {
            UnprepairingTown1Quest1();
            //You died state.
            myState = States.dead;
        }
    }








    //<----------------------------------------------------------------------TOWN 2----------------------------------------------------------------------------->







    //<----------------------------------------------------------------------MAIN FUNCTIONS----------------------------------------------------------------------------->
    //CLEAN ALL TEXT BOXES AND DO NOT SHOW THEM
    void txtClean()
    {

        txtBotLeft.text = "";
        txtBotRight.text = "";
        txtTopLeft.text = "";
        txtTopRight.text = "";
        txtMidDown.text = "";
        txtMidTop.text = "";

        txtTownHP.text = "";
        txtTownGold.text = "";

        txtCombatPlayerHP.text = "";
        txtCombatEnemyHP.text = "";

    }

    

    void dead()
    {
        txtCombatReward.text = "You have died in combat. Alchemist knows a way to resurrect you, but for small price.\nYou will lose one of your items but continue game with 6 HP.";
        txtMidDown.text = "Press 'Space' or 'Escape' to continue";
        if (DRUNK == true)
        {
            DRUNK = false;
            thisIsPlayer.ChangeDmg(-1);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Escape))
        {
            txtCombatReward.text = "";
            txtClean();
            prepairingtown1();
            deleteRandomItem();
            thisIsPlayer.ChangeHPDEAD(6);
            myState = States.town1;
            
        }
    }

    void endgame1()
    {
        btnTownExit.SetActive(false);
        txtCombatReward.text = "Congratulations!\nYou have won the game. Next town coming soon!!";
        txtCombatReward.text += "\n\nPress Escape or Space to exit geme.";
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

        }
    }

    void endGameLost()
    {
        btnTownExit.SetActive(false);
        txtCombatReward.text = "You have lost all your items and you can not survive in this world anymore.\nTry playing this game again.";
        txtCombatReward.text += "\n\nPress Escape or Space to exit geme.";
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

        }
    }
}
