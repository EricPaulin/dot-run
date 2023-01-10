using UnityEngine;

public class DeathGenerator : MonoBehaviour
{

    public GameObject death;

    public float minSpeed;
    public float maxSpeed;
    public float currSpeed;

    public float speedMultiplier;

    // Start is called before the first frame update
    void Awake()
    {
        currSpeed = minSpeed;
        generateDeath();
    }


    public void GenerateDeathGap()
    {
        float gap =  Random.Range(0.1f, 2.5f);
        Invoke("generateDeath", gap); 
    }


    public void generateDeath()
    {
        GameObject DeathIns = Instantiate(death, transform.position, transform.rotation);

        DeathIns.GetComponent<DeathScript>().deathGen = this;
    }

    // Update is called once per frame
    void Update()
    {
        // Have Game Get Faster Over Time
        if(currSpeed < maxSpeed) 
        {
            currSpeed += speedMultiplier;
        }
    }
}
