using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private bool _pauseGame;
    [SerializeField] private GameObject _pauseGameMenu;

    private void Resume()
    {
        _pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        _pauseGame = false;
    }

    private void Pause()
    {
        _pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        _pauseGame = true;
    }

    private void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    private void Reload()
    {
        SceneManager.LoadScene(1);
    }
}