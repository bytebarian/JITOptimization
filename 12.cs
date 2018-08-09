public interface Maybe<T>
{
  bool HasValue();
  T Value();
}
