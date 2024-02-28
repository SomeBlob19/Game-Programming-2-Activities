using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makuhita : Pokemon
{
    void Start()
    {
        float randomNumber = Random.Range(0, 100);
        pokemonID = 0296;
        name = "Makuhita";
        type = Type.Fighting;
        if (randomNumber <= 75)
            gender = Gender.Male;
        else
            gender = Gender.Female;
        hp = 72;
        attack = 60;
        defense = 30;
        spAttack = 20;
        spDefense = 30;
        speed = 20;
    }
}