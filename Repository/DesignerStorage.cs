using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class DesignerStorage
    {
        private Dictionary<int, Designer> Designers = new();

        public Designer Create(Designer designer)
        {
            Designers.Add(designer.Id, designer);
            return Designers[designer.Id];
        }
        public Designer Read(int designerId)
        {
            return Designers[designerId];
        }

        public Designer Update(int designerId, Designer newDesigner)
        {
            Designers[designerId] = newDesigner;
            return Designers[designerId];
        }


        public bool Delete(int designerId)
        {
            return Designers.Remove(designerId);
        }

    }
   
}