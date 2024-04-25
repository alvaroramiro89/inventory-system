using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializerManager : MonoBehaviour
{
    public InventoryManager inventoryManager; // Referencia al InventoryManager

    public GameObject[] itemsPool;
    private void Awake()
    {
       inventoryManager = FindObjectOfType<InventoryManager>();

        // Verifica si se encontró el InventoryManager antes de llamar a LoadItems
        if (inventoryManager != null)
        {
            LoadItems();
        }
        else
        {
            Debug.LogError("InventoryManager no encontrado en la escena.");
        }
    }
    private void LoadItems() 
    {
       // Agrega el ítem al inventario
       for (int i = 0; i < itemsPool.Length; i++)
        {
        inventoryManager.AddItem(
        itemsPool[i].GetComponent<Item>().itemName,
        itemsPool[i].GetComponent<Item>().quantity,
        itemsPool[i].GetComponent<Item>().sprite,
        itemsPool[i].GetComponent<Item>().itemDescription,
        itemsPool[i].GetComponent<Item>().itemType,
        itemsPool[i].GetComponent<Item>()
        );
        }
    }
}

