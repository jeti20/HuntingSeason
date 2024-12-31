using UnityEngine;
using UnityEngine.AI;
using StarterAssets;

public class EnemyMovement : MonoBehaviour
{
    FirstPersonController player;
    //[SerializeField] Transform target;

    NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        player = FindAnyObjectByType<FirstPersonController>();       
    }

    private void Update()
    {
        navMeshAgent.SetDestination(player.transform.position);
    }
}
