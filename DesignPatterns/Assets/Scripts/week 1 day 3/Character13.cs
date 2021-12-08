using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CharacterStates
{
    Standing,
    Walking,
    Running,
    Jumping,
    Crouch,
    Attack
}
public class Character13 : MonoBehaviour
{
    /*
     Implement a character class with states forming a DFA. Where nodes are character states like standing, walking, jumping, crouch, attack, etc and events are keyboard inputs, animation endings, etc.

        - Model the state graph on paper (optionally, try graphviz online or any other graph editor with autolayout).
        - Implement DFA as nested switch-cases.
        - Implement DFA as LUT.

        In pairs or groups, discuss each others state machines, try to see if they are robust, would they break if some events like keyboards input come at unexpected times? (trying to jump while in crouch, etc).
*/

    private CharacterStates PlayerState = CharacterStates.Standing;
    
    void CharacterState(CharacterStates stateToBe)
    {
        switch (stateToBe)
        {
            case CharacterStates.Standing:
                PlayerState = CharacterStates.Standing;
                break;
            
            case CharacterStates.Walking:
                PlayerState = CharacterStates.Standing;
                break;

            case CharacterStates.Running:
                if (PlayerState != CharacterStates.Crouch)
                {
                    PlayerState = CharacterStates.Running;
                }
                break;
            
            case CharacterStates.Crouch:
                PlayerState = CharacterStates.Crouch;
                break;

            case CharacterStates.Jumping:
                PlayerState = CharacterStates.Jumping;
                break;
            
            case CharacterStates.Attack:
                PlayerState = CharacterStates.Attack;
                
                break;
            default:
                break;
                
        }
    }
    
    
}
