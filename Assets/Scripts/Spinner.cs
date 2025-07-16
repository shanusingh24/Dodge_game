using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] int xaxis = 0;
    [SerializeField]int yaxis = 0;
    [SerializeField]int zaxis = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xaxis*Time.deltaTime,yaxis*Time.deltaTime,zaxis*Time.deltaTime);
    }
}
