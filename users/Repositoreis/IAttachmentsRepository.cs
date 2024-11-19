using System.Data;

namespace users.Repositoreis
{
    public interface IAttachmentsRepository
    {
        DataTable CreateAttachment(string name, string path, string dateUplode);
    }
}
