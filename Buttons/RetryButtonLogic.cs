using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonLogic : MonoBehaviour
{
    [SerializeField] int whichLevel;
    public void RetryButton()
    {
        SceneManager.LoadScene(whichLevel);
    }
}
