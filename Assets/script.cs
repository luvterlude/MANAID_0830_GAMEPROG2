using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum Emovement
{
    Forward,
    Backward,
    Left,
    Right
}
public class script : MonoBehaviour
{
    public float moveSpeed;
    public Emovement movementType;
    public Transform pointA, pointB;
    // Start is called before the first frame update
    void Start()
    {
       // transform.position = Vector3.left;
    }

    // Update is called once per frame
    void Update()
   {
        //    switch (movementType)
        //    {
        //        case Emovement.Forward:
        //            break;
        //        case Emovement.Backward:
        //            break; 
        //        case Emovement.Left:
        //            break;
        //        case Emovement.Right:
        //            break;
        //    }
        // transform.position = Vector3.Lerp(transform.position, pointB.position, moveSpeed
        //    * Time.deltaTime).normalized;


        float dist = Vector3.Distance(transform.position, pointB.position);
        //Debug.Log(dist);

    }

    public void MoveForward()
    {
        transform.position = Vector3.forward * moveSpeed * Time.time;
    }

    public void MoveLeft()
    {
        transform.position = Vector3.left * moveSpeed * Time.time;
    }

    public void MoveRight()
    {
        transform.position = Vector3.right * moveSpeed * Time.time;
    }

    public void MoveBackward()
    {
        transform.position = Vector3.back * moveSpeed * Time.time;
    }
}
