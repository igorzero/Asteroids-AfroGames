using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeEstudo : MonoBehaviour
{
    public float velocidade;
    public GameObject meteoro;

    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("AfroGames");  
    
    }

    // Update is called once per frame
    void Update()
    {
        if    (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0.0f, velocidade * Time.deltaTime, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0ff);
        }
        if    (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0.0f, -velocidade * Time.deltaTime, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0ff); 
        }
    }
}            
