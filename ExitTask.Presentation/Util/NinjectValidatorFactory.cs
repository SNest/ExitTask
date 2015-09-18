using System;

using FluentValidation;
using Ninject;

namespace ExitTask.Presentation.Util
{
    using System.Linq;

    public class NinjectValidatorFactory : ValidatorFactoryBase
    {
        private readonly IKernel kernel;

        /// <summary>
        /// Initializes a new instance of the <see cref="NinjectValidatorFactory"/> class.
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        public NinjectValidatorFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        /// <summary>
        /// Creates an instance of a validator with the given type using ninject.
        /// </summary>
        /// <param name="validatorType">Type of the validator.</param>
        /// <returns>The newly created validator</returns>
        public override IValidator CreateInstance(Type validatorType)
        {
            if (!this.kernel.GetBindings(validatorType).Any())
            {
                return null;
            }

            return this.kernel.Get(validatorType) as IValidator;
        }
    }
}