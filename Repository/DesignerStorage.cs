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
         public Designer Read(Designer designer)
            {
                return Designers[designer.Id];
            }

            public Designer Update(Designer designer, Designer newDesigner)
            {
                Designers[designer.Id] = newDesigner;
                return Designers[designer.Id];
            }

        internal Designer Read(int desId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Designer designer)
            {
                return Designers.Remove(designer.Id);
            }

        internal Designer Update(int desId, Designer newDesigner)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int desId)
        {
            throw new NotImplementedException();
        }
    }

   
}