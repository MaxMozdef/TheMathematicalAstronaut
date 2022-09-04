using UnityEngine;

public class AnimationRun : MonoBehaviour
{
    [SerializeField] Animator runAnimator;
    float startPosition, zPositionUpdate;

    private void OnEnable() => CharacterRun.m_Action += RunAnimation;

    private void OnDisable() => CharacterRun.m_Action -= RunAnimation;

    private void Start()
    {
        startPosition = gameObject.transform.position.z;
    }

    void RunAnimation()
    {
        zPositionUpdate = gameObject.transform.position.z;

        if (zPositionUpdate < startPosition)
            runAnimator.SetBool("isRunning", true);
        else
            runAnimator.SetBool("isRunning", false);
    }
}
