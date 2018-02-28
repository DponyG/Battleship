using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulateMovement : MonoBehaviour {

    public float _distance;
    // Variables for floating
    private Vector3 _top, _bottom;
    private float _percent = 0.0f;
    private float _speed = 0.1f;
    private Direction _direction;

    // Define direction up and down
    enum Direction { UP, DOWN };

    void Start() {
        _direction = Direction.UP;
        _top = new Vector3(transform.position.x,
                           transform.position.y + _distance,
                           transform.position.z);
        _bottom = new Vector3(transform.position.x,
                              transform.position.y - _distance,
                              transform.position.z);
    }

    void Update() {
        ApplyFloatingEffect();
    }

    // Apply the floating effect between the given positions
    void ApplyFloatingEffect() {
        if (_direction == Direction.UP && _percent < 1) {
            _percent += Time.deltaTime * _speed;
            transform.position = Vector3.Lerp(_top, _bottom, _percent);
        } else if (_direction == Direction.DOWN && _percent < 1) {
            _percent += Time.deltaTime * _speed;
            transform.position = Vector3.Lerp(_bottom, _top, _percent);
        }
        if (_percent >= 1) {
            _percent = 0.0f;
            if (_direction == Direction.UP) {
                _direction = Direction.DOWN;
            } else {
                _direction = Direction.UP;
            }
        }
    }
}










