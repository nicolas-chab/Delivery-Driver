using UnityEngine;
using UnityEngine.Rendering;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 haspackagecolor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 doesnthaspackagecolor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;
    [SerializeField] float destroytime = 0.2f;
    bool haspackage=false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ouch");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !haspackage)
        {
            Debug.Log("package picked up");
            Destroy(other.gameObject,destroytime);
            spriteRenderer.color = haspackagecolor;
            haspackage = true;
        }
        if (other.tag == "Customer" && haspackage)
        {
            Debug.Log("package delivered");
            spriteRenderer.color = doesnthaspackagecolor;
            haspackage = false;
       }
    }
}
