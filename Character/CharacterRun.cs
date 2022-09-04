using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class CharacterRun : MonoBehaviour
{
    [SerializeField] Rigidbody characterRigitbody;
    [SerializeField] float characterSpeed, characterSpeedLefrRight;
    [SerializeField] TextMeshProUGUI tapToPlayText;
    [SerializeField] Animator runAnimation;

    public static UnityAction m_Action;
    public static bool permanentRun;

    private void OnEnable()
    {
        m_Action += MoveForward;
        m_Action += MoveRightLeft;
    }

    private void OnDisable()
    {
        m_Action -= MoveForward;
        m_Action -= MoveRightLeft;
    }

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update() => m_Action();

    void MoveForward()
    {
        if (DeathCharacter.isCharacterAlive == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                HaidStartText();
                Time.timeScale = 1;
                permanentRun = true;
            }

            if (permanentRun == true)
                characterRigitbody.velocity = transform.forward * characterSpeed;
        }
        else
        {
            characterRigitbody.isKinematic = true;
            runAnimation.enabled = false;
        }
        
    }

    void MoveRightLeft()
    {
        if (Input.GetMouseButton(0) && DeathCharacter.isCharacterAlive == true)
        {
            Vector3 leftRight = new Vector3(Input.GetAxis("Mouse X") * characterSpeedLefrRight * Time.deltaTime, 0, 0);
            transform.Translate(leftRight * characterSpeedLefrRight * Time.deltaTime);
        }
    }

    void HaidStartText()
    {
        tapToPlayText.gameObject.SetActive(false);
    }
}
