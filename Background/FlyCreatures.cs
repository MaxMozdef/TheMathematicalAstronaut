using UnityEngine;

public class FlyCreatures : MonoBehaviour
{
    const float speedCreaturesFly = 9;

    void Update()
    {
        transform.Translate(Vector3.right * speedCreaturesFly * Time.deltaTime);
    }
}
