namespace Transliteration;

/// <summary>
/// Представляет классифицированный символ с указанием его типа и значения.
/// Используется для передачи информации о символах в процессе лексического анализа.
/// </summary>
public readonly struct ClassifiedLetter
{
    // Допустимые символы для классификации
    private readonly  HashSet<char> validLetters = new() { 'a', 'b', 'c', 'd'};
    private readonly HashSet<char> validDigits = new() { '0', '1' };

    /// <summary>
    /// Символьное значение.
    /// </summary>
    public readonly char Value;

    /// <summary>
    /// Тип символа согласно классификации.
    /// </summary>
    public readonly LetterType Type;

    /// <summary>
    /// Инициализирует новый экземпляр структуры как маркер конца текста.
    /// </summary>
    public ClassifiedLetter() => Type = LetterType.EndOfText;

    /// <summary>
    /// Инициализирует новый экземпляр структуры с указанным символом и определяет его тип.
    /// </summary>
    public ClassifiedLetter(char value)
    {
        Value = value;

        // Классификация символа по приоритету
        if (validLetters.Contains(value))
            Type = LetterType.ValidLetter;
        else if (validDigits.Contains(value))
            Type = LetterType.ValidDigit;
        else if (value == '\n')
            Type = LetterType.EndOfLine;
        else if (value == ' ')
            Type = LetterType.Space;
        else if (value == '}' || value == '{')
            Type = LetterType.Reserved;
        else
            Type = LetterType.Other;
    }

    public override readonly bool Equals(object? obj)
    {
        if (obj is ClassifiedLetter other)
            return Type == other.Type && Value == other.Value;

        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Type, Value);

    public override string ToString() => $"{Type.ToString()} {Value.ToString()}";

    public static bool operator ==(ClassifiedLetter left, ClassifiedLetter right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ClassifiedLetter left, ClassifiedLetter right)
    {
        return !(left == right);
    }
}

public enum LetterType
{
    ValidLetter,    // Допустимая буква.
    ValidDigit,     // Допустимая цифра.
    Space,     // Пробел.
    Reserved,  // Зарезервированный.
    Other,     // Другой.
    EndOfText,  // Конец текста.
    EndOfLine   // Конец строки.
};

