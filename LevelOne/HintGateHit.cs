using TMPro;
using UnityEngine;

public class HintGateHit : HintsLevelOne
{
    [SerializeField] TextMeshProUGUI hintGateHitText;
    [SerializeField] Collider hintGateHit;

    private void Start() => hintsAction += TapToSkipHint;

    private void OnTriggerEnter(Collider hintGateHit)
    {
        TriggerActivate(hintGateHit, hintGateHitText);
    }

    void TapToSkipHint()
    {
        SkipHint(hintGateHitText);
    }
}
