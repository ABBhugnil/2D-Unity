using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 toPos = new Vector3(player.position.x, player.position.y, -10);
        transform.position = Vector3.Lerp(transform.position, toPos, .2f);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 0, 200), Mathf.Clamp(transform.position.y, 0, 200), transform.position.z);
    }
}
