using UnityEngine;

[RequireComponent(typeof(HeroMovement))]
// [RequireComponent(typeof(StatsManager))]
public class HeroController : MonoBehaviour
{
    private HeroMovement heroMovement;
    private StatsManager Status = new StatsManager();
    private Leveling lvl = new Leveling();
    // Start is called before the first frame update
    void Start()
    {
        heroMovement = GetComponent<HeroMovement>();
        EventManager.Enemy1Died += OnEnemyDied;
        // Status.Health = 1000;
    }

    void FixedUpdate()
    {
        heroMovement.MoveSetup(Status.MoveSpeed);
        // Status.TakeDamage(5);
        // Debug.Log(Status.Health);
    }

    void OnEnemyDied()
    {
        lvl.Level++;
        Debug.Log(lvl.Level);
    }
}
