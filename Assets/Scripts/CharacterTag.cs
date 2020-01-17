
using UnityEngine;

public class CharacterTag : MonoBehaviour
{
    public float CharacterCode =0f;
    public float Mg = 10000000f;
    public float Mr = 1000000f;
    public float Msr = 100000f;
    public float Mc = 1000f;
    public float Ma = 100f;
    public float characterNumber = 0;

    //-------------------------------(Gender)-----------------------------------

    public void GenderMale()
    {
      CharacterCode = CharacterCode + Mg;
    }

    public void GenderFemale()
    {
      CharacterCode = CharacterCode + Mg*2;
    }

    //---------------------------(Race)-------------------------------------

    public void RaceDwarf()
    {

    }

    public void RaceElf()
    {
      CharacterCode = CharacterCode + Mr*2;
    }

    public void RaceHalfling()
    {
      CharacterCode = CharacterCode + Mr*3;
    }

    public void RaceHuman()
    {
      CharacterCode = CharacterCode + Mr*4;
    }

    public void RaceDragonborn()
    {
      CharacterCode = CharacterCode + Mr*5;
    }

    public void RaceHalfelf()
    {
      CharacterCode = CharacterCode + Mr*6;
    }

    public void RaceHalforc()
    {
      CharacterCode = CharacterCode + Mr*7;
    }

    public void RaceTiefling()
    {
      CharacterCode = CharacterCode + Mr*8;
    }

//-------------------------------(SubRace)-----------------------------------

    public void SubRace1()//Moutain dwarf, high elf, lightfoot halfling, forest gnome
    {
    }

    public void SubRace2()//Hill dwarf, wood elf, stout halfling, rock gnome
    {
      CharacterCode = CharacterCode + Msr*1;
    }

    public void SubRace3()//Drow
    {
      CharacterCode = CharacterCode + Msr*2;
    }


    //----------------------(Class)--------------------------------------------

    public void ClassArtificer()
    {
    }

    public void ClassBarbarian()
    {
      CharacterCode = CharacterCode + Mc;
    }

    public void ClassBard()
    {
      CharacterCode = CharacterCode + Mc*2;
    }

    public void ClassCleric()
    {
      CharacterCode = CharacterCode + Mc*3;
    }

    public void ClassDruid()
    {
      CharacterCode = CharacterCode + Mc*4;
    }

    public void ClassFighter()
    {
      CharacterCode = CharacterCode + Mc*5;
    }

    public void ClassMonk()
    {
      CharacterCode = CharacterCode + Mc*6;
    }

    public void ClassPaladin()
    {
      CharacterCode = CharacterCode + Mc*7;
    }

    public void ClassRanger()
    {
      CharacterCode = CharacterCode + Mc*8;
    }

    public void ClassRogue()
    {
      CharacterCode = CharacterCode + Mc*9;
    }

    public void ClassSorcerer()
    {
      CharacterCode = CharacterCode + Mc*10;
    }

    public void ClassWarlock()
    {
      CharacterCode = CharacterCode + Mc*11;
    }

    public void ClassWizard()
    {
      CharacterCode = CharacterCode + Mc*12;
    }

    //-------------------(Aligment)-----------------------------------

    public void AligmentCG()
    {
    }

    public void AligmentCN()
    {
      CharacterCode = CharacterCode + Ma;
    }

    public void AligmentCE()
    {
      CharacterCode = CharacterCode + Ma*2;
    }

    public void AligmentNG()
    {
      CharacterCode = CharacterCode + Ma*3;
    }

    public void AligmentTN()
    {
      CharacterCode = CharacterCode + Ma*4;
    }

    public void AligmentNE()
    {
      CharacterCode = CharacterCode + Ma*5;
    }

    public void AligmentLG()
    {
      CharacterCode = CharacterCode + Ma*6;
    }

    public void AligmentLN()
    {
      CharacterCode = CharacterCode + Ma*7;
    }

    public void AligmentLE()
    {
      CharacterCode = CharacterCode + Ma*8;
    }

}
