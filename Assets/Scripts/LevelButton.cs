using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public int requiredPoints;
    public int LevelIndexl;
    public Button levelBtn;

    private void Start()
    {
        var currentScore = PlayerPrefs.GetInt("HighScore");
        if (currentScore >= requiredPoints)
        {
            levelBtn.interactable = true;
        }
        else
        {
            levelBtn.interactable = false;
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelIndexl);
    }
}
