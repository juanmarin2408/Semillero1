using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public InputWrapper inputs;
    public Rigidbody RB;
    public Vector3 Direccion;
    public float speed;
    
    void Start()
    {
        inputs = GetComponent<InputWrapper>();
        RB = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(inputs.GetMovement());
        Direccion.x = inputs.GetMovement();
        Direccion = Direccion.normalized * speed * Time.deltaTime;
        transform.position += Direccion;   
    }
}
