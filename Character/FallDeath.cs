public class FallDeath : DeathCharacter
{
    private void OnEnable() => CharacterRun.m_Action += DeathFall;

    private void OnDisable() => CharacterRun.m_Action -= DeathFall;

    void DeathFall()
    {
        if (gameObject.transform.position.y < 0)
        {
            ScreenDimming();
            TimeDilation();
            ShowLoseText();
            DeathStopTime();
            ShowRetryButtonOnDeath();
        }
    }
}
