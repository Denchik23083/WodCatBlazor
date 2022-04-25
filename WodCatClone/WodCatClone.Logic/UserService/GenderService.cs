using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.UserService
{
    public class GenderService : IGenderService
    {
        private readonly IGenderRepository _repository;

        public GenderService(IGenderRepository repository)
        {
            _repository = repository;
        }

        public string GetGenderImage(int? id)
        {
            var gender = _repository.GetGenderImage(id);

            return gender.Image;
        }

        public string GetGender(int? id)
        {
            var gender = _repository.GetGender(id);

            return gender.Name;
        }
    }
}
