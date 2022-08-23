using ComponentProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentProcessing.Repository.IRepository
{
    public interface IComponentProcessingRepository
    {
        ICollection<ComponentProcessingModel> GetComponentProcessings();

        ComponentProcessingModel GetComponentProcessing(int ComponentProcessingID);
        bool ComponentProcessingExists(string name);
        bool ComponentProcessingExists(int id);

        bool CreateComponentProcessing(ComponentProcessingModel componentProcessing);
        bool UpdateComponentProcessing(int cpID, ComponentProcessingModel componentProcessing);
        bool DeleteComponentProcessing(ComponentProcessingModel componentProcessing);

        bool Save();
    }
}
