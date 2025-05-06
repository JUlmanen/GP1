using UnityEngine;
using UnityEngine.UI;

namespace AG3954
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }  // Ensures only one instance of GameManager exists and provides global access to it (Singleton).

        [SerializeField] private Text scoreText;     // Reference to UI text

        //ENCAPSULATION
        private int score = 0;                    // Sets the score to 0 at the beginning 

        private void Awake()
        {
            scoreText.text = $"Score: {score}";      // Show initial score on awake

            if (Instance != null && Instance != this)
            {
                return;
            }
            Instance = this;
        }

        //ENCAPSULATION
        public void AddScore(int amount)        
        {
            score += amount;                         // Add to total score
            UpdateScoreUI();                         // Calls UpdateScoreUI, which handles updating UI score text
        }

        private void UpdateScoreUI()
        {
            if (scoreText != null)
            {
                scoreText.text = $"Score: {score}"; //Updates the score to the HUD when the score is not null
            }
        }
    }

}