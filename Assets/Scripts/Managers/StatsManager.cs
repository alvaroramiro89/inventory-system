using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
//using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class StatsManager : MonoBehaviour


{
    public Items boots, potion, bodyPart, helmet;
    public PlayerStats playerStats;

    public int healthManager, armourManager, staminaManager, fashionManager;

    void Start()
    {
        UpdateStats(); 
        ResetisFull();


    }
    public void ResetisFull()
    {
        boots.isEquipped = false;
        potion.isEquipped = false;
        bodyPart.isEquipped = false;
        helmet.isEquipped = false;
    }

    void Update()
    {
       UpdateStats(); 
    }

    public void ResetStats()
    {
        // Inicializar las variables para almacenar la suma de cada stat
    
    }
    public void UpdateStats()
{
    // Reset the player stats to zero
    playerStats.ResetStats();

    // Update player stats based on equipped items
    if (boots.isEquipped)
    {
        playerStats.health += boots.health;
        playerStats.armour += boots.armour;
        playerStats.stamina += boots.stamina;
        playerStats.fashion += boots.fashion;
    }

    if (potion.isEquipped)
    {
        playerStats.health += potion.health;
        playerStats.armour += potion.armour;
        playerStats.stamina += potion.stamina;
        playerStats.fashion += potion.fashion;
    }

    if (bodyPart.isEquipped)
    {
        playerStats.health += bodyPart.health;
        playerStats.armour += bodyPart.armour;
        playerStats.stamina += bodyPart.stamina;
        playerStats.fashion += bodyPart.fashion;
    }

    if (helmet.isEquipped)
    {
        playerStats.health += helmet.health;
        playerStats.armour += helmet.armour;
        playerStats.stamina += helmet.stamina;
        playerStats.fashion += helmet.fashion;
    }

    // Assign player stats to manager variables
    healthManager = playerStats.health;
    armourManager = playerStats.armour;
    staminaManager = playerStats.stamina;
    fashionManager = playerStats.fashion;

    // Log the updated stats for debugging
    Debug.Log("Health: " + healthManager);
    Debug.Log("Armour: " + armourManager);
    Debug.Log("Stamina: " + staminaManager);
    Debug.Log("Fashion: " + fashionManager);
}
}


    




