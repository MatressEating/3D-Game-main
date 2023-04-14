
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public float HP = 50;

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask defGround, defPlayer;

    //roaming variables 
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //chasing vars
    public float attacktime;
    bool alreadyAttacked;

    //enemy detection range
    public float sightRange, aggroRange;
    //detection states
    public bool playerInSight, playerAggro;

    //references player object | i dunno what agent does
    private void Awake()
    {
        player = GameObject.Find("Character").transform;
        agent = GetComponent<NavMeshAgent>();
        
    }

    //activates states depending on where player is
    private void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, defPlayer);
        playerAggro = Physics.CheckSphere(transform.position, aggroRange, defPlayer);

        if (!playerInSight && !playerAggro) Roaming();
        if (playerInSight && !playerAggro) AggroPlayer();
        if (playerInSight && playerAggro) AttackPlayer();
    }

    //roaming: enemy moves to random positions when player isnt in range
    private void Roaming()
    {
        if (!walkPointSet)
        {
            SearchWalkPoint();
            Debug.Log("found walkpoint");
        }

        if (walkPointSet)
        {
            agent.SetDestination(walkPoint);
            Debug.Log("going to walkpoint");
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
            Debug.Log("reached walkpoint");
        }
    }

    //finds a random spot to walk to
    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, defGround))
            walkPointSet = true;
    }

    //aggro: follows player when in range
    private void AggroPlayer()
    {
        agent.SetDestination(player.position);

    }

    //attack code i guess
    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        { 
        //attack code! ! !
        }

    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

}
