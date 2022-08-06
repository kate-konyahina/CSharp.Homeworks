// See https://aka.ms/new-console-template for more information
using HW._10.Moto;
using HW._10.Moto.Repositories;

IMotorcycleRepository motorcycleRepository;
motorcycleRepository = new StaticCollectionMotorcycleRepository();

Motorcycle moto1 = new Motorcycle ("C20", "Honda", 2022, 256);
Motorcycle moto2 = new Motorcycle("C22", "Yamaha", 2002, 280);
Motorcycle moto3 = new Motorcycle("C23", "Kawasaki", 2010, 270);

motorcycleRepository.CreateMotorcycle(moto1);
motorcycleRepository.CreateMotorcycle(moto2);
motorcycleRepository.CreateMotorcycle(moto3);

motorcycleRepository.GetMotorcycles();
