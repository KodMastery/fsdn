namespace FSDN.PetStore
{
    internal record PetStoreDto(string Name, IPet[] Pets, PetOwner[] PetOwners)
    {

    }
}
