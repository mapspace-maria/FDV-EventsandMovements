using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Vector3 goal;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,speed*Input.GetAxis("Vertical")*Time.deltaTime);
    }

    public void SetSpeed (float otherspeed)
    {
        speed = otherspeed;
    }
}
