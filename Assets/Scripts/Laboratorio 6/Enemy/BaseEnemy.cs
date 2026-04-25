using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AI;

public class BaseEnemy : MonoBehaviour
{
    [FoldoutGroup("References")]
    public Transform Target;
    [FoldoutGroup("References")]
    public NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Target = GameObject.FindGameObjectWithTag("Player").transform;

        
    }

    
    void Update()
    {
        FollowTarget();
        //MakeDamage();
    }
    public void FollowTarget()
    {
        if (!agent.hasPath)
        {
            Debug.Log("No path to follow");
        }
        if(Target != null)
        {
            agent.SetDestination(Target.position);
        }      
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        if (agent.path == null) return;
        Vector3[] corners = agent.path.corners;
        for(int i = 0; i < corners.Length - 1; i++)
        {
            Gizmos.DrawLine(corners[i], corners[i + 1]);
            Gizmos.DrawSphere(corners[i], 0.2f);
        }
    }
    /*
    public void MakeDamage()
    {
        if(Vector3.Distance(Target.transform.position, transform.position) < agent.stoppingDistance)
        {
            //GameManager.Instance.Player.TakeDamage(10);
            Destroy(gameObject);
        }
    }*/
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.Player.TakeDamage(10);
            Debug.Log("Player hit");
            Destroy(gameObject);
        }
    }
}

