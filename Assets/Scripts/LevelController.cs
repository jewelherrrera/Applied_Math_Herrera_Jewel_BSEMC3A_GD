using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    public int giveScore;
    public int requiredScoreToWin;

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("index");
    }
}