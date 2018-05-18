using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

    public float speed = 8;
    public Transform target;
    public float acceleration;

    void Awake()
    {
        this.enabled = true;
    }


    void Update()
    {
        //float step = speed * Time.deltaTime;
        float step = (speed + acceleration) * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}

}
