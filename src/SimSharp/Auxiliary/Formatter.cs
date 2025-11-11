using System;

namespace SimSharp {
  public static class Formatter {
    public static string Format12(double number, bool silenceNaN = true) {
      if (double.IsNaN(number)) return silenceNaN ? "            " : "     nan    ";
      if (number >= 1e7 || number <= -1e7) {
        if (number >= 1e100 || number <= -1e100) return $"{number,12:0.####E+000}";
        return $"{number,12:0.#####E+00}";
      }
      if (Math.Abs(number) < 1e-3) {
        if (number == 0) return "       0    ";
        if (Math.Abs(number) <= 1e-100) {
          return $"{number,12:0.####E-000}";
        }
        return $"{number,12:0.#####E-00}";
      }
      if (number == (int)number) return $"{(int)number,8}    ";
      return $"{number.ToString("0.000"),12}";
    }

    public static string Format15(double number, bool silenceNaN = true) {
      if (double.IsNaN(number)) return silenceNaN ? "               " : "        nan    ";
      if (number >= 1e10 || number <= -1e10) {
        if (number >= 1e100 || number <= -1e100) return $"{number,15:0.#######E+000}";
        return $"{number,15:0.########E+00}";
      }
      if (Math.Abs(number) < 1e-3) {
        if (number == 0) return "          0    ";
        if (Math.Abs(number) <= 1e-100) {
          return $"{number,15:0.#######E-000}";
        }
        return $"{number,15:0.########E-00}";
      }
      if (number == (int)number) return $"{(int)number,11}    ";
      return $"{number.ToString("0.000"),15}";
    }
  }
}
