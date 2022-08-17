public class FallDeath : DeathCharacter
{
    private void Start() => CharacterRun.m_Action += DeathFall;

    void DeathFall()
    {
        if (gameObject.transform.position.y < 0)
        {
            ScreenDimming();
            TimeDilation();
            ShowLoseText();
            DeathStopTime();
        }
    }
}
