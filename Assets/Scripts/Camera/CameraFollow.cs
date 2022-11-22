using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform mcTransform;
    private Vector3 offset;
    private Vector3 newPos;
    [SerializeField] private float lerpValue;
    void Start()
    {
        offset = transform.position - mcTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraFollow();
    }


    private void SetCameraFollow()
    {
        newPos = Vector3.Lerp(transform.position, new Vector3(0f, mcTransform.position.y, mcTransform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPos;
    }
}
