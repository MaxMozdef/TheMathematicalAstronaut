using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hintrusian : HintsLevelOne
{
    [SerializeField] TextMeshProUGUI hintrusianText;
    [SerializeField] Collider triggerHintrusian;

    private void OnEnable() => hintsAction += TapToSkipHint;

    private void OnDisable() => hintsAction -= TapToSkipHint;

    private void OnTriggerEnter(Collider triggerHintrusian)
    {
        TriggerActivate(triggerHintrusian, hintrusianText);
    }

    void TapToSkipHint()
    {
        SkipHint(hintrusianText);
    }
}
