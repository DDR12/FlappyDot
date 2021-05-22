using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject QuitPopupUI;
    public Text BestScoreText;
    public Button openLeaderboardButton = null;

    void Awake()
    {
        QuitPopupUI.SetActive(false);
        BestScoreText.text = "BEST SCORE\n" + PlayerPrefs.GetInt(MainController.Prefs_BestScore_Key, MainController.Prefs_BestScore_DefaultValue);
        openLeaderboardButton.onClick.AddListener(OpenLeaderboard);
    }

    private void OpenLeaderboard()
    {
        // Uncomment once you install the unity firebase sdk.
        //FirebaseDatabase.DefaultInstance.GetReference("TopScores").GetValueAsync().ContinueWith(task => 
        //{
        //    if (task.IsFaulted)
        //    {
        //         // Handle the error...
        //         // Show message failed to load leaderboard.
        //    }
        //    else if (task.IsCompleted)
        //    {
        //        DataSnapshot snapshot = task.Result;
        //        // Display the leaderboard entries...
        //    }
        //});
    }

    void Start()
    {
        // TODO hide adbanner.
        // TapsellStandardBanner.Hide();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitPopupToggle();
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitPopupToggle()
    {
        if (!QuitPopupUI.activeSelf)
        {
            QuitPopupUI.SetActive(true);
        }
        else
        {
            QuitPopupUI.SetActive(false);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
