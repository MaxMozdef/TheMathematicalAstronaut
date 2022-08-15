using TMPro;
using UnityEngine;

public class DeathCharacter : MonoBehaviour
{
    [SerializeField] protected Light directionalLight;
    [SerializeField] protected TextMeshProUGUI loseText;
    float rotationX, timeDilationValue, rotationValue;
    bool useFixedUpdate;

    private void Start()
    {
        timeDilationValue = Time.timeScale;
        rotationX = directionalLight.transform.rotation.x;
    }

    protected void ScreenDimming()
    {
        if (!useFixedUpdate && rotationX >= -17.5)
        {
            rotationValue = 0.2f;
            rotationX -= rotationValue;
        }
        else
            return;

        directionalLight.transform.rotation = Quaternion.Euler(rotationX, -30, 0);
    }

    protected void TimeDilation()
    {
        if (!useFixedUpdate)
            timeDilationValue = 0;

        Time.timeScale = timeDilationValue;
    }

    protected void ShowLoseText()
    {
        loseText.gameObject.SetActive(true);
    }
}
