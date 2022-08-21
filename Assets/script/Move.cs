using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0,0,0);
    [SerializeField] float speed = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * distance);
            
        } 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * distance);
        } 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * distance);
        } 
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * distance);
        }

        
    } 
}
