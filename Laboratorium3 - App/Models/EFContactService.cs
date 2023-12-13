using Data;
using Data.Entities;

namespace Laboratorium3___App.Models
{
    public class EFContactService : IContactService
    {
        private readonly AppDbContext context;

        public EFContactService(AppDbContext context)
        {
            this.context = context;
        }

        public int Add(Contact contact)
        {
            var entry = context.Contacts.Add(ContactMapper.GetEntityFromModel(contact));
            context.SaveChanges();
            int id = entry.Entity.ContactId;
            return id;
        }

        public void Delete(int id)
        {
            ContactEntity? entity = context.Contacts.Find(id);
            if (entity is null) throw new Exception();

            context.Contacts.Remove(entity);
            context.SaveChanges();
        }

        public List<Contact> FindAll()
        {
            return context.Contacts.Select(entity => ContactMapper.GetModelFromEntity(entity)).ToList();
        }

        public Contact? FindById(int id)
        {
            ContactEntity? entity = context.Contacts.Find(id);

            return entity is null ? null : ContactMapper.GetModelFromEntity(entity);
        }

        public void Update(Contact contact)
        {
            context.Contacts.Update(ContactMapper.GetEntityFromModel(contact));
            context.SaveChanges();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            return context.Organizations.ToList();
        }
        public PagingList<Contact> FindPage(int page, int size)
        {
            var pagingList = PagingList<Contact>.Create(null, context.Contacts.Count(), page, size);
            var data = context.Contacts
                .OrderBy(contact => contact.Name)
                .Skip((pagingList.Number - 1) * pagingList.Size)
                .Take(pagingList.Size)
                .Select(ContactMapper.GetModelFromEntity)
                .ToList();
            pagingList.Data = data;
            return pagingList;
        }
    }
}
