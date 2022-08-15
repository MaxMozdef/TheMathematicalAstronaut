using UnityEngine;

public class RightDoorChangNumberLevelOne : MonoBehaviour
{
    [SerializeField] float valueChangeNumber;
    [SerializeField] WhishCharacterNumber whishCharacter;

    private void OnTriggerEnter(Collider other)
    {
        whishCharacter.CharacterNumberChangesWhenGoingThroughDoors(other, valueChangeNumber);
    }
}
