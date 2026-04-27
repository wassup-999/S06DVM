using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMechanics : MonoBehaviour ,ITakeDamage
{
    public float Life = 100;
    public float MaxLife = 100;

    void Start()
    {
        
    }

    
    void Update()
    {
        OnDestroy();
    }
    public void TakeDamage(float damage)
    {
        damage = GameManager.Instance.Enemy.AttackDamage;
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
