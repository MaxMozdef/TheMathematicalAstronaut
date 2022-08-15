using TMPro;
using UnityEngine;
public class HintHowToGetThroughGate : HintsLevelOne
{
    [SerializeField] TextMeshProUGUI hintHowToGetThroughGateText;
    [SerializeField] Collider hintHowToGetThroughGate;

    private void Start() => hintsAction += TapToSkipHint;

    private void OnTriggerEnter(Collider hintHowToGetThroughGate)
    {
        TriggerActivate(hintHowToGetThroughGate, hintHowToGetThroughGateText);
    }

    void TapToSkipHint()
    {
        SkipHint(hintHowToGetThroughGateText);
    }
}
