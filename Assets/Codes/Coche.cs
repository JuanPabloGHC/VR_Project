using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public float speed;
    //public Transform inicio;
    //public Transform final;
    private int posicionNum;
    private GameObject _target;

    //Awake
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        posicionNum = 1;
        UpdateTarget();
        //StartCoroutine("ToTarget");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, _target.transform.position) <= 0.005f)
        {
            UpdateTarget();
        }
    }

    private void UpdateTarget()
    {
        if (_target == null)
        {
            _target = new GameObject("TargetPlataforma");
            _target.transform.position = new Vector3(transform.position.x, transform.position.y, 9f);
        }
        else if (posicionNum == 1)
        {
            posicionNum = 2;
            _target.transform.position = new Vector3(transform.position.x, transform.position.y, 1f);
        }
        else
        {
            posicionNum = 1;
            _target.transform.position = new Vector3(transform.position.x, transform.position.y, 9f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "XR Origin" )
        {
            other.gameObject.transform.SetParent(this.transform);
        }
        else
        {
            other.gameObject.transform.SetParent(null);

        }
    }
}
