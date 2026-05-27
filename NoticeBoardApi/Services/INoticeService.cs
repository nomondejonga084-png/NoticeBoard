using NoticeBoardApi.Models;
namespace NoticeBoardApi.Services
{
    public interface INoticeService
    {
        IEnumerable<Notice> GetAll();
        IEnumerable<Notice> GetArchived();
        Notice? GetById(int id);
        Notice Create(Notice notice);
        Notice? Update(int id, Notice notice);
        bool Delete(int id);
    } }
