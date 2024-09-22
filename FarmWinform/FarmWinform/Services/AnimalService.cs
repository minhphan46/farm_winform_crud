using FarmWinform.Dtos;
using FarmWinform.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmWinform.Services
{
    public class AnimalService
    {
        private AnimalRepository _animalRepository = new AnimalRepository();
        private Random random = new Random();

        public List<AnimalDTO> GetAllAnimalsAfterBreedingAndMilking()
        {
            var animals = _animalRepository.GetAnimals();

            foreach (var animal in animals)
            {
                // Tạo số lượng con sinh ra ngẫu nhiên
                animal.OffspringGenerated = random.Next(1, 5); // Giả sử mỗi con sinh 1-4 con

                // Tạo số lit sữa dựa vào loại động vật
                switch (animal.AnimalTypeName)
                {
                    case "Bò":
                        animal.MilkProducedInRound = Math.Round(random.NextDouble() * 20, 2); // 0-20 lít
                        break;
                    case "Cừu":
                        animal.MilkProducedInRound = Math.Round(random.NextDouble() * 5, 2);  // 0-5 lít
                        break;
                    case "Dê":
                        animal.MilkProducedInRound = Math.Round(random.NextDouble() * 10, 2); // 0-10 lít
                        break;
                    default:
                        animal.MilkProducedInRound = 0;
                        break;
                }

                // Cập nhật tổng số con và lượng sữa cho động vật đó
                animal.OffspringCount += animal.OffspringGenerated;
                animal.MilkProduced += animal.MilkProducedInRound;
            }

            return animals;
        }

        public string GetFarmSounds()
        {
            // Phương thức để lấy tiếng kêu của tất cả các loài gia súc trong nông trại
            var animalTypes = _animalRepository.GetAnimalTypes();
            var sounds = animalTypes.Select(at => at.Sound).ToList();

            return string.Join(", ", sounds);
        }

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
