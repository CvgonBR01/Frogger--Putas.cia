using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerFrogger : MonoBehaviour
{
    [SerializeField]
    private float speed;
    float Horizontal;
    float Vertical;
    Animator anim;
    SpriteRenderer render;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
        if (Horizontal != 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, Horizontal * -90f);

        }
        else  if (Horizontal != 0)

        {
                gameObject.transform.eulerAngles = new Vector3(0, 0, Horizontal * 90f);
            
        }
        if (Vertical != 0)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else if (Vertical != 0)

        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, Vertical * 180f);

        }

        if (Horizontal !=0 || Vertical!=0)
        {
            anim.SetBool("pulo", true);
            gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else
        {
            anim.SetBool("pulo", false);
        }
    }
        

    
}

