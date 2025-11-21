using UnityEngine;

public class PickUpObj : MonoBehaviour
{
    [SerializeField] private int value;
	private bool hasTriggered;
		
	private PickupManager pickupManager;

	void Start()
	{
		pickupManager = PickupManager.instance;
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.CompareTag("Player")&& !hasTriggered)
		{
			hasTriggered = true;
			//pickupManager.ChangeNumber(1)
			Destroy(gameObject);
		}
	}
}
