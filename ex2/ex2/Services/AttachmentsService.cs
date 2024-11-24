using ex2.Models;
using ex2.Repositories;
using ex2.Services;
using System.Data;

namespace ex2.Services
{
    public class AttachmentsServices : IAttachmentsService
    {
        private readonly IAttachmentsRepository _attachmentsRepository;

        public AttachmentsServices(IAttachmentsRepository attachmentsRepository)
        {
            _attachmentsRepository = attachmentsRepository;
        }

        public DataTable CreateAttachment(string attachmentName, string attachmentPath)
        {
            return _attachmentsRepository.CreateAttachment(attachmentName, attachmentPath);
        }

        public bool Create(AttachmentWithTask model)
        {
            return _attachmentsRepository.ProcessTransaction(model.Attachment, model.Task);
        }
    }
}