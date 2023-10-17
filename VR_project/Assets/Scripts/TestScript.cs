using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sphere = GameObject.Find("Sphere");
            inst();
        }
    }

    void inst()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 nv = new Vector3(i, 0, 0);
            Instantiate(gameObject, nv, sphere.transform.rotation);
        }
    }
}
