using UnityEngine;
using TMPro;

public class OpenTheDoor : MonoBehaviour
{
    [SerializeField] Collider triggerDoorOpen;
    [SerializeField] Animator leftDoorOpenAnimation, rightDoorOpenAnimation;
    [SerializeField] TextMeshProUGUI whatShouldBeTheNumberText, leftDoorChangNumberText, rightDoorChangNumberText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Astronaut")
        {
            leftDoorOpenAnimation.Play("LeftDoorOpen");
            rightDoorOpenAnimation.Play("RightDoorOpen");
            whatShouldBeTheNumberText.gameObject.SetActive(true);
            leftDoorChangNumberText.gameObject.SetActive(true);
            rightDoorChangNumberText.gameObject.SetActive(true);
        }
    }
}
