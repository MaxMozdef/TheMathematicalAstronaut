using UnityEngine;

public class FromPigDeath : DeathCharacter
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "YobaniyRuski")
        {
            ScreenDimming();
            TimeDilation();
            ShowLoseText();
            DeathStopTime();
            ShowRetryButtonOnDeath();
        }
    }
}
