using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CubeSurfer.RotateController
{
    public class RotateController : MonoBehaviour
    {
        [SerializeField] private float _cubeForwardSpeed;
        [SerializeField] private float _cubeRightLeftSpeed;

        [SerializeField] private GameManager _gameManager;

        void Update()
        {
            if (_gameManager._gameState != GameManager.GameState.Failed && _gameManager._gameState != GameManager.GameState.Finish)
            {
                float _yatayEksen = Input.GetAxis("Horizontal") * _cubeRightLeftSpeed * Time.deltaTime;
                this.transform.Translate(_yatayEksen, 0, _cubeForwardSpeed * Time.deltaTime);
            }
        }
    }

}
