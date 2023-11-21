using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] GameObject character;

    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3
        (
                character.transform.position.x,
                character.transform.position.y,
                transform.position.z
        );

        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.fixedDeltaTime);
    }
}
