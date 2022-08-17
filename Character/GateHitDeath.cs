using UnityEngine;

public class GateHitDeath : DeathCharacter
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            ScreenDimming();
            TimeDilation();
            ShowLoseText();
            DeathStopTime();
        }
    }
}
