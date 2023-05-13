using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    enum Profession
    {
        Carpenter,
        Police,
        Lumberjack,
        Driver,
        Soldier,
        Politician,
        Athlete,
        Teacher,
        Unoccupied
    }
    string name, lastName;
    int age;
    float health, stamina, tiredness;
    //TD-Create stats and ways to level them up(skill and attribute)
}
