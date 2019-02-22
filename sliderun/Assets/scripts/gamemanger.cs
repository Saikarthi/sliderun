
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanger : MonoBehaviour
{
    bool g = false;
    public GameObject c;
    public GameObject s;
    public void completelevel()
    {
        c.SetActive(true);
    }
    public void endgame()
    {
        if (g == false)
        {
            g = true;
            Debug.Log("game over");
            Invoke("restart", 2f);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
