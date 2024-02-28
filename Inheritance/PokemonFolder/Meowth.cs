using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meowth : Pokemon
{
    void Start()
    {
        float randomNumber = Random.Range(0, 100);
        pokemonID = 0052;
        name = "Meowth";
        type = Type.Normal;

        if (randomNumber >= 50)
            gender = Gender.Male;
        else
            gender = Gender.Female;

        hp = 40;
        attack = 45;
        defense = 35;
        spAttack = 40;
        spDefense = 40;
        speed = 90;
    }
}
