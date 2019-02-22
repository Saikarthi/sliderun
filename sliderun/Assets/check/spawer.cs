using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawer : MonoBehaviour
{
    public GameObject obj;
    public Vector3 spawnvalue;
    public float spawnwait;
    public float spawnmostvalue;
    public float spawnleastvalue;
    public int startwait;
    public int i=0;
    public inf d;
    public movment f;
    public Vector3 h = new Vector3(0, 0, 0);
    public bool stop;
    int ran;


    void Start()
    {
        StartCoroutine(waitSpawer());

        
    }


    void Update()
    {

        spawnwait = Random.Range(spawnleastvalue, spawnmostvalue);
    }
    IEnumerator waitSpawer () {
        yield return new WaitForSeconds(startwait);
        while (!stop) {

            spawnvalue.z = d.a.z;
            h.z = f.s.z+10;


            
            Vector3 spawnpostion = new Vector3(Random.Range(-spawnvalue.x, spawnvalue.x), 1, Random.Range(h.z, spawnvalue.z));
            
            Instantiate(obj, spawnpostion + transform.TransformPoint(0, 0, i), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnwait);

            i = i + 5;



            

        }

    }
}
