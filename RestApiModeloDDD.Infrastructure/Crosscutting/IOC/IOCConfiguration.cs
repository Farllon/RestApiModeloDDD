using Autofac;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mapper;
using RestApiModeloDDD.Application.Mapper;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Services;
using RestApiModeloDDD.Infrastructure.Data.Repositories;

namespace RestApiModeloDDD.Infrastructure.Crosscutting.IOC
{
    public class IOCConfiguration
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<CustomerApplicationService>().As<ICustomerApplicationService>();
            builder.RegisterType<ProductApplicationService>().As<IProductApplicationService>();

            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            builder.RegisterType<CustomerMapper>().As<ICustomerMapper>();
            builder.RegisterType<ProductMapper>().As<IProductMapper>();

            #endregion IOC
        }
    }
}