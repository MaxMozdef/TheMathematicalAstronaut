using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class HintsLevelOne : MonoBehaviour
{
    public static UnityAction hintsAction;

    private void Update()
    {
        hintsAction();
    }

    protected void TriggerActivate(Collider other, TextMeshProUGUI hintText)
    {
        if (other.gameObject.tag == "Astronaut")
        {
            hintText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    protected void SkipHint(TextMeshProUGUI hintText)
    {
        if (Input.GetMouseButtonDown(0))
        {
            hintText.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
