using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clefairy : Pokemon
{
    void Start()
    {
        pokemonID = 0035;
        name = "Clefairy";
        type = Type.Fairy;
        gender = Gender.Female;
        hp = 70;
        attack = 45;
        defense = 48;
        spAttack = 60;
        spDefense = 65;
        speed = 35;
    }
}
