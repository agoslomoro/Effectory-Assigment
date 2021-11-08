using Effectory_Assigment.Controllers;
using Effectory_Assigment.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestEffectoryAssigment
{
    [TestClass]
    public class QuestionnaireTest
    {
        private readonly Mock<IQuestionnaireRepository> _mockRepository;
        private readonly QuestionnaireController _controller;
        public QuestionnaireTest()
        {
            _mockRepository = new Mock<IQuestionnaireRepository>();
            _controller = new QuestionnaireController(_mockRepository.Object);
        }
        [TestMethod]
        public void GetQuestionnaire_ShouldReturnQuestionnaire()
        {
            var controller = _controller.Get(1000);
            Assert.IsNotNull(controller.Result);
        }
    }
}
