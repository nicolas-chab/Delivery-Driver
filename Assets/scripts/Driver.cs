using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{

    [SerializeField] float steerspeed = 0.75f;
    [SerializeField] float movespeed = 20f;
    [SerializeField] float slowspeed = 15f;
    [SerializeField] float Boostspeed = 35f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Rotate(0, 0, -steeramount);
        transform.Translate(0, moveamount, 0);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boost")
        {
            movespeed = Boostspeed;

            
        }
        if (collision.tag == "Bump")
        {
            movespeed = slowspeed;
        }
    }

}
