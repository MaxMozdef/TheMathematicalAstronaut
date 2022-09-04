using TMPro;
using UnityEngine;

public class HintFall : HintsLevelOne
{
    [SerializeField] Collider triggerHintFallDeath;
    [SerializeField] TextMeshProUGUI hintFallDeathText;

    private void OnEnable() => hintsAction += TapToSkipHint;

    private void OnDisable() => hintsAction -= TapToSkipHint;

    private void OnTriggerEnter(Collider triggerHintFallDeath)
    {
        TriggerActivate(triggerHintFallDeath, hintFallDeathText);
    }

    void TapToSkipHint()
    {
        SkipHint(hintFallDeathText);
    }
}
