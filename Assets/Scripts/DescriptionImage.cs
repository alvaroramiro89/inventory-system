using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using JetBrains.Annotations;
public class DescriptionImage : MonoBehaviour
{

    [SerializeField]
    public Image descriptionImage;

    public Sprite blankSprite;

    public TMP_Text healthText, armourText, staminaText, fashionText;
    
    // Start is called before the first frame update
    void Awake()
    {
        descriptionImage.sprite = blankSprite;
        healthText.text = "0";
        armourText.text = "0";
        staminaText.text = "0";
        fashionText.text= "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
