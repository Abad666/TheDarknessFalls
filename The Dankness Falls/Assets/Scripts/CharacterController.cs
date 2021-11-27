using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            player.transform.Translate(Vector3.up);
        }
        if (Input.GetKeyDown("s"))
        {
            player.transform.Translate(Vector3.down);
        }
        if (Input.GetKeyDown("a"))
        {
            player.transform.Translate(Vector3.left);
        }
        if (Input.GetKeyDown("d"))
        {
            player.transform.Translate(Vector3.right);
        }
    }
}
