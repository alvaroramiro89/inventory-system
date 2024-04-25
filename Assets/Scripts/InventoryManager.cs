using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
   
    public GameObject InventoryMenu;

    public InventoryManager inventoryManager;
    //private bool menuActivated;
    public ItemSlot[] itemSlot; // -----------------> Esta es la papaya, ARRAY INVENTARIO de objetos tipo ItemSlot

    // Start is called before the first frame update




    //1------------------------------------------------------------------------------------------------------------------------//
    void Start()
    {
        // Desactiva el menú de inventario al iniciar el juego
       
        InventoryMenu.SetActive(false);
       
    }
    //2------------------------------------------------------------------------------------------------------------------------//

    // Update is called once per frame
    void Update()
    {
        

        //if (Input.GetButtonDown("Equipment") )
        
    }
    //3-----------------------------------------------------------------------------------------------------------------------//
        // ACTIVAR MENU APRETANDO TECLA "W"
    public void Inventory()
    {
        if (InventoryMenu.activeSelf)
        {
            // Desactiva el menú de inventario si ya está activado
            
            InventoryMenu.SetActive(false);
        }
        else 
        {
            // Activa el menú de inventario si está desactivado y desactiva Menu de Equipment
            
            InventoryMenu.SetActive(true);
        }
    }

    

    //------------------------------------------------------------------------------------------------------------------------//
    
    public void AddItem(string itemName, int quantity, Sprite sprite, string itemDescription, ItemType itemType, bool thisItemSelected)
    {
        for (int i = 0; i< itemSlot.Length; i++)
        {
            if(itemSlot[i].isFull == false)
            {
                itemSlot[i].AddItemToPanel(itemName, quantity, sprite, itemDescription, itemType, thisItemSelected);
                return;
            }

        }
    }

    //------------------------------------------------------------------------------------------------------------------------//
        public bool IsAnyItemSlotSelected()
{
    // Itera a través de los ItemSlots
    foreach (ItemSlot slot in itemSlot)
    {
        // Verifica si el ItemSlot está seleccionado
        if (slot.thisItemSelected)
        {
            // Si al menos un ItemSlot está seleccionado, devuelve true
            return true;
        }
    }
    
    // Si ninguno de los ItemSlots está seleccionado, devuelve false
    return false;
}



    public void DeselectAllSlots()
    {
        for (int i = 0; i< itemSlot.Length; i++)
        {
           itemSlot[i].selectedShader.SetActive(false);
           itemSlot[i].thisItemSelected = false;

        }
    }  
}
public enum ItemType
{
    head,
    body,
    feet,
    eyes,
    relic,
    potion,
    none,
    Head,
};