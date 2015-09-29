﻿using System.Windows.Data;

namespace Semantic.WpfExtensions
{
  [ValueConversion(typeof (bool), typeof (double))]
  public class BoolToOpacityConverter : BoolToValueConverter<double>
  {
    public BoolToOpacityConverter()
    {
      this.TrueValue = 1.0;
      this.FalseValue = 0.5;
    }
  }
}
