using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintFall : HintsLevelOne
{
    [SerializeField] Collider triggerHintFallDeath;
    [SerializeField] TextMeshProUGUI hintFallDeathText;

    private void Start() => hintsAction += TapToSkipHint;

    private void OnTriggerEnter(Collider triggerHintFallDeath)
    {
        TriggerActivate(triggerHintFallDeath, hintFallDeathText);
    }

    void TapToSkipHint()
    {
        SkipHint(hintFallDeathText);
    }
}
