using FarmWinform.Dtos;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;

namespace FarmWinform.Repositories
{
    public class AnimalRepository
    {
        public List<AnimalDTO> GetAnimals()
        {
            using (FarmDbEntities db = new FarmDbEntities())
            {
                var animalData = (from a in db.Animals
                                  join at in db.AnimalTypes
                                  on a.AnimalTypeId equals at.AnimalTypeId
                                  select new AnimalDTO
                                  {
                                      AnimalId = a.AnimalId,
                                      AnimalTypeId = a.AnimalTypeId ?? 1,
                                      AnimalTypeName = at.AnimalName,
                                      MilkProduced = a.MilkProduced,
                                      OffspringCount = a.OffspringCount
                                  }).ToList();
                return animalData;
            }
        }

        public List<AnimalTypeDTO> GetAnimalTypes()
        {
            using (FarmDbEntities db = new FarmDbEntities())
            {
                return db.AnimalTypes.Select(at => new AnimalTypeDTO
                {
                    AnimalTypeId = at.AnimalTypeId,
                    AnimalName = at.AnimalName,
                    Sound = at.Sound
                }).ToList();
            }
        }

        public void SaveAnimal(AnimalDTO animalDTO)
        {
            using (FarmDbEntities db = new FarmDbEntities())
            {
                Animal animal = new Animal
                {
                    AnimalId = animalDTO.AnimalId,
                    AnimalTypeId = animalDTO.AnimalTypeId,
                    MilkProduced = animalDTO.MilkProduced,
                    OffspringCount = animalDTO.OffspringCount
                };

                if (animal.AnimalId == 0)
                    db.Animals.Add(animal);
                else
                    db.Entry(animal).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public void DeleteAnimal(int animalId)
        {
            using (FarmDbEntities db = new FarmDbEntities())
            {
                var animal = db.Animals.FirstOrDefault(a => a.AnimalId == animalId);
                if (animal != null)
                {
                    db.Animals.Remove(animal);
                    db.SaveChanges();
                }
            }
        }
    }
}