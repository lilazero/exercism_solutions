using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)=> knightIsAwake != true;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) =>knightIsAwake==true||archerIsAwake==true||prisonerIsAwake==true;
    
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => archerIsAwake == false && prisonerIsAwake == true;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {

        if(knightIsAwake==true&&archerIsAwake==false&petDogIsPresent==true ){
            return true;
        }
        else 
        if(knightIsAwake==false&&archerIsAwake==false&&prisonerIsAwake==true| petDogIsPresent==true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
