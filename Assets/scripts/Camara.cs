using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] GameObject thingtofollow;
    void LateUpdate()
    {
        transform.position = thingtofollow.transform.position + new Vector3(0,0,-10);

    }
}
