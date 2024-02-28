using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    [Header("PokemonID")]
    public int pokemonID;
    [Header("Name")]
    public string name;
    [Header("Type")]
    public Type type;
    [Header("Gender")]
    public Gender gender;
    [Header("Abilities")]
    public int hp;
    public int attack;
    public int defense;
    public int spAttack;
    public int spDefense;
    public int speed;

    public int randomNumber;

    void Start()
    {
        randomNumber = Random.Range(1, 100);
        Debug.Log(randomNumber);
    }
}
