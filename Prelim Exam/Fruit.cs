using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "Fruits", menuName ="ScriptableObjects/Fruits")]
public class Fruit : ScriptableObject
{
    // Common attributes for all Fruits
    public string name;
    public int level;
    public int hp;
    public int defense;
    public int speed;
    public Sprite fruitImage;

    [TextArea]
    public string description;
    
    public FruitType type;
    public Moves[] moves;

    // Common behavior for all Fruits
    public void Attack()
    {
        Debug.Log($"{name} used Tackle!");
    }

    
}



