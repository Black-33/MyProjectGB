using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class MouseLooks : MonoBehaviour
    {
        public float sensMouse = 500f; // ???????????????? ????
        public Transform playerBody;
        float xRotation = 0f;

        void Start()
        {
            //????????? ?????? ??? ??????
            Cursor.lockState = CursorLockMode.Locked;
        }
        void Update()
        {
            float mouseX = Input.GetAxis("Mouse X") * sensMouse * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensMouse * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}

