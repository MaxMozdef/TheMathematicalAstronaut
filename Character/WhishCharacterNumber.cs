using UnityEngine;

public class WhishCharacterNumber : MonoBehaviour
{
    [SerializeField] public float characterNumber;

    float GetCharacterNumber(float charNum)
    {
        characterNumber = charNum;
        return charNum;
    }

    public void CharacterNumberChangesWhenGoingThroughDoors(Collider other, float valueChangeNumbers)
    {
        if (other.gameObject.tag == "Astronaut")
        {
            characterNumber += valueChangeNumbers;
        }
    }
}
