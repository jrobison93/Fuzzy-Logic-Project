using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuzzy_Logic_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(FuzzyAPI.Normalize(DistanceMembership.MeleeRange((int)DistanceToEnemy.Value)))
            {
                MovementRecommendation.Text = "MOVE TOWARDS NEAREST ENEMY";
                GunAction.Text = "PERFORM MELEE ATTACK";
            }
            else if(FuzzyAPI.Normalize(
                FuzzyAPI.FuzzyAnd(FuzzyAPI.FuzzyAnd(DistanceMembership.CloseRange((int)DistanceToEnemy.Value), PersonCountMembership.Few((int)NumAllies.Value)), 
                    FuzzyAPI.FuzzyOr(PercentageMembership.Low((int)healthPercentage.Value), PercentageMembership.MediumLow((int)healthPercentage.Value)))))
            {
                if(EnemyFire.Checked && 
                    FuzzyAPI.Normalize(FuzzyAPI.FuzzyOr(DistanceMembership.CloseRange((int) DistanceToCover.Value), 
                        DistanceMembership.MeleeRange((int)DistanceToCover.Value))))
                {
                    MovementRecommendation.Text = "MOVE TOWARDS COVER";
                }
                else
                {
                    MovementRecommendation.Text = "MOVE AWAY FROM NEAREST ENEMY";
                }

                if(FuzzyAPI.Normalize(PercentageMembership.Low((int) AmmoPercentage.Value)))
                {
                    GunAction.Text = "RELOAD";
                }
                else
                {
                    GunAction.Text = "FIRE AT ENEMY";
                }
            }
            else if (FuzzyAPI.Normalize(
               FuzzyAPI.FuzzyAnd(DistanceMembership.CloseRange((int)DistanceToEnemy.Value), FuzzyAPI.FuzzyNot(PersonCountMembership.Few((int)NumAllies.Value)))))
            {
                MovementRecommendation.Text = "MOVE TOWARDS NEAREST ALLY";
                GunAction.Text = "FIRE AT ENEMY";
            }
            else
            {
                MovementRecommendation.Text = "FIND NEAREST TARGET";
                GunAction.Text = "HOLD FIRE";
            }

        }
    }
}
