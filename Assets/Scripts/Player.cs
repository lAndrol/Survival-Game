using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Character> playersCharacters = new List<Character>();


    public void addCharacterToColony(Character toAdd)
    {
        playersCharacters.Add(toAdd);
    }

}
