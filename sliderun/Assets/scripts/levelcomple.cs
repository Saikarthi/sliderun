
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelcomple : MonoBehaviour
{
   public void nextlevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
