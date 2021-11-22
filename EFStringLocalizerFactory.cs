using CollaborativeBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog
{
    public class EFStringLocalizerFactory : IStringLocalizerFactory
    {
        string _connectionString;
        public EFStringLocalizerFactory(string connection)
        {
            _connectionString = connection;
        }

        public IStringLocalizer Create(Type resourceSource)
        {
            return CreateStringLocalizer();
        }

        public IStringLocalizer Create(string baseName, string location)
        {
            return CreateStringLocalizer();
        }

        private IStringLocalizer CreateStringLocalizer()
        {
            ApplicationContext db = new ApplicationContext(
                new DbContextOptionsBuilder<ApplicationContext>()
                    .UseSqlServer(_connectionString)
                    .Options);

            if (!db.Cultures.Any())
            {
                db.AddRange(
                    new Culture
                    {
                        Name = "en",
                        Resources = new List<Resource>()
                        {
                            new Resource { Key = "Header", Value = "Hello" },
                            new Resource { Key = "Message", Value = "Welcome" }
                        }
                    },
                    new Culture
                    {
                        Name = "ru",
                        Resources = new List<Resource>()
                        {
                            new Resource { Key = "Header", Value = "Привет" },
                            new Resource { Key = "Message", Value = "Добро пожаловать" }
                        }
                    }
                );
                db.SaveChanges();
            }
            return new EFStringLocalizer(db);
        }
    }
}
