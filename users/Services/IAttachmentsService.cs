using System.Data;

namespace users.Services
{
    public interface IAttachmentsService
    {
        DataTable CreateAttachment(string name, string path, string dateUplode);
    }

}
