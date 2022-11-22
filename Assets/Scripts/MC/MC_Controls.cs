using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_Controls : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private MC_GetInput MCGetInput;


    [SerializeField] public float fwdMovementSpeed;

    [SerializeField] public float horizontalMovementSpeed;

    [SerializeField] private float horizontalLimitValue;


    float newPosX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetMCFwdMovement();
        SetMCHorizontalMovement();
    }

    private void SetMCFwdMovement()
    {
        transform.Translate(Vector3.forward * fwdMovementSpeed * Time.deltaTime);
    }

    private void SetMCHorizontalMovement()
    {
        newPosX = transform.position.x + MCGetInput.GetHorizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPosX = Mathf.Clamp(newPosX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPosX, transform.position.y, transform.position.z);
    }
}
