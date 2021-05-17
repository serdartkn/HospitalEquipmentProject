using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //AOP Mimarisini daha etkin kullanabilmek amacıyla microsoft Ioc yapısı yerine Autofac kullanıldı.
        //Proje ile alakalı işlemler burada, genel işlemler ise Core>DependencyResolvers klasöründe yapılmıştır.
        //Autofac ile ilgili konfigürasyon işlemi WebAPI>Program.cs dosyasında yapıldı.

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClinicManager>().As<IClinicService>().SingleInstance();
            builder.RegisterType<EfClinicDal>().As<IClinicDal>().SingleInstance();

            builder.RegisterType<EquipmentManager>().As<IEquipmentService>().SingleInstance();
            builder.RegisterType<EfEquipmentDal>().As<IEquipmentDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }

    }
}