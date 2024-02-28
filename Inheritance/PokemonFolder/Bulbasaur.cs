using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulbasaur : Pokemon
{
    void Start()
    {
        pokemonID = 001;
        name = "Bulbasaur";
        type = Type.Grass;
        if (randomNumber <= 87.5)
            gender = Gender.Male;
        else
            gender = Gender.Female;
        hp = 45;
        attack = 49;
        defense = 49;
        spAttack = 65;
        spDefense = 65;
        speed = 45;
    }
}
