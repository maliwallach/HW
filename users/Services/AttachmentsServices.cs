using System.Data;
using users.Repositoreis;
using users.Repositories;

namespace users.Services
{
    public class AttachmentsServices : IAttachmentsService
    {
        private readonly IAttachmentsRepository _attachmentsRepository;

        public AttachmentsServices(IAttachmentsRepository attachmentsRepository)
        {
            _attachmentsRepository = attachmentsRepository;
        }

        public DataTable CreateAttachment(string name, string path, string dateUplode)
        {
            return _attachmentsRepository.CreateAttachment(name, path, dateUplode);
        }
    }
}
