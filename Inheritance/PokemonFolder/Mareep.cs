using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mareep : Pokemon
{
    void Start()
    {
        pokemonID = 0179;
        name = "Mareep";
        type = Type.Electric;
        gender = Gender.Male;
        hp = 55;
        attack = 40;
        defense = 40;
        spAttack = 65;
        spDefense = 45;
        speed = 35;
    }
}