using UnityEngine;
 
public class BarrierScript : MonoBehaviour
{
    public float speed;
    float maxDist;
    float distance = 0;
    public Transform spawn;
    public Transform despawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxDist = spawn.position.z - despawn.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        distance += speed*Time.deltaTime;
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, spawn.position.z - distance);
        if(distance >= maxDist){
            Destroy(this.gameObject);
        }
    }
}
