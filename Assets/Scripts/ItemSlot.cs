using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using JetBrains.Annotations;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    //----------------------------------------------------------------------------------------------------------------------//
    // Datos del ítem
    public string itemName;
    public int quantity;
    public Sprite itemSprite;
    public bool isFull;
    public bool thisItemSelected;
    public string itemDescription;
    public string itemType;
    public Sprite emptySprite;
    //----------------------------------------------------------------------------------------------------------------------//

    // Componentes del slot de ítem
    [SerializeField] private TMP_Text quantityText;
    [SerializeField] private Image itemImage;
    [SerializeField] private Image itemDescriptionImage;
    [SerializeField] private Sprite slotSprite;

    // EQUIPPED SLOTS

   // [SerializeField] public Image headSlot, eyesSlot, bodySlot, feetSlot, relicSlot, potionSlot;
   // [SerializeField] private TMP_Text headText, eyesText, bodyText, feetText, relicText, potionText;

    //----------------------------------------------------------------------------------------------------------------------//

    // Panel de estadísticas del ítem
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private TMP_Text armourText;
    [SerializeField] private TMP_Text staminaText;
    [SerializeField] private TMP_Text fashionText;

    // Variables de estadísticas del ítem
    [SerializeField] private int health;
    [SerializeField] private int armour;
    [SerializeField] private int stamina;
    [SerializeField] private int fashion;
    //----------------------------------------------------------------------------------------------------------------------//
    public Items boots, potion, bodyPart, helmet, empty;
    

    // Otros componentes
    public GameObject selectedShader;
    private InventoryManager inventoryManager;

    private void Start()
    {
        // Busca el InventoryManager en la escena y lo asigna
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();

            health = 0;
            armour = 0;
            stamina = 0;
            fashion= 0;

            healthText.text = health.ToString();
            armourText.text = armour.ToString();
            staminaText.text = stamina.ToString();
            fashionText.text = fashion.ToString();
        
       
    }

    // Agrega un ítem al panel
    public void AddItemToPanel(string itemName, int quantity, Sprite itemSprite, string itemDescription, ItemType itemType, bool thisItemSelected)
    {
        // Asigna los datos del ítem
        this.itemName = itemName;
        this.quantity = quantity;
        this.itemSprite = itemSprite; /// esta linea cambia la imagen del description image
        this.itemImage.sprite = itemSprite;
        this.itemDescriptionImage.sprite = itemSprite;
        this.itemType = itemType.ToString();
        this.thisItemSelected = thisItemSelected;
        
        

        // Muestra la cantidad del ítem
        quantityText.enabled = true;
        quantityText.text = quantity.ToString();

        // Marca el panel como lleno
        isFull = true;
    }

    // Verifica si el slot de ítem está seleccionado
    public void IsSelected()
    {
        thisItemSelected = selectedShader.activeSelf && isFull;
    }

    // Asigna estadísticas aleatorias al ítem y actualiza los textos
    public void AssignRandomStatsAndUpdateText()
    {
        if (isFull && thisItemSelected)
        {
            switch (itemName)
            {
                case "Empty":
                    health = empty.health;
                    armour = empty.armour;
                    stamina = empty.stamina;
                    fashion = empty.fashion;
                    break;
                case "Bota":
                    health = boots.health;
                    armour = boots.armour;
                    stamina = boots.stamina;
                    fashion = boots.fashion;
                    break;
                case "Escudo":
                    health = bodyPart.health;
                    armour = bodyPart.armour;
                    stamina = bodyPart.stamina;
                    fashion = bodyPart.fashion;
                    break;
                case "Potion":
                    health = potion.health;
                    armour = potion.armour;
                    stamina = potion.stamina;
                    fashion = potion.fashion;
                    break;
                case "Helmet":
                    health = helmet.health;
                    armour = helmet.armour;
                    stamina = helmet.stamina;
                    fashion = helmet.fashion;
                    break;
                default:
                    break;
            }

            // Actualiza los textos de las estadísticas
            healthText.text = health.ToString();
            armourText.text = armour.ToString();
            staminaText.text = stamina.ToString();
            fashionText.text = fashion.ToString();
        }
    }



    // Maneja el clic izquierdo en el slot de ítem
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            OnLeftClick();
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            OnRightClick();
        }
    }

    // Actualiza el slot de ítem
    public void Update()
    {

    
        if (isFull && thisItemSelected)
        {
            AssignRandomStatsAndUpdateText();
            //UpdateEquippedSlotUI();

        }
        
    }

    // Maneja el clic izquierdo en el slot de ítem
    private void OnLeftClick()
    {
        
        // Deselecciona todos los slots
        inventoryManager.DeselectAllSlots();

        // Activa el shader seleccionado y marca el slot como seleccionado
        selectedShader.SetActive(true);
        thisItemSelected = true;
        IsSelected();

        // Actualiza la imagen del ítem en el panel de descripción
        this.itemDescriptionImage.sprite = itemSprite;
        // Actualiza la imagen del ítem en el panel de equipamiento segun si ItemType
        //this.slotImage.sprite = itemSprite;

        
    }

    

    // Maneja el clic derecho en el slot de ítem
    private void OnRightClick()
    {
        // Deselecciona todos los slots
        inventoryManager.DeselectAllSlots();
    }

    


    
}





