namespace UNSTEP.Common
{
    using System;

    /* Zoran Horvat at Pluralsight: https://app.pluralsight.com/player?course=advanced-defensive-programming-techniques&author=zoran-horvat&name=advanced-defensive-programming-techniques-m9&clip=6*/
    public abstract class Either<TLeft, TRight> // By convention, left indicates failure and right success!
    {
        public abstract Either<TNewLeft, TRight> MapLeft<TNewLeft>(Func<TLeft, TNewLeft> mapping);

        public abstract Either<TLeft, TNewRight> MapRight<TNewRight>(Func<TRight, TNewRight> mapping);

        public abstract TLeft Reduce(Func<TRight, TLeft> mapping);
    }

    public class Left<TLeft, TRight> : Either<TLeft, TRight>
    {
        public Left(TLeft value)
        {
            this.Value = value;
        }

        private TLeft Value { get; }

        public override Either<TNewLeft, TRight> MapLeft<TNewLeft>(Func<TLeft, TNewLeft> mapping)
            => new Left<TNewLeft, TRight>(mapping(this.Value));

        public override Either<TLeft, TNewRight> MapRight<TNewRight>(Func<TRight, TNewRight> mapping) =>
            new Left<TLeft, TNewRight>(this.Value);

        public override TLeft Reduce(Func<TRight, TLeft> mapping) => this.Value;
    }

    public class Right<TLeft, TRight> : Either<TLeft, TRight>
    {
        public Right(TRight value)
        {
            this.Value = value;
        }

        private TRight Value { get; }

        public override Either<TNewLeft, TRight> MapLeft<TNewLeft>(Func<TLeft, TNewLeft> mapping) =>
            new Right<TNewLeft, TRight>(this.Value);

        public override Either<TLeft, TNewRight> MapRight<TNewRight>(Func<TRight, TNewRight> mapping) =>
            new Right<TLeft, TNewRight>(mapping(this.Value));

        public override TLeft Reduce(Func<TRight, TLeft> mapping) => mapping(this.Value);
    }
}
