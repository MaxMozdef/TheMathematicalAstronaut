using TMPro;
using UnityEngine;
public class HintHowToGetThroughGate : HintsLevelOne
{
    [SerializeField] TextMeshProUGUI hintHowToGetThroughGateText;
    [SerializeField] Collider hintHowToGetThroughGate;

    private void OnEnable() => hintsAction += TapToSkipHint;

    private void OnDisable() => hintsAction -= TapToSkipHint;

    private void OnTriggerEnter(Collider hintHowToGetThroughGate)
    {
        TriggerActivate(hintHowToGetThroughGate, hintHowToGetThroughGateText);
    }

    void TapToSkipHint()
    {
        SkipHint(hintHowToGetThroughGateText);
    }
}
