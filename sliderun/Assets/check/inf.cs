using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inf : MonoBehaviour
{
    public Vector3 a;

    void Update()
    {
        transform.localScale += new Vector3(0, 0, 10);
        a = transform.localScale;
    }
}
