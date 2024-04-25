using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
//using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class StatsDisplay : MonoBehaviour


{
    //public Items boots, potion, bodyPart, helmet;
    public PlayerStats playerStats;
    public StatsManager statsManager;

    public int healthManager, armourManager, staminaManager, fashionManager;

    // Start is called before the first frame update
    public TMP_Text healthTxt;
    public TMP_Text armourTxt;
    public TMP_Text staminaTxt;
    public TMP_Text fashionTxt;

    public int statCount = 0;

    void Start()
    {
        statsManager = GameObject.Find("StatsManager").GetComponent<StatsManager>();
        
        
    }

    void Update()
    {
       //UpdateStatsText(); 

    }

    

    //THis function is called when equip button is pressed
    public void UpdateStatsText()
    {
    
    // Asignar los valores de la suma a los Text correspondientes
    healthTxt.text = statsManager.healthManager.ToString();
    armourTxt.text = statsManager.armourManager.ToString();
    staminaTxt.text = statsManager.staminaManager.ToString();
    fashionTxt.text = statsManager.fashionManager.ToString();
    }


    
}


    




