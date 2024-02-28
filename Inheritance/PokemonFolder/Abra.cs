using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abra : Pokemon
{
    void Start()
    {
        float randomNumber = Random.Range(0, 100);
        pokemonID = 0063;
        name = "Abra";
        type = Type.Psychic;
        if (randomNumber <= 75)
            gender = Gender.Male;
        else
            gender = Gender.Female;
        hp = 25;
        attack = 20;
        defense = 15;
        spAttack = 105;
        spDefense = 55;
        speed = 90;
    }
}