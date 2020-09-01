using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroControle : MonoBehaviour
{
    private float x;
    public float speed;
    private Vector3 localPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       x = transform.position.x ;
        x += speed * Time.deltaTime;
        transform.localPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
