using UnityEngine;
using static Platformer.Core.Simulation;

//This code originates from the Platformer Microgame made for Unity Learn,
//and it was edited to accompany what my platformer contains, since this
//script offers just about everything I need.

namespace Platformer.Scripts
{
    /// <summary>
    /// Marks a trigger as a VictoryZone, usually used to end the current game level.
    /// </summary>
    public class GoalGem : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                var ev = Schedule<PlayerEnteredVictoryZone>();
                ev.victoryZone = this;
            }
        }
    }
}