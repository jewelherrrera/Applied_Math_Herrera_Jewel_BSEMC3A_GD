using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    [Header("UI Text")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI damageText;
    public TextMeshProUGUI defenseText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI critRateText;

    [Header("Player Stats")]
    public int health = 300;
    public float damage = 50.3f;
    public int defense = 100;
    public float moveSpeed = 30.93f;
    public float critRate = 15.63f;

    void Start()
    {
        UpdateStatsUI();
    }

    public void UpdateStatsUI()
    {
        healthText.text = "Health: " + health.ToString();
        damageText.text = "Damage: " + damage.ToString();
        defenseText.text = "Defense: " + defense.ToString();
        speedText.text = "Speed: " + moveSpeed.ToString();
        critRateText.text = "Critical: " + critRate.ToString();
    }
}