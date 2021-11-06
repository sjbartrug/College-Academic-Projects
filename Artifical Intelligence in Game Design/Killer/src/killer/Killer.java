package killer;
import java.util.*;

/**
 * Killer Finite State Machine
 * @author sjbartrug
 */
public class Killer 
{
    
    /**
     * This is to track whether the killer is calm or if it has become angry.
     * Emotion = 0 means the killer is calm.
     * Emotion > 0 means the killer is angry.
     * While angry the killer will move faster towards the player.
     */
    private static int emotion = 0;
    
    //This is to track the killers movement speed as it changes with their emotion and other effects like being blinded.
    private static int walkSpeed;

    public static abstract class State
    {
        protected Scanner input = new Scanner(System.in);
        protected Random random = new Random();
        public State() {}
        public abstract void enter();
        public abstract void exit();
        public abstract int updateAndCheckTransitions();
    }
   
    //This class represents the state in which The Killer is wandering their path.
    public static class Wandering extends State 
    {
        public Wandering() 
        {
            super();
        }
        public void enter() 
        {
            //The Killer has entered the wandering state. If they are angry their movement is set to 30 feet per turn but if not it is set to 10.
            if(emotion > 0)
            {
                walkSpeed = 30;
            }
            else
            {
                walkSpeed = 10;
            }
            System.out.println("The Killer is wandering");
        }
        public void exit() 
        {
            //The Killer has switched to another state.
            System.out.println("The Killer stops wandering");
        }
        public int updateAndCheckTransitions() 
        {
            //System checks if The Killer has spotted the player.
            System.out.print("Has The Killer spotted the player? (y or n) ");
            char response = input.next().charAt(0);
            System.out.println("");
            if(response == 'n')
            {
                //Since The Killer has not spotted the player, the system checks if instead the killer heard a noise.
                System.out.print("Did The Killer hear something? (y or n) ");
                response = input.next().charAt(0);
                System.out.println("");
                if(response == 'n')
                {
                    //Since The Killer has not spotted the player, or heard a noise, it will continue to wander and its anger will start to subside.
                    System.out.println("The Killer continues to wander.");
                    emotion -= 2;
                    //The Killer has calmed down
                    if(emotion < 0)
                    {
                        System.out.println("The Killer has calmed down and is no longer angry");
                        emotion = 0;
                    }
                    //Switches to the wandering state
                    return 0;
                }
                //Since The Killer has heard a noise, The Killer will go to investigate.
                System.out.println("The Killer goes to investigate.");
                //Switches to the investigating state
                return 2;
            }
            //Since The Killer spotted the player, they will begin to chase them.
            //Switches to the chasing state.
            else return 3;
        }
    }
    
    //This class represents the state in which The Killer searching for the player after losing sight of them.
    public static class Searching extends State 
    {
        private int count = 0; //How many turns has The Killer been searching for the player(for timeout).
        public Searching() 
        {
            super();
        }
        public void enter() 
        {
            //The Killer has entered the searching state. If they are angry their movement is set to 30 feet per turn but if not it is set to 10.
            if(emotion > 0)
            {
                walkSpeed = 30;
            }
            else
            {
                walkSpeed = 10;
            }
            System.out.println("The Killer is checking the local area for the player.");
        }
        public void exit() 
        {            
            //The Killer has switched to another state.
            System.out.println("The Killer has stopped searching for the player.");
        }
        public int updateAndCheckTransitions()
        {        
            //System checks if The Killer has spotted the player.
            System.out.print("Has The Killer found the player again? (y or n) ");
            int response = input.next().charAt(0);
            System.out.println("");
            if(response == 'n')
            {
                
                //To make sure The Killer takes their time searching, don't stop searching until at least 3 but not more than 10 rounds have passed.
                while(count <= (random.nextInt(7) + 4))
                {
                    //The Killer will continue to search the randomized amount of times.
                    System.out.print("The Killer continues to search, has the player been found? (y or n) ");
                    response = input.next().charAt(0);
                    System.out.println("");
                    count++;
                    //The Killer finds the player in the randomized amount of searching times.
                    if(response == 'y')
                    {
                        //Switches to the chasing state.
                        return 3;
                    }
                }
                //As The Killer finishes searching, since nothing was found, they will get angry, or angier, at being evaded and begin wandering again.
                if(emotion > 0)
                {
                    System.out.println("The Killer becomes even angrier as they were evaded");
                }
                else
                {
                    System.out.println("The Killer begins to get angry as they were evaded");
                }
                emotion += (random.nextInt(6));
                //Switches to the wandering state.
                return 0;
            }
            //Switches to the chasing state.
            return 3;                    
        }
    }    
    
    //This class represents the state in which The Killer is investigating a noise or something they saw.
    public static class Investigating extends State 
    {
	private int count = 0; //How many turns has The Killer been searching (for timeout).
        public Investigating()
        {
            super();
        }
        
