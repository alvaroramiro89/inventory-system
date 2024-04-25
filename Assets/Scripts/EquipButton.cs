using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class EquipItemButton : MonoBehaviour
{
    // Reference to the InventoryManager
    public InventoryManager inventoryManager;
    public StatsDisplay statsDisplay;

    public Items boots, potion, bodyPart, helmet;
    

    public ItemSlot[] itemSlot;

    // References to the equip slots
    [SerializeField] private Image headSlot, bodySlot, feetSlot, potionSlot;
    [SerializeField] private TMP_Text headText, bodyText, feetText, potionText;

    public ItemType itemType;

    // Flag to track if an item is selected
    public bool isSelected;

    private void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

    

    public void CheckSelectedItems()
    {
        // Iterate through all ItemSlots
        foreach (ItemSlot itemSlot in inventoryManager.itemSlot)
        {
            // Check if the slot is full and selected
            if (itemSlot.isFull && itemSlot.thisItemSelected)
            {
                // Get the name and type of the selected item from the current slot
                string itemName = itemSlot.itemName;
                string itemType = itemSlot.itemType.ToString(); // Convert enum to string
                
    
                
                // Check if the itemType is "head"
            if (itemType.Equals("Head", System.StringComparison.OrdinalIgnoreCase))
            {
                // Print the details of the selected item to the console
                Debug.Log("Selected head Item - Name: " + itemName + ", Type: " + itemType);
                headSlot.sprite = itemSlot.itemSprite;
                headText.text = itemSlot.itemName;
                helmet.isEquipped = true;
              
            }
            else
            {
                // Print a message indicating that the selected item is not a head item
                Debug.Log("Selected Item is not a head item.");
            }

            if (itemType.Equals("Body", System.StringComparison.OrdinalIgnoreCase))
            {
                // Print the details of the selected item to the console
                Debug.Log("Selected Body Item - Name: " + itemName + ", Type: " + itemType);
                bodySlot.sprite = itemSlot.itemSprite;
                bodyText.text = itemSlot.itemName;
                //statsDisplay.statCount++;
                bodyPart.isEquipped = true;
            }
            else
            {
                // Print a message indicating that the selected item is not a head item
                Debug.Log("Selected Item is not a body item.");
            }
            if (itemType.Equals("Feet", System.StringComparison.OrdinalIgnoreCase))
            {
                // Print the details of the selected item to the console
                Debug.Log("Selected feet Item - Name: " + itemName + ", Type: " + itemType);
                feetSlot.sprite = itemSlot.itemSprite;
                feetText.text = itemSlot.itemName;
                boots.isEquipped = true;
            }
            else
            {
                // Print a message indicating that the selected item is not a head item
                Debug.Log("Selected Item is not a feet item.");
            }
            
            

    

            if (itemType.Equals("Potion", System.StringComparison.OrdinalIgnoreCase))
            {
                // Print the details of the selected item to the console
                Debug.Log("Selected Potion Item - Name: " + itemName + ", Type: " + itemType);
                potionSlot.sprite = itemSlot.itemSprite;
                potionText.text = itemSlot.itemName;
                //statsDisplay.statCount++;
                potion.isEquipped = true;
            }
            else
            {
                // Print a message indicating that the selected item is not a head item
                Debug.Log("Selected Item is not a potion item.");
            }


            }
        }

    



    }
}
