using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class CharacterRun : MonoBehaviour
{
    [SerializeField] Rigidbody characterRigitbody;
    [SerializeField] float characterSpeed, characterSpeedLefrRight;
    [SerializeField] TextMeshProUGUI tapToPlayText;
    public static UnityAction m_Action;
    bool permanentRun;

    void Start()
    {
        m_Action += MoveForward;
        m_Action += MoveRightLeft;
        Time.timeScale = 0;
    }

    void Update() => m_Action();

    void MoveForward()
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

    void MoveRightLeft()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 leftRight = new Vector3(Input.GetAxis("Mouse X") * characterSpeedLefrRight * Time.deltaTime, 0, 0);
            transform.Translate(leftRight * characterSpeedLefrRight);
        }
    }

    void HaidStartText()
    {
        tapToPlayText.gameObject.SetActive(false);
    }
}
