using UnityEngine;
using TMPro; // Namespace for TextMeshPro

public class UIManager : MonoBehaviour
{
    public PlayerHealth player; // Reference to the player script
    public TextMeshProUGUI healthText; // Reference to the UI Text

    private void Update()
    {
        healthText.text = "Health: " + player.health.ToString();
    }
}
