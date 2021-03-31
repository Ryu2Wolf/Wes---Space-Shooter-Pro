using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public or private reference
    //data type (int, float, bool, string)
    //every variable has a name
    //optional value assigned
    [SerializeField]
    private float _speed = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        //take the current position = new position (0, 0, 0)
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float horiztonalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //new Vector3(1, 0, 0) *  * 3.5f * real time
        //transform.Translate(Vector3.right * horiztonalInput * _speed * Time.deltaTime);
        //transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);

        Vector3 direction = new Vector3(horiztonalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);    
    }
}