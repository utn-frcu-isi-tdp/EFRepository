using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.Controllers
{
    public class CRUDPersonaFacade
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public void Create(Persona pPersona)
        {
            unitOfWork.PersonaRepository.Insert(pPersona);
            unitOfWork.Save();
        }

        public void Update(Persona pPersona)
        {
            unitOfWork.PersonaRepository.Update(pPersona);
            unitOfWork.Save();
        }

        public void Delete(Persona pPersona)
        {
            Persona mPersona = unitOfWork.PersonaRepository.GetByID(pPersona.PersonaId);
            unitOfWork.PersonaRepository.Delete(mPersona);
            unitOfWork.Save();
        }

        public List<Persona> GetAll()
        {
            return unitOfWork.PersonaRepository.Queryable.ToList();
            
        }

        public Persona GetById(int pPersonaId)
        {
            return unitOfWork.PersonaRepository.GetByID(pPersonaId); ;
        }




    }
}