        public void enter()
        {
            //The Killer has entered the investigating state. If they are angry their movement is set to 30 feet per turn but if not it is set to 10.
            if(emotion > 0)
            {
                walkSpeed = 30;
            }
            else
            {
                walkSpeed = 10;
            }
            System.out.println("The Killer is investigating.");
        }
        public void exit() 
        {            
            //The Killer has switched to another state.
            System.out.println("The Killer is no longer investigating.");
        }
        public int updateAndCheckTransitions()
        {   
            //System checks if The Killer has spotted the player.
            System.out.print("The Killer searches the area of the noise, was the player found? (y or n) ");
            int response = input.next().charAt(0);
            System.out.println("");
            if(response == 'n')
            {
                //To make sure The Killer takes their time searching, don't stop searching until at least 3 but not more than 10 rounds have passed.
                while(count <= (random.nextInt(8) + 3))
                {
                    System.out.print("The Killer continues to search, has the player been found? (y or n) ");
                    response = input.next().charAt(0);
                    System.out.println("");
                    count++;
                    //The Killer finds the player in the randomized amount of searching times.
                    if(response == 'y')
                    {
                        //Killer finds player and begins chasing.
                        //Switches to the chasing state.
                        return 3;
                    }
                }
                //Killer did not find anything.
                //Switches to the wandering state.
                return 0;
                
            }
            //Killer found the player and began chasing.
            //Switches to the chasing state.
            else return 3;
            
        }
    }
    
    //This class represents the state in which The Killer is chasing the player.
    public static class Chasing extends State 
    {
        public Chasing()
        {
            super();
        }
        
        public void enter()
        {
            //The Killer has entered the chasing state. If they are angry their movement is set to 35 feet per turn but if not it is set to 15.
            if(emotion > 0)
            {
                walkSpeed = 35;
            }
            else
            {
                walkSpeed = 15;
            }
            System.out.println("The Killer is chasing the player!");
        }
        public void exit()
        {
            //The Killer has switched to another state.
            System.out.println("The Killer is no longer chasing the player.");
        }
        public int updateAndCheckTransitions()
        { 
            //System checks if The Killer has spotted the player.
            System.out.print("Has The Killer caught the player? (y or n) ");
            int response = input.next().charAt(0);
            System.out.println("");
            if(response == 'n')
            {
                //System checks if The Killer still can see the player to continue the pursuit.
                System.out.print("Does The Killer still have sight of the player? (y or n) ");
                response = input.next().charAt(0);
                System.out.println("");
                if(response == 'n')
                {
                    //System checks if The Killers lack of vision of the player was a result of being blinded.
                    System.out.print("Was The Killer blinded? (y or n) ");
                    response = input.next().charAt(0);
                    System.out.println("");
                    if(response == 'n')
                    {
                        //The Killer was not blinded so immediatly begins searching for the player.
                        System.out.println("The Killer has lost sight of the player.");
                        //Switches to the seaching state
                        return 1;
                    }
                    //Killer was in fact blinded by the player.
                    //Switches to the blinded state.
                    else return 4;
                }
                //The Killer still has sight of the player and continues chasing.
                //Switches to the chasing state.
                else return 3;
            }
            //The Killer has caught and killed the player, thus ending the game.
            System.out.println("The Killer has caught the player and the game is over");
            System.exit(0);
            //System has an error without a return statement despite the game being over with a system.exit(0).
            return 0;
        }
    }
    
    //This class represents the state in which The Killer has been blinded.   
    public static class Blinded extends State 
    {
        public Blinded()
        {
            super();
        }
        public void enter()
        {
            //The Killer has entered the blinded state and therefore their walk speed is 0.
            walkSpeed = 0;
            System.out.println("The Killer has been blinded");
            
            //By being blinded by the player The Killer is now angry or angrier than before.
            if(emotion > 0)
            {
                System.out.println("The Killer becomes even angrier as they are blinded");
            }
            else
            {
                System.out.println("The Killer begins to get angry as they are blinded");
            }
            emotion += (random.nextInt(7)+ 6);
        }
        public void exit()
        {         
            //The Killer has switched to another state.
            System.out.println("The Killer in no longer blinded");
        }
        public int updateAndCheckTransitions()
        {  
            //System checks if The Killer still can see the player to continue the pursuit
            System.out.print("Is the player still in line of sight of The Killer? (y or n) ");
            int response = input.next().charAt(0);
            System.out.println("");
            if(response == 'n')
            {
               //If the player is not still seen The Killer begins searching for them.
               //Switches to the seaching state.
               return 1; 
            }
            else 
            {
                //If the player is still within sight after the blinding, The Killer begins chasing them.
                //Switches to the chasing state.
                return 3;            
            }                      
        }
    }

    //Main driver for FSM.
    public static void main(String[] args)
    {
        int numberOfStates = 5;
        State[] states = new State[numberOfStates];

        states[0] = new Wandering();
        states[1] = new Searching();
        states[2] = new Investigating();
        states[3] = new Chasing();
        states[4] = new Blinded();
        
        int currentState = 0;
        int nextState;  

        states[0].enter();
        while(true) 
        {
            nextState = states[currentState].updateAndCheckTransitions();
            if (nextState != currentState)
            {
                states[currentState].exit();
                currentState = nextState;
                states[currentState].enter();
            }
        }
    }
}
