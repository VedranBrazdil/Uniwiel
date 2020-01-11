using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    //Basic Stats
    public int HP, Gold, HitDmg, maxHP;



    //boolies
    //bool Alive;
    bool petOwned;

    //ITEMS:
    int ItemHead, ItemRightHand, ItemLeftHand, ItemArmor;
    //ItemHead says which right hand item you have            //
    //ItemRightHand says which left hand item you have       //1.chmkSWORD, 2.chmkMACE
    //ItemLeftHand says which body armor item you have      //
    //ItemArmor says which head armor item you have        //1.chmkBREASTPLATE, 2.chmkCLOTH

    //PETS:
    //int PET; //1.Cat, 2.Dog, 3.Hound
    //int[] PETdice = new int[7]; //explained under DICE section


    //DICE
    int[] DICESIDE = new int[7];
    //public int diceSide1 = 0, diceSide2 = 0, diceSide3 = 0, diceSide4 = 0, diceSide5 = 0, diceSide6 = 0;    //List<int> DICESIDE = new List<int>();
    
    //--------------------------------------------LIST OF DICESIDE ABILITYS-------------------------------------------------------
    //
    // 0=EMPTY, 1=Mele attack, 2=Range attack, 3=Mele block, 4=Range&Mele block, 5=Heal, 6=MISS, 7=2xMele, 8=2xRange
    // 9=Mele Counter Attack, 10=Range Counter Attack, 11=BoostMele if not hit, 12=BoostRange if not hit
    //
    // for PET:
    // 0=EMPTY, 1=MISS, 2=Mele attack, 3=Stun
    //--------------------------------------------LIST OF DICESIDE ABILITYS-------------------------------------------------------




    //<-----------------------------------------------------------------MAIN FUNCTIONS-------------------------------------------------------->
	// Use this for initialization
	void Start () {
        //STATS
        //Alive = true;
        petOwned = false;
        HP = 8;
        maxHP = 15;
        HitDmg = 1;
        Gold = 2;

        //DICE
        DICESIDE[0] = 0; //this one is not in use, just to simplify the code...
        DICESIDE[1] = 6; //6 is MISS
        DICESIDE[2] = 6;
        DICESIDE[3] = 6;
        DICESIDE[4] = 6;
        DICESIDE[5] = 6;
        DICESIDE[6] = 6;

        //WEAPONS AND ARMOR
        ItemHead = 0;
        ItemRightHand = 0;
        ItemLeftHand = 0;
        ItemArmor = 0;

		
	}
	
	// Update is called once per frame
	void Update () {
	}

    //RETURN GOLD
    public int GetGold()
    {
        return Gold;
    }
    //+/- Gold
    public void ChangeGold(int x)
    {
        Gold = Gold + x;
    }

    //RETURN HP
    public int GetHP()
    {
        return HP;
    }
    //+/- HP
    public void ChangeHP(int x)
    {
        HP = HP + x;
        //if (HP <= 0)
        //{
            //Alive = false;
        //}
        if (HP > GetMaxHP())
        {
            HP = GetMaxHP();
        }
    }

    //DEAD STATE
    public void ChangeHPDEAD(int x)
    {
        HP = x;
        //Alive = true;

    }

    //RETURN MAX HP
    public int GetMaxHP()
    {
        return maxHP;
    }
    //Change MAX HP
    public void ChangeMaxHP(int x)
    {
        maxHP = maxHP + x;
    }

    // Get Mele dmg
    public int GetDmg()
    {
        return HitDmg;
    }
    public void ChangeDmg(int x)
    {
        HitDmg = HitDmg + x;
    }

    // PET
    public bool isPetOwned()
    {
        if (petOwned == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    //<-------------------------------------------------------CHARACTER MAKER STARTING STATS------------------------------------------------------>
    public void CreatingCharacter(int x, int y)
    {
        if (x == 1)
        {
            //Sword has been taken - sides 1 and 2 are mele attack
            DICESIDE[1] = 1;
            DICESIDE[2] = 1;

            ItemRightHand = 1;
        }
        else
        {
            //Mace has been taken - side 1 is mele attack and side 2 is mele block
            DICESIDE[1] = 1;
            DICESIDE[2] = 3;

            ItemRightHand = 2;
            HP = HP + 2; // ADD 2 to HP
        }

        if (y == 1)
        {
            //Breastplate has been taken - sides 3 and 4 are block mele attack
            DICESIDE[3] = 3;
            DICESIDE[4] = 3;

            ItemArmor = 1;
            HP = HP + 4; // ADD 4 to HP
        }
        else
        {
            //Cloth armor has been taken - side 1 is mele attack and 2 is mele block
            DICESIDE[3] = 1;
            DICESIDE[4] = 3;

            ItemArmor = 2;
            HP = HP + 2; // ADD 2 to HP
        }
    }


    //--------------------------------------------------------------INVENTORY FUNCTIONS--------------------------------------------------

    //RETURN ITEM NUMBER --- used to put item imgs on meeple
    public int GetItemHead()
    {
        return ItemHead;
    }

    public int GetItemRightHand()
    {
        return ItemRightHand;
    }

    public int GetItemLeftHand()
    {
        return ItemLeftHand;
    }

    public int GetItemArmor()
    {
        return ItemArmor;
    }

    //CHANGE ITEM NUMBER --- used to add / or change items
    public void ChangeItemHead(int x)
    {
        ItemHead = x;
    }

    public void ChangeItemRightHand(int x)
    {
        ItemRightHand = x;
    }

    public void ChangeItemLeftHand(int x)
    {
        ItemLeftHand = x;
    }

    public void ChangeItemArmor(int x)
    {
        ItemArmor = x;
    }


    //--------------change Dice sides VALUE --- x= dice side, y= new value;
    public void ChangeDiceSide(int x, int y)
    {
        DICESIDE[x] = y;
    }
    //--- returns sprite for DICESIDE
    public int GetDiceSide(int x)
    {
        return DICESIDE[x];
    }



    //--------------------------------------------------------------COMBAT IS DONE HERE--------------------------------------------------


    //This is called when you roll dice --- it will return Value of random side ---- (block,attack....)
    public int diceRoled ()
    {
        int randomInt = Random.Range(1, 7);
        return DICESIDE[randomInt];
    }

    public void diceSideChange(int x, int y)
    {
        //x is dice side and y is dice function(attack,block...)
        DICESIDE[x] = y;
        //used when item is bought or when item is lost ( when you die and get revived )
    }
}
