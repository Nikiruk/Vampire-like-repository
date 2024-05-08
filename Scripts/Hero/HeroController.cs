using UnityEngine;

[RequireComponent(typeof(HeroMovement))]
// [RequireComponent(typeof(StatsManager))]
public class HeroController : MonoBehaviour
{
    private HeroMovement heroMovement;
    private StatsManager Status = new StatsManager();
    // Start is called before the first frame update
    void Start()
    {
        heroMovement = GetComponent<HeroMovement>();
    }

    void FixedUpdate()
    {
        heroMovement.MoveSetup(Status.MoveSpeed);
    }
}
