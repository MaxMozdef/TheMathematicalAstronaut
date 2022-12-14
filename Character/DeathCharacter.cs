using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeathCharacter : MonoBehaviour
{
    [SerializeField] CharacterRun characterRun;
    [SerializeField] protected Light directionalLight;
    [SerializeField] protected TextMeshProUGUI loseText;
    [SerializeField] Button retryButton;

    float rotationX, timeDilationValue, rotationValue;
    bool useFixedUpdate;

    public static bool isCharacterAlive;

    private void Start()
    {
        isCharacterAlive = true;
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
        isCharacterAlive = false;
    }

    protected void DeathStopTime()
    {
        if (isCharacterAlive == false)
        {
            Time.timeScale = 0;
            CharacterRun.permanentRun = false;
        }
    }

    protected void ShowRetryButtonOnDeath()
    {
        if (isCharacterAlive == false)
            retryButton.gameObject.SetActive(true);
    }
}
