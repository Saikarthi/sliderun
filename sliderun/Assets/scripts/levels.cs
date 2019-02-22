
using UnityEngine;

public class levels : MonoBehaviour
{
    public gamemanger g;
    void OnTriggerEnter()
    {
        g.completelevel();
    }

}
