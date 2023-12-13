using Data.Entities;

namespace Laboratorium3___App.Models
{
    public class ContactMapper
    {
        public static ContactEntity GetEntityFromModel(Contact contact)
        {
            return new ContactEntity()
            {
                ContactId = contact.Id,
                Name = contact.Name,
                Email = contact.Email,
                Phone = contact.Phone,
                Birth = contact.Birth,
                OrganizationId = contact.OrganizationId,
                Priority = (int)contact.Priority
            };
        }

        public static Contact GetModelFromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Id = entity.ContactId,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                Birth = entity.Birth,
                OrganizationId = entity.OrganizationId,
                Priority = (Priority)entity.Priority
            };
        }
    }
}
