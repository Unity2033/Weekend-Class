using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    void Start()
    {
        Camera camera = GetComponent<Camera>();

        Rect rect = camera.rect;
                                                          
        float height = ((float)Screen.width / Screen.height) / (9/18.5f);
        float width = 1f / height;

        if(height < 1)
        {
            rect.height = height;
            rect.y = (1f - height) / 2f;
        }
        else
        {
            rect.width = width;
            rect.x = (1f - width) / 2f;
        }

        camera.rect = rect;
    }

    private void OnPreCull()
    {
        GL.Clear(true, true, Color.black);
    }
}
