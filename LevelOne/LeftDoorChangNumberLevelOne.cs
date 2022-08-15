using UnityEngine;

public class LeftDoorChangNumberLevelOne : MonoBehaviour
{
    [SerializeField] float valueChangeNumber;
    [SerializeField] WhishCharacterNumber whishCharacter;

    private void OnTriggerEnter(Collider other)
    {
        whishCharacter.CharacterNumberChangesWhenGoingThroughDoors(other, valueChangeNumber);
    }
}
