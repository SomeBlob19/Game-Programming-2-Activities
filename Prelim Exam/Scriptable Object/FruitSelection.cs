using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class FruitSelection : MonoBehaviour
{
    public FruitManager fruitManager;
    public Transform parentPos;
    public GameObject fruitButtonPrefab;
    public FruitInfoView fruitInfoView;

    void Start()
    {
        Debug.Log(fruitManager.fruits.Count());
        foreach (Fruit f in fruitManager.fruits)
        {
            GameObject buttonPrefab = Instantiate(fruitButtonPrefab,parentPos);
            FruitButton fruitButton = buttonPrefab.GetComponent<FruitButton>();
            
            fruitButton.SetFruitData(f);
            Button button = buttonPrefab.GetComponent<Button> ();
            button.onClick.AddListener(()=> fruitInfoView.DisplayFruit(f));
        }

    }
}
