using System.ComponentModel;
using System.Globalization;

namespace FinanceTracker.UI.CustomTools
{
	public class NumberBoxCustom : TextBox
	{
		#region Properties

		private string _typeName = typeof(int).ToString();

		[Category("Data")]
		[Description("Тип данных вводимый в NumberBoxCustom")]
		[TypeConverter(typeof(DataTypeConverter))]
		public string TypeName
		{
			get => _typeName;
			set => _typeName = value;
		}

		[Category("Data")]
		[DefaultValue(true)]
		[Description("Разрешено ли вводить отрицательные числа")]
		public bool AllowNegativeNumber { get; set; } = true;

		public static new string Text
		{
			get => throw new InvalidOperationException("Свойство Text запрещено к использованию в NumberBoxCustom");
			set => throw new InvalidOperationException("Свойство Text запрещено к использованию в NumberBoxCustom");
		}

		#endregion

		private readonly char _decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];

		public NumberBoxCustom()
		{
			KeyDown += ActionKeyDown;
			KeyPress += ActionKeyPress;
		}

		private void ActionKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (!IsConversionSuccessful(e.KeyCode.ToString()))
				{
					e.Handled = true;
				}
			}
		}

		private void ActionKeyPress(object sender, KeyPressEventArgs e)
		{
			// Запрещает ввод знака '-' если отключено св-во AllowNegativeNumber
			if (!AllowNegativeNumber && e.KeyChar == '-')
			{
				e.Handled = true;
			}

			// Замена точки или запятой на десятичный разделитель
			if (e.KeyChar == '.' || e.KeyChar == ',')
			{
				e.KeyChar = _decimalSeparator;
			}

			if (!IsConversionSuccessful(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// Конвертирует текст с введенным значением в указанный тип данных и возвращает результат попытки
		/// </summary>
		/// <returns>True, если конвертация прошла успешно; в противном случае — False</returns>
		private bool IsConversionSuccessful(string key)
		{
			Type selectedType = Type.GetType(TypeName);
			int selectionStart = SelectionStart;
			int selectionLength = SelectionLength;

			// Если было выделение, производится удаление выделенной части
			string text = selectionLength > 0
				? base.Text.Remove(selectionStart, selectionLength)
				: base.Text;

			// Проверка на символ "BackSpace"
			if (key == "\b")
			{
				if (selectionLength == 0 && selectionStart > 0)
				{
					text = text.Remove(selectionStart - 1, 1);
					selectionStart--;
				}

				key = "";
			}

			// Проверка на символ "Delete"
			if (key == "Delete")
			{
				if (selectionLength == 0 && selectionStart < text.Length)
				{
					text = text.Remove(selectionStart, 1);
				}

				key = "";
			}

			// Добавление введенного символа
			text = (text[..selectionStart] + key + text[selectionStart..]).Trim();

			// Проверка на символ "-"
			bool isNumericType = selectedType == typeof(byte) || selectedType == typeof(ushort) || selectedType == typeof(uint) || selectedType == typeof(ulong);
			if (!isNumericType)
			{
				if (text.Length == 1 && text[^1] == '-')
				{
					text = "0";
				}
				else if (text.Length > 1 && text[^1] == '-')
				{
					return false;
				}
			}

			// Проверяем на возможность конвертации
			if (selectedType != null && text != "")
			{
				try
				{
					object convertedValue = Convert.ChangeType(text, selectedType);
				}
				catch
				{
					return false;
				}
			}

			return true;
		}

		#region GetNumbers

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public byte? GetByte()
		{
			if (typeof(byte) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(byte)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return byte.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public sbyte? GetSbyte()
		{
			if (typeof(sbyte) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(sbyte)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return sbyte.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public short? GetShort()
		{
			if (typeof(short) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(short)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return short.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public ushort? GetUshort()
		{
			if (typeof(ushort) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(ushort)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return ushort.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public int? GetInt()
		{
			if (typeof(int) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(int)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return int.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public uint? GetUint()
		{
			if (typeof(uint) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(uint)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return uint.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public long? GetLong()
		{
			if (typeof(long) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(long)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return long.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public ulong? GetUlong()
		{
			if (typeof(ulong) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(ulong)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return ulong.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public float? GetFloat()
		{
			if (typeof(float) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(float)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return float.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public double? GetDouble()
		{
			if (typeof(double) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(double)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return double.Parse(base.Text);
		}

		/// <summary>
		/// Получение данных ввода
		/// </summary>
		/// <returns>Если пустой текст, то вернет <see cref="null"/></returns>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public decimal? GetDecimal()
		{
			if (typeof(decimal) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(decimal)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (string.IsNullOrWhiteSpace(base.Text))
				return null;
			if (base.Text == "-")
				return 0;

			return decimal.Parse(base.Text);
		}


		#endregion

		#region SetNumbers

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(byte? value)
		{
			if (typeof(byte) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(byte)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(sbyte? value)
		{
			if (typeof(sbyte) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(sbyte)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(short? value)
		{
			if (typeof(short) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(short)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(ushort? value)
		{
			if (typeof(ushort) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(ushort)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(int? value)
		{
			if (typeof(int) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(int)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(uint? value)
		{
			if (typeof(uint) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(uint)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(long? value)
		{
			if (typeof(long) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(long)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(ulong? value)
		{
			if (typeof(ulong) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(ulong)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(float? value)
		{
			if (typeof(float) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(float)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(double? value)
		{
			if (typeof(double) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(double)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		/// <summary>
		/// Задает текст по указаному значению
		/// </summary>
		/// <param name="value">Должно соответствовать указаному типу в <see cref="TypeName"/></param>
		/// <exception cref="ArgumentException">Вызовет если тип задаваемого значения не будет соответствовать <see cref="TypeName"/></exception>
		public void SetValue(decimal? value)
		{
			if (typeof(decimal) != Type.GetType(TypeName))
				throw new ArgumentException($"Тип {typeof(decimal)} не совпадает с ожидаемым типом {Type.GetType(TypeName)}!");
			if (value == null)
				base.Text = string.Empty;

			base.Text = value.ToString();
		}

		#endregion

		/// <summary>
		/// Получение данных ввода в виде текстовой строки
		/// </summary>
		public string GetString()
		{
			return base.Text;
		}

		/// <summary>
		/// Пользовательский конвертер типа данных
		/// </summary>
		public class DataTypeConverter : TypeConverter
		{
			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				// Разрешаем выбор из стандартных значений
				return true;
			}

			public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				// Возвращаем список поддерживаемых типов данных
				return new StandardValuesCollection(
					new Type[]
					{
						typeof(byte),
						typeof(sbyte),
						typeof(short),
						typeof(ushort),
						typeof(int),
						typeof(uint),
						typeof(long),
						typeof(ulong),
						typeof(float),
						typeof(double),
						typeof(decimal)
					}
				);
			}
		}
	}
}