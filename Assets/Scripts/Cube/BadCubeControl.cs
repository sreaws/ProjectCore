using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private MC_CubeCountControl MC_CubeCountControl;

    private bool isStack = false;
    private Vector3 directionBack = Vector3.back;
    private Vector3 directionRight = Vector3.right;
    private Vector3 directionLeft = Vector3.left;

    private RaycastHit raycastHit;
    void Start()
    {
        MC_CubeCountControl = GameObject.FindObjectOfType<MC_CubeCountControl>();
    }

    // Update is called once per frame
    void Update()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {
        if ((Physics.Raycast(transform.position, directionBack, out raycastHit, 0.07f)) ||
            (Physics.Raycast(transform.position, directionRight, out raycastHit, 0.07f)) ||
            (Physics.Raycast(transform.position, directionLeft, out raycastHit, 0.07f)))
        {
            if (!isStack)
            {
                isStack = true;
                MC_CubeCountControl.NewCube(gameObject);
            }
        }

    }
}
