using UnityEngine;  

public class DeathScript : MonoBehaviour
{

    public DeathGenerator deathGen;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * deathGen.currSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision) 
    {
      if (collision.gameObject.CompareTag("nextLine")) 
      {
        deathGen.GenerateDeathGap();
      } 

      // Checks if Death Object is at EndLine (removes item to stop lag)
      if (collision.gameObject.CompareTag("Finish")) 
      {
        Destroy(this.gameObject);
      }  
    }
}
