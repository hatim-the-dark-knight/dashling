using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public GameObject levelfinishedUI, gameoverUI;
    ObstacleSpawner obssSpawnn;

    private void Start()
    {
        obssSpawnn = GameObject.FindObjectOfType<ObstacleSpawner>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag == "ObstacleTrigger")
            obssSpawnn.SpawnObstacles();
        if (collider.transform.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            GameOver();
        }

        if (collider.transform.tag == "FinishingLine")
            LevelWon();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Survival()
    {
        SceneManager.LoadScene(8);
    }

    public void GameOver()
    {
        if(gameOver == false)
        {
            gameOver = true;
            Debug.Log("GameOver!");
            gameoverUI.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LevelWon()
    {
        levelfinishedUI.SetActive(true);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
