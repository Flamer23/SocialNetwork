using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.Tests;

public class Tests
{
    public static UserRepository userRepository;

    [Test]
    public void UserDeleteByIdMustNotReturnOne()
    {
        userRepository = new UserRepository();
        Assert.AreNotEqual(1, userRepository.DeleteById(1000));
    }  
}