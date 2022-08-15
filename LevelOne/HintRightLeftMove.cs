using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintRightLeftMove : HintsLevelOne
{
    [SerializeField] Collider triggerHintRighyLeftMove;
    [SerializeField] TextMeshProUGUI hintMoveRightLeftText;

    private void Start() => hintsAction += TapToSkipHint;

    private void OnTriggerEnter(Collider triggerHintRighyLeftMove)
    {
        TriggerActivate(triggerHintRighyLeftMove, hintMoveRightLeftText);
    }

    void TapToSkipHint()
    {
        SkipHint(hintMoveRightLeftText);
    }
}
