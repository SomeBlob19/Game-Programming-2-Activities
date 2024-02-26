using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FruitInfoView : MonoBehaviour
{
    public Fruit fruit;

    [Header("UI Headers")]
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI levelTMP;
    public TextMeshProUGUI hpTMP;
    public TextMeshProUGUI defenseTMP;
    public TextMeshProUGUI speedTMP;
    public TextMeshProUGUI typeTMP;
    public TextMeshProUGUI descriptionTMP;

    public void OnEnable()
    {
        DisplayFruit(fruit);
    }
    public void DisplayFruit (Fruit fruit)
    {
        nameTMP.text = fruit.name;
        levelTMP.text = "Level: " + fruit.level.ToString();
        hpTMP.text = "HP: " + fruit.hp.ToString();
        typeTMP.text = "Type: " + fruit.type.ToString();
        defenseTMP.text = "Def: " + fruit.defense.ToString();
        speedTMP.text = "Spd: " + fruit.speed.ToString();
        descriptionTMP.text = fruit.description;
    }

    public void ClearView()
    {
        fruit = null;
        nameTMP.text = null;
        levelTMP.text = null;
        hpTMP.text = null;
        typeTMP.text = null;
        defenseTMP.text = null;
        speedTMP.text = null;
        descriptionTMP.text = null;
        
    }
    public void OnDisable()
    {
        ClearView();
    }
}
