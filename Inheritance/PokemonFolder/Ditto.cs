using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ditto : Pokemon
{
    void Start()
    {
        pokemonID = 0132;
        name = "Ditto";
        type = Type.Normal;
        gender = Gender.None;
        hp = 48;
        attack = 48;
        defense = 48;
        spAttack = 48;
        spDefense = 48;
        speed = 48;
    }
}
