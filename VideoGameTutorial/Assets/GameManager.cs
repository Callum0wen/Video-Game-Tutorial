using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Complete Level");
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restard", restartDelay);
        }
    }

    void Restard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
