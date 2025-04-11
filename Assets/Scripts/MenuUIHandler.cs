using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TextMeshProUGUI bestScoreText;

    void Start()
    {
        if (DataManager.Instance != null)
        {
            bestScoreText.text = $"Best Score: {DataManager.Instance.bestPlayer} : {DataManager.Instance.bestScore}";
        }
    }



    public void StartGame()
    {
        DataManager.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene(1); // or "Main" if you're using scene names
    }
}

