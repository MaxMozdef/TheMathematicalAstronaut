using TMPro;
using UnityEngine;

public class HintYouTwo : HintsLevelOne
{
    [SerializeField] TextMeshProUGUI hintYouTwoText;
    [SerializeField] Collider triggerYouTwo;

    private void OnEnable() => hintsAction += TapToSkipHint;
    private void OnDisable() => hintsAction -= TapToSkipHint;

    private void OnTriggerEnter(Collider triggerYouTwo)
    {
        TriggerActivate(triggerYouTwo, hintYouTwoText);
    }

    void TapToSkipHint()
    {
        SkipHint(hintYouTwoText);
    }
}
