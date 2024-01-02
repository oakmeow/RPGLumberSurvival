using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;  // ระยะห่าง
    public float smoothSpeed = 2f;
    public float currentZoom = 1f;
    public float maxZoom = 3f;
    public float minZoom = 0.3f;
    public float yawSpeed = 70f;    // ความเร็วหมุนกล้อง
    public float zoomSensitive = 0.7f;
    float dst;  // ระยะห่างของผู้เล่นกับกล้อง
    float zoomSmooth;
    float targetZoom;

    void Start()
    {
        dst = offset.magnitude;
        transform.LookAt(target);
        targetZoom = currentZoom;
    }

    // Update is called once per frame
    void Update()
    {
        // Zoom Camera
        float scroll = Input.GetAxisRaw("Mouse ScrollWheel") * zoomSensitive;
        if (scroll != 0f)
        {
            targetZoom = Mathf.Clamp(targetZoom - scroll, minZoom, maxZoom);
        }
        currentZoom = Mathf.SmoothDamp(currentZoom, targetZoom, ref zoomSmooth, 0.15f);
    }

    private void LateUpdate()
    {
        // Zoom Camera
        transform.position = target.position - transform.forward * dst * currentZoom;
        transform.LookAt(target.position);

        // Pan Camera
        float yawInput = Input.GetAxisRaw("Horizontal");
        transform.RotateAround(target.position, Vector3.up, -yawInput * yawSpeed * Time.deltaTime);
    }
}
