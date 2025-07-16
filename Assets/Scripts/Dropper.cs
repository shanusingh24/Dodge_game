using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int TimeToWait = 3;

    MeshRenderer myRenderer;
    Rigidbody myGravity;
    bool hasDropped = false;
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.enabled = false;
        myGravity = GetComponent<Rigidbody>();
        myGravity.useGravity = false;
    }

    void Update()
    {
        if (!hasDropped && Time.time > TimeToWait)
        {
            myGravity.useGravity = true;
            myRenderer.enabled = true;
            hasDropped = true;
        }
    }
}
