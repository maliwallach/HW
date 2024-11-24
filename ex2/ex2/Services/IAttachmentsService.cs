using ex2.Models;
using System.Data;

namespace ex2.Services
{
    public interface IAttachmentsService
    {
        DataTable CreateAttachment(string attachmentName, string attachmentPath);
        bool Create(AttachmentWithTask model);

    }
}
