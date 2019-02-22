
using UnityEngine;
using UnityEngine.UI;

public class scorce : MonoBehaviour
{
    public Transform p;

    public Text s;
    public Text s1;

    void Update()
    {
        s.text = p.position.z.ToString("0");
        s1.text = p.position.z.ToString("0");
    }
}
