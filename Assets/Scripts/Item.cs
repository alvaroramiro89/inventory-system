using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

//---------------DATOS ITEM-------// --> Nombre, cantidad, y un sprite.



    [SerializeField]    public string itemName;
    [SerializeField]    public int quantity = 1;
    [SerializeField]    public Sprite sprite;


   //---------------TODO SOBRE LA MOVIDA DE LOS STATS-------// ----> Son los 4 stats que tiene cada item: health,armor,damage,speed
    [SerializeField]     public int health;
    [SerializeField]    public int armor;
    [SerializeField]    public int damage;
    [SerializeField]    public int speed;

   

//----------------------------------------------------------------------------------------------------------------------//

    [TextArea] [SerializeField]    public string itemDescription;
    public ItemType itemType;
   

  //----------------------------------------------------------------------------------------------------------------------//  

    
}
