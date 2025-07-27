using UnityEngine;

public class Car : MonoBehaviour
{
    
    [SerializeField]float steerspeed = 0.75f;
    [SerializeField]float movespeed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal")*steerspeed;
        float moveamount = Input.GetAxis("Vertical")*movespeed;
        transform.Rotate(0, 0, -steeramount);
        transform.Translate(0, moveamount, 0);
    }
}
