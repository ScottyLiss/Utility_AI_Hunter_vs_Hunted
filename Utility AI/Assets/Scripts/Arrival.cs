using UnityEngine;

public class Arrival : SteeringBehaviour
{
    /// <summary>
    /// Controls how far from the target position should the agent start to slow down
    /// </summary>
    [SerializeField]
	protected float arrivalRadius = 200.0f;

	public override Vector3 UpdateBehaviour(SteeringAgent steeringAgent)
	{
		// Get the target position from the mouse input
		Vector3 targetPosition = SteeringAgent.GetMousePosition();

		// Get the desired velocity for seek and limit to maxSpeed
		desiredVelocity = targetPosition - transform.position;
		float distance = (targetPosition - transform.position).magnitude;
		desiredVelocity.Normalize();
		if(distance < arrivalRadius)
		{
			desiredVelocity *= steeringAgent.MaxSpeed * (distance / arrivalRadius);
		}
		else
		{
			desiredVelocity *= steeringAgent.MaxSpeed;
		}

		// Calculate steering velocity
		steeringVelocity = desiredVelocity - steeringAgent.CurrentVelocity;
		return steeringVelocity;
	}
}
