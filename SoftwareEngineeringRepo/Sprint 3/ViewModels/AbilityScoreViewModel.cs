using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class AbilityScoreViewModel : Screen
    {
        //Properties 
        public String AbilityScoreName
        {
            get;
            set;
        } = "Ability Scores";

        public String AbilityScoreDescription 
        { 
            get; 
            set; 
        } = "Roll You Ability Scores";

        public void StrengthMouseOver()
        {
            AbilityScoreName = "Strength";
        }

        public void ConstitutionMouseOver()
        {
            AbilityScoreName = "Constitution";
        }

        public void DexterityMouseOver()
        {
            AbilityScoreName = "Dexterity";
        }

        public void IntelligenceMouseOver()
        {
            AbilityScoreName = "Intellgence";
        }

        public void WisdomMouseOver()
        {
            AbilityScoreName = "Wisdom";
        }

        public void CharismaMouseOver()
        {
            AbilityScoreName = "Charisma";
        }
    }
}
