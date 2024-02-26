using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public Fruit[] fruits;
    private string folderPath = "Fruit"; // Folder name inside the Assets/Resources folder

    void Awake()
    {
        fruits = Resources.LoadAll<Fruit>(folderPath);
    }
}
