using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zigzagoon : Pokemon
{
    void Start()
    {
        pokemonID = 0263;
        name = "Zigzagoon";
        type = Type.Normal;
        gender = Gender.Male;
        hp = 38;
        attack = 30;
        defense = 41;
        spAttack = 30;
        spDefense = 41;
        speed = 60;
    }
}