﻿using FarmWinform.Dtos;
using FarmWinform.Repositories;
using System.Collections.Generic;

namespace FarmWinform.Services
{
    public class AnimalService
    {
        private AnimalRepository _animalRepository = new AnimalRepository();

        public List<AnimalDTO> GetAllAnimals()
        {
            return _animalRepository.GetAnimals();
        }

        public List<AnimalTypeDTO> GetAllAnimalTypes()
        {
            return _animalRepository.GetAnimalTypes();
        }

        public void SaveAnimal(AnimalDTO animalDTO)
        {
            _animalRepository.SaveAnimal(animalDTO);
        }

        public void DeleteAnimal(int animalId)
        {
            _animalRepository.DeleteAnimal(animalId);
        }
    }
}
