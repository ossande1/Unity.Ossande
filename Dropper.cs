using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
   
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("Lookout below!");
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
