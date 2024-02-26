using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FruitButton : MonoBehaviour
{
    public TextMeshProUGUI fruitNameTxt;
    public TextMeshProUGUI lvlText;
    public Image image;
    public void SetFruitData(Fruit unit)
    {
        fruitNameTxt.text = unit.name;
        lvlText.text = unit.level.ToString();
        image.sprite = unit.fruitImage;
    }
}
