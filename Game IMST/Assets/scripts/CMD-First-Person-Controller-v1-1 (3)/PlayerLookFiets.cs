using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookFiets : MonoBehaviour
{
    public float lookSpeed = 3.0f;
    private Vector2 rotation = Vector2.zero;

    void Start()
    {
      Cursor.visible = false;
    }
    void Update()
    {
      Cursor.lockState = CursorLockMode.Locked;
      rotation.y += Input.GetAxis("Mouse X");
      rotation.x += -Input.GetAxis("Mouse Y");
      rotation.x = Mathf.Clamp(rotation.x, -30f, 10f);
      transform.eulerAngles = new Vector2(0,rotation.y) * lookSpeed;
      Camera.main.transform.localRotation = Quaternion.Euler(rotation.x * lookSpeed, 0, 0);
    }
}

