using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdatedHealth : MonoBehaviour
{
   // public Button yourButton;
    public int Health; //this is where the array will be stored
    public int numOfHearts; //when this is equal to 1 there should only be 1 visable
    public Image[] hearts; //Im creating an array for the 2 images so I can toggle their visability
    public Sprite fullHeart; //image of fullheart to be displayed
    public Sprite emptyHeart;
    public Sprite bonusHeart;
   // public ScriptA scriptA;

    public void Start()
       
    {
        //scriptA.MethodFromA();
        //Button btn = yourButton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
        ////btn.onClick.AddListener(TaskOnClick2);
    }
    public void TaskOnClick()
    {
        Health -= 1; //when you click the button it will subtract one heart
        //numOfHearts -= 1;
        if (Health <= 0)
        {
            
            Health = 0;
        }
        if (numOfHearts >= 11) //do this or else it will add an empty heart when you click the plus
        {
            numOfHearts -= 1;
        }

    }
    public void TaskOnClick1()
    {
        Health += 1; //when you click the button it will fill one heart
        numOfHearts += 1; //add a heart
     
        if (numOfHearts >= 15) //this sets it so that it wont go over (invisibly)
        {
            numOfHearts = 15;
        }
        if (Health <= 10) //Makes sure that heart containers arent added if player is less than ten
        {
            numOfHearts = 10;
        }
        // if (numOfHearts > 10) 
        //{
        //    Health. = bonusHeart;

        //}


    }

    void Update()
    { //creating a for loop, so that the interger we set in the editor matches the amount of hearts visable

        if (Health > numOfHearts)
        {   //checking whether health is greater than number of containers
            Health = numOfHearts;   //making sure it all matches up
        }



        for (int i = 0; i < hearts.Length; i++)
        { //want loop to run as long as variable i, is less than the num of hearts in heart array(10)

            if (i < Health & numOfHearts <= 14) //checking weather i is smaller than amount of health player currently has and will display a full heart is it is
            {
                hearts[i].sprite = fullHeart;
            }


            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < Health & numOfHearts > 14) //checking weather i is larger than amount of health player currently has and will display the bonus heart color if it is
            {
                hearts[i].sprite = bonusHeart; //gold hearts max amount
            }


            if (i < numOfHearts) //with each iteration of a loop, check whether i is smaller than num of hearts that player has
            {
                hearts[i].enabled = true; //if i is smaller then we want the heart to be visable
            }

            else
            {
                hearts[i].enabled = false; // if i is bigger than num of hearts then we want those hearts in the array to be hidden
            }

        }
    }
}



