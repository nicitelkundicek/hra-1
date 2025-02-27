using Unity.Mathematics;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public Transform despawner;
    public float delay;
    public float range = 3f;
    float curTime = 0f;
    public GameObject barrier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curTime +=Time.deltaTime;
        if(curTime >= delay){
            spawn();
            curTime = 0;
        }
    }
    void spawn(){
        float randomPosX = UnityEngine.Random.Range(-range, range);
        Vector3 spawnPos = new Vector3(randomPosX,this.transform.position.y, this.transform.position.z);
        Instantiate(barrier, spawnPos, quaternion.identity);
        BarrierScript script = barrier.GetComponent<BarrierScript>();
        script.despawn = despawner;
        script.spawn = this.transform;
    }
}
