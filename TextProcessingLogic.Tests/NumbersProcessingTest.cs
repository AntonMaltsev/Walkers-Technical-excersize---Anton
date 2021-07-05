using NUnit.Framework;
using SimpleInjector;
using TextProcessing.Logic.Common;
using TextProcessing.Logic.Interfaces;

namespace TextProcessing.Logic.Tests
{
    public class NumbersProcessingTests
    {
        private Container _container;
        private INumberValidation _validatingService;
        private INumbersProcessing _processingService;

        [SetUp]
        public void Setup()
        {
            InitContainers();
        }

        private void InitContainers()
        {
            _container = IoCContainer.Default;
            _container.Options.AllowOverridingRegistrations = true;
            _container.Register<INumbersProcessing, NumberProcessing>();
            _container.Register<INumberValidation, NumberValidating>();

            var _validatingService = _container.GetInstance<INumberValidation>();
            var _processingService = _container.GetInstance<INumbersProcessing>();
        }

        [TestCase(5)]

        public void NumbersProcessingPositiveTest(int number)
        {
            var validationResult = _validatingService.BasicValidation(number);
            Assert.AreEqual(validationResult, true);

            Assert.AreEqual(_processingService.BasicProcessor(3), "walkers");
            Assert.AreEqual(_processingService.BasicProcessor(5), "assessment");
            Assert.AreEqual(_processingService.BasicProcessor(15), "walkers assessment");
        }

        [TestCase(-1)]
        [TestCase(201)]

        public void NumbersProcessingNegativeTest(int number)
        {
            var validatingService = _container.GetInstance<INumberValidation>();

            var validationResult = validatingService.BasicValidation(number);
            Assert.AreEqual(validationResult, false);

            Assert.AreEqual(_processingService.BasicProcessor(4), number.ToString());
            Assert.Pass();
        }
    }
}