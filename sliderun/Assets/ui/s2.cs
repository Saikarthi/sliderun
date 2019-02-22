using UnityEngine.SceneManagement;
using UnityEngine;

public class s2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void m()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
