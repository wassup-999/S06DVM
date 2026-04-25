using UnityEngine;

public class PlayerMechanics : MonoBehaviour ,ITakeDamage
{
    public int Life = 100;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        damage = 10;
        Life -= damage;
        Debug.Log("Player hit");       
    }
    
}
