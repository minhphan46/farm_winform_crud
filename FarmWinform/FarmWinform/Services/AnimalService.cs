using FarmWinform.Dtos;
using FarmWinform.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace FarmWinform.Services
{
    public class AnimalService
    {
        private AnimalRepository _animalRepository = new AnimalRepository();

        // Phương thức để lấy tiếng kêu của tất cả các loài gia súc trong nông trại
        public string GetFarmSounds()
        {
            var animalTypes = _animalRepository.GetAnimalTypes();
            var sounds = animalTypes.Select(at => at.Sound).ToList();

            return string.Join(", ", sounds);  // Trả về chuỗi tiếng kêu ngăn cách bởi dấu phẩy
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
