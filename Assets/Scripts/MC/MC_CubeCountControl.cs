using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_CubeCountControl : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> cubeList = new List<GameObject>();
    [SerializeField] private MC_Controls MC_Controls;
    [SerializeField] public StageComplete stageComplete;

    private GameObject lastCube;
    private GameObject character;
    void Start()
    {
        MC_Controls = GameObject.FindObjectOfType<MC_Controls>();
 
        UpdateLastCube();
    }

    public void NewCube(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastCube.transform.position.x, lastCube.transform.position.y - 0.1f, lastCube.transform.position.z);
        _gameObject.transform.SetParent(transform);
        cubeList.Add(_gameObject);
        UpdateLastCube();
    }

    public void YeetCube(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        cubeList.Remove(_gameObject);
        UpdateLastCube();
    }

    public void StopTheCharacter(GameObject _gameObject)
    {
        MC_Controls.fwdMovementSpeed = 0;
        MC_Controls.horizontalMovementSpeed = 0;
        _gameObject.transform.parent = null;
        
    }

    public void CompelteStage()
    {
        MC_Controls.fwdMovementSpeed = 0;
        MC_Controls.horizontalMovementSpeed = 0;
        stageComplete.Activate();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void UpdateLastCube ()
    {
        lastCube = cubeList[cubeList.Count - 1];
    }
}
