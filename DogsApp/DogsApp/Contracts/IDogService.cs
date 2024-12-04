﻿using DogsApp.Infrastructure.Data.Domain;

namespace DogsApp.Contracts
{
    public interface IDogService
    {
        bool Create(string name , int age, string breed, string picture);
        bool UpdateDog(int dogId, string name, int age, string breed, string picture);
        bool Uploading (int dogId, string name, int age, string breed, string picture);
        List<Dog> GetDogs();
        Dog GetDogById(int dogId);
        bool RemoveById(int dogId);
        List<Dog> GetDogs(string searchStringBreed, string searchStringName);

    }
}
