
using UnityEngine;

public class col : MonoBehaviour
{
    public movment d;
    public scorce a;
    public GameObject s;

    
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obj") {
            d.enabled = false;
            a.enabled = false;
           
            Invoke("re", 2f);


        }
       
    }
    public void re()

    {
        s.SetActive(true);
    }
}
