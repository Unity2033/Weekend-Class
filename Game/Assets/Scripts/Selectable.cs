using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Selectable : MonoBehaviour
{
    private Rigidbody rigidBody;
    [SerializeField] bool select;
    [SerializeField] ParticleSystem particle;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        select = true;
        particle.Play();
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3
        (
              Input.mousePosition.x,
              Input.mousePosition.y,
              Camera.main.WorldToScreenPoint(gameObject.transform.position).z
        );

        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private void OnMouseExit()
    {
        select = false;
    }

    private void OnTriggerEnter(Collider other)
    {
       string selectObject = transform.name;
       string collisionObject = other.transform.name;

        if(selectObject == collisionObject)
        {
            int add = int.Parse(selectObject.Substring(selectObject.Length - 1)) + int.Parse(collisionObject.Substring(collisionObject.Length - 1));

            if (select == true)
            {
                Instantiate(Resources.Load<GameObject>("Container " + add));
            }
  
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
