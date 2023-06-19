using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class ConstructionLogic
    {
        public void CreateBuilding<T>(T building, List<Building> buildings) where T : Building
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<T>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                buildings.Add(building);
            }
        }

        public bool ConstructBuilding<T>(List<Material> materials, bool permit, bool zoning) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    var firstStep = material.MaterialConstructionFirstStep();
                    Console.WriteLine(firstStep);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
