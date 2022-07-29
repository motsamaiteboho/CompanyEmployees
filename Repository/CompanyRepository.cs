using Contracts;
using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	internal sealed class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
	{
		public CompanyRepository(RepositoryContext repositoryContext)
			: base(repositoryContext)
		{
		}

        public IEnumerable<Company> GetAllCompanies(bool trackChanges)
        {
			return FindAll(trackChanges).OrderBy(c => c.Name).ToList();
        }

        public Company GetCompany(Guid companyId, bool trackChanges)
        {
           return  FindByCondition(c => c.Id.Equals(companyId), trackChanges)
                .SingleOrDefault();
        }

        public void CreateCompany(Company company) => Create(company);

        public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges) => 
            FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToList();
    }
}
