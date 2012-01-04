
namespace RiaBat.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // TODO: Create methods containing your application logic.
    [EnableClientAccess()]
    public class DomainService1 : DomainService
    {
        List<ClientEntity> entities = new List<ClientEntity>();

        public DomainService1()
        {
            entities.Add(new ClientEntity() { Id = 1, Name = "One" });
            entities.Add(new ClientEntity() { Id = 2, Name = "Two" });
        }

        [Query]
        public IEnumerable<ClientEntity> GetClientEntities()
        {
            return entities.AsEnumerable();
        }

        [Insert]
        public void InsertClientEntity(ClientEntity ent)
        {
            entities.Add(ent);
        }
    }

    public class ClientEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}


