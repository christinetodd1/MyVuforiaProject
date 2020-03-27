using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{

    public TextMeshProUGUI output; //reacting with text mesh pro ui dropdown

    void Start()
    {
        //GetComponent<TextMesh>().fontSize = 12;
        output.text = "Fire Element: Take double damage from Ice attacks. Take half damage from Fire attacks when in Fire Zone.";
    }

    public void HandleInputData(int val)
    {
       
        if (val == 0)
        {//first option

            output.text = "Fire Element: Take double damage from Ice attacks. Take half damage from Fire attacks when in Fire Zone.";
        }
        if(val ==1)
        {
            output.text = "Earth Element: Take double damage from Wind attacks. Take half damage from Wind attacks when in Earth Zone.";
        }
        if(val == 2)
        {
            output.text = "Ice Element: Take double damage from Fire attacks. Take half damage from Ice attacks when in Ice Zone.";
        }
        if (val == 3)
        {
            output.text = "Wind Element: Take double damage from Wind attacks.Take half damage from Earth attacks when in Earth Zone.";
        }

        
    }
}

