using Unity.Mathematics;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float maxRange;
    public int maxHealth;
    float newPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newPos = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        newPos += input * Time.deltaTime * speed;
        newPos = math.clamp(newPos, -maxRange, maxRange);
        this.transform.position = new Vector3(newPos, this.transform.position.y, this.transform.position.z);
    }
}
