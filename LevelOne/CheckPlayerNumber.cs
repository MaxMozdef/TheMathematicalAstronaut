using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerNumber : DeathCharacter
{
    [SerializeField] WhishCharacterNumber whishCharacter;

    float needToWinNumber = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Astronaut" && needToWinNumber == whishCharacter.characterNumber)
        {
            print("YOU  WIN");
        }
        else
        {
            ScreenDimming();
            TimeDilation();
            ShowLoseText();
        }
    }
}
