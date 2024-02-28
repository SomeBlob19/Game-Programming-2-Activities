using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonID = 004;
        name = "Charmander";
        type = Type.Fire;
        if (randomNumber <= 87.5)
            gender = Gender.Male;
        else
            gender = Gender.Female;
        hp = 39;
        attack = 52;
        defense = 43;
        spAttack = 60;
        spDefense = 50;
        speed = 65;
    }
}
