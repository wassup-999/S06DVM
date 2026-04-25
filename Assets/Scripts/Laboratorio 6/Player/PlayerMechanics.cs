using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMechanics : MonoBehaviour ,ITakeDamage
{
    public int Life = 100;


    void Start()
    {
        
    }

    
    void Update()
    {
        OnDestroy();
    }
    public void TakeDamage(int damage)
    {
        damage = 10;
        Life -= damage;
        Debug.Log("Player hit");       
    }
    public void OnDestroy()
    {
        if (Life <= 0)
        {
            Debug.Log("Player is dead");          
            Destroy(gameObject);
            GameManager.Instance.UI.ReloadLevel();
        }
    }
    
}
