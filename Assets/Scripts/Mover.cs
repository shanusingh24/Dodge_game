using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movespeed = 15;
    void Movement()
    {
    float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
    float yvalue = 0f;
    float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
    transform.Translate(xvalue, yvalue, zvalue);
    }
    
    void Start()
    {
        // transform.Translate(1, 0, 0);
        // PrintInstruction();
    }
    
    void Update()
    {
        Movement();
    }
    // void PrintInstruction()
    // {
    //     // Debug.Log("welcome to the game");
    //     // Debug.Log("this game is based on the dodge concept");
    //     // Debug.Log("move player using w,a,s,d");
    // }
}

