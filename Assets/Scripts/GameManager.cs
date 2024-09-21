using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;
    private int _playerScore;
    private int _computerScore;

    private void Start(){
        this._playerScore = 0;
        this._computerScore = 0;
    }

    public void PlayerScores(){
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ComputerScores(){
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ResetGame() {
        _playerScore = _computerScore = 0;
        this.playerScoreText.text = _playerScore.ToString();
        this.computerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.AddStartingForce();
    }
}
