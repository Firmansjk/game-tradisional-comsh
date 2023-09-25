using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaragaButtonController : MonoBehaviour
{
    public MaragaBallScript maragaBall; // Reference to your MaragaBallScript
    public int targetPointIndex; // Set this in the inspector for each button (0, 1, 2, 3 for the four points).
    public MaragaScore maragaScore;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        if (maragaBall.IsMoving)
        {
            // Game over condition: Player pressed the button while the object was moving
            //Debug.Log("Game Over");
            // Increment the score based on the button pressed
            if (targetPointIndex == 1 || targetPointIndex == 4)
            {
                // Button 1 or 4: Increment P2's score
                maragaScore.IncrementPlayer2Score();
            }
            else if (targetPointIndex == 2 || targetPointIndex == 3)
            {
                // Button 2 or 3: Increment P1's score
                maragaScore.IncrementPlayer1Score();
            }
        }
        else
        {
            if (targetPointIndex == maragaBall.CurrentPointIndex)
            {
                // Only allow the ball to move if the button corresponds to the current point
                maragaBall.MoveToTargetPoint(targetPointIndex);
            }
            else
            {
                // Button press does nothing if the ball is not at the corresponding point
                Debug.Log("Ball is not at the corresponding point.");
            }
        }
    }
}
