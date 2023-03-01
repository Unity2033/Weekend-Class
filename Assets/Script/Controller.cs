using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private float mouseX;
    [SerializeField] float speed = 2.5f;
    [SerializeField] float mouseSpeed = 1.0f;
    private CharacterController characterController;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;                     
        Cursor.lockState = CursorLockMode.Locked;   
        
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, 0, z);

        direction.y -= 20.0f * Time.deltaTime;

        characterController.Move(transform.TransformDirection(direction) * speed * Time.deltaTime);

        mouseX += Input.GetAxisRaw("Mouse X") * mouseSpeed;

        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }
}
