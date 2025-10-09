using LexicalAnalysis;
using LexicalMachine;

namespace UI;

/// <summary>
/// Главная форма приложения для лексического анализа текста.
/// Предоставляет интерфейс для ввода текста, выполнения анализа и просмотра результатов.
/// </summary>
public partial class FormMain : Form
{
    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="FormMain"/>.
    /// </summary>
    public FormMain()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Обработчик события нажатия кнопки "Анализировать текст".
    /// Выполняет лексический анализ введенного текста и отображает результаты.
    /// </summary>
    private void buttonAnalyze_Click(object sender, EventArgs e)
    {
        // Очищаем поле сообщений и таблицу распознанных токенов.
        richTextBoxMessages.Clear();
        dataGridViewRecognizedTokens.Rows.Clear();

        // Проверяем, не пустой ли исходный текст
        if (richTextBoxInput.Lines.Length == 0)
        {
            dataGridViewRecognizedTokens.Rows.Add(1, string.Empty, TokenKind.EndOfText, 0, 0);
            richTextBoxMessages.AppendText("Входной текст пуст");
            return;
        }

        // Создаем лексический анализатор с помощью фабрики
        var lexAn = AnalyzerCreator.Create(richTextBoxInput.Text);
        int tokensCount = 0; // Инициализируем счетчик распознанных токенов.

        // Процесс лексического анализа должен быть обернут в "try...catch",
        // поскольку лексический анализатор при обнаружении ошибки в тексте генерирует исключительную ситуацию.
        try
        {
            var curToken = new Token(string.Empty, TokenKind.Unknown, 0, 0);

            // Цикл чтения текста от начала до конца.
            do
            {
                curToken = lexAn.GetNextToken(); // Распознаем очередной токен в тексте.

                tokensCount++; // Увеличиваем счетчик распознанных токенов.

                // Добавляем распознанный токен в таблицу.
                dataGridViewRecognizedTokens.Rows.Add(
                    tokensCount,                    // Порядковый номер токена
                    curToken.Value,                // Значение токена
                    curToken.Type,                 // Тип токена
                    curToken.LineIndex + 1,        // Номер строки (1-based)
                    curToken.SymStartIndex + 1);   // Позиция в строке (1-based)
            }
            while (curToken.Type != TokenKind.EndOfText); // Цикл работает до тех пор, пока не будет возвращен токен "Конец текста".

            richTextBoxMessages.AppendText($"Текст правильный");
        }
        catch (LexAnException lexAnException)
        {
            // В тексте была обнаружена лексическая ошибка.

            // Добавляем описание ошибки в поле сообщений.
            richTextBoxMessages.AppendText($"Ошибка ({lexAnException.LineIndex + 1},{lexAnException.SymIndex + 1}): {lexAnException.Message}");

            // Располагаем курсор в исходном тексте на позиции ошибки.
            LocateCursorAtErrorPosition(lexAnException.LineIndex, lexAnException.SymIndex);
        }
    }

    /// <summary>
    /// Позиционирует курсор в текстовом поле ввода на позиции обнаруженной ошибки.
    /// </summary>
    private void LocateCursorAtErrorPosition(int lineIndex, int symIndex)
    {
        int absolutePosition = 0;

        // Подсчитываем суммарное количество символов во всех строках до lineIndex.
        for (int i = 0; i < lineIndex; i++)
        {
            absolutePosition += richTextBoxInput.Lines[i].Length + 1; // +1 для учета символа новой строки
        }

        // Прибавляем символы из строки lineIndex.
        absolutePosition += symIndex;

        // Располагаем курсор на вычисленной позиции и выделяем проблемный символ.
        richTextBoxInput.Select();
        richTextBoxInput.Select(absolutePosition, 1);
        richTextBoxInput.ScrollToCaret(); // Прокручиваем текст к выделенному символу
    }

    /// <summary>
    /// Обработчик события загрузки формы.
    /// Выполняет начальную настройку интерфейса.
    /// </summary>
    private void FormMain_Load(object sender, EventArgs e)
    {
        // Настраиваем заголовки столбцов таблицы токенов
        dataGridViewRecognizedTokens.Columns.Clear();
        dataGridViewRecognizedTokens.Columns.AddRange(
            new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn() { Name = "Number", HeaderText = "№", Width = 40 },
                new DataGridViewTextBoxColumn() { Name = "Value", HeaderText = "Значение", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "Type", HeaderText = "Тип токена", Width = 120 },
                new DataGridViewTextBoxColumn() { Name = "Line", HeaderText = "Строка", Width = 60 },
                new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Позиция", Width = 70 }
            });

        // Устанавливаем текст примера для демонстрации
        richTextBoxInput.Text = "a01b 10ac {комментарий} b1a0";
        richTextBoxMessages.Text = "Введите текст для анализа и нажмите кнопку \"Анализировать текст\"";
    }

    /// <summary>
    /// Обработчик события нажатия кнопки "Очистить".
    /// Очищает все поля формы.
    /// </summary>
    private void buttonClear_Click(object sender, EventArgs e)
    {
        richTextBoxInput.Clear();
        richTextBoxMessages.Clear();
        dataGridViewRecognizedTokens.Rows.Clear();
    }
}