using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float minSize;
    [SerializeField] private float maxSize;
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    private Rigidbody2D obstacleRig; 
    private void Awake() {
        obstacleRig = GetComponent<Rigidbody2D>();

        float randomSize =Random.Range(minSize, maxSize);
        transform.localScale=new Vector3(randomSize,randomSize,1);

        float xSpeed= Random.Range(minSpeed,maxSpeed);
        float ySpeed= Random.Range(minSpeed,maxSpeed);
        obstacleRig.AddForce(new Vector2(xSpeed,ySpeed).normalized);

    }
}
