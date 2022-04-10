using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    [SerializeField] private bool _restartGame;
    [SerializeField] private GameObject _restartGameMenu;
   
    public static RestartMenu Instance;
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    
    private void RestartBut()
    {
        SceneManager.LoadScene(1);
        _restartGameMenu.SetActive(false);
        Time.timeScale = 1f;
        _restartGame = false;

    }
    
    public void Restart()
    {
        _restartGameMenu.SetActive(true);
        Time.timeScale = 0f;
        _restartGame = true;
    }
}
