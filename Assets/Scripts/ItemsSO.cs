using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;






[CreateAssetMenu(fileName = "New Card", menuName = "Cards1")]


public class Items : ScriptableObject
{
    public string itemName;

    public bool isEquipped;

    public int health;
    public int armour;
    public int stamina;
    public int fashion;
 
 
    
}
