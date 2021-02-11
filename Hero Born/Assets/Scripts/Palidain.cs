using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palidain : Character
{
    public Weapon weapon;

    public Palidain(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - Take up your {1}!", name, weapon.name);
    }
}
