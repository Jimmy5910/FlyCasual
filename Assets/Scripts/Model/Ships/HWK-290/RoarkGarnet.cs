﻿using Ship;
using System.Collections.Generic;
using System;
using SubPhases;

namespace Ship
{
    namespace HWK290
    {
        public class RoarkGarnet : HWK290
        {
            public RoarkGarnet() : base()
            {
                PilotName = "Roark Garnet";
                PilotSkill = 4;
                Cost = 19;

                IsUnique = true;

                faction = Faction.Rebel;

                PilotAbilities.Add(new Abilities.RoarkGarnetAbility());
            }
        }
    }
}

namespace Abilities
{
    public class RoarkGarnetAbility : GenericAbility, IModifyPilotSkill
    {
        public override void ActivateAbility()
        {
            Phases.OnCombatPhaseStart += RegisterAbility;
        }

        public override void DeactivateAbility()
        {
            Phases.OnCombatPhaseStart -= RegisterAbility;
        }

        private void RegisterAbility()
        {
            RegisterAbilityTrigger(TriggerTypes.OnCombatPhaseStart, Ability);
        }

        private void Ability(object sender, EventArgs e)
        {
            if (HostShip.Owner.Ships.Count > 1)
            {
                SelectTargetForAbility(
                    SelectAbilityTarget,
                    FilterAbilityTarget,
                    GetAiAbilityPriority,
                    HostShip.Owner.PlayerNo
                );
            }
            else
            {
                Triggers.FinishTrigger();
            }
        }

        private bool FilterAbilityTarget(GenericShip ship)
        {
            return FilterByTargetType(ship, new List<TargetTypes>() { TargetTypes.OtherFriendly }) && FilterTargetsByRange(ship, 1, 3);
        }

        private int GetAiAbilityPriority(GenericShip ship)
        {
            int result = 0;
            if (Actions.HasTarget(ship)) result += 100;
            result += (12 - ship.PilotSkill);
            return result;
        }

        private void SelectAbilityTarget()
        {
            TargetShip.AddPilotSkillModifier(this);
            Phases.OnEndPhaseStart += RemovePilotSkillModifieer;
            SelectShipSubPhase.FinishSelection();
        }

        private void RemovePilotSkillModifieer()
        {
            Phases.OnEndPhaseStart -= RemovePilotSkillModifieer;
            TargetShip.RemovePilotSkillModifier(this);
        }

        public void ModifyPilotSkill(ref int pilotSkill)
        {
            pilotSkill = 12;
        }
    }
}
