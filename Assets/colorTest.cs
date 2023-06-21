using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorTest : MonoBehaviour
{
    [SerializeField]
    private float changeColorTime=0f;
    
    private float time=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= changeColorTime)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f,1f), Random.Range(0f, 1f));
            time = 0f;
        }
    }
}
