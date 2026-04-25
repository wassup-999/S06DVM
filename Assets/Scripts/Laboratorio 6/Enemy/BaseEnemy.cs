using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AI;

public class BaseEnemy : MonoBehaviour
{
    [FoldoutGroup("References")]
    public PlayerMechanics Player;
    [FoldoutGroup("References")]
    public NavMeshAgent agent;

    [FoldoutGroup("Attack Settings")]
    public float AttackRange;
    void Start()
    {       
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMechanics>();           
        agent = GetComponent<NavMeshAgent>();         
    }

    
    void Update()
    {
        FollowTarget();
        MakeDamage();
    }
    public void FollowTarget()
    {       
        if (!agent.hasPath)
        {
            Debug.Log("No path to follow");
        }
        if(Player != null)
        {
            agent.SetDestination(Player.transform.position);
        }      
    }
    public void OnDrawGizmos()
    {
        if(Player == null) return;
        Gizmos.color = Color.black;
        if (agent.path == null) return;
        Vector3[] corners = agent.path.corners;
        for(int i = 0; i < corners.Length - 1; i++)
        {
            Gizmos.DrawLine(corners[i], corners[i + 1]);
            Gizmos.DrawSphere(corners[i], 0.2f);
        }
    }
    
    public void MakeDamage()
    {
        if(Player == null) return;
        if (Vector3.Distance(Player.transform.position, transform.position) <= agent.stoppingDistance)
        {
            Player.TakeDamage(10);
            GameManager.Instance.enemySpawner.CurrentEnemies--;
            Destroy(gameObject);
        }     
    }
    
}

