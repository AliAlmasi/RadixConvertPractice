using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RadixConvertPractice {
    static class Program {
        private static Mutex mutex = null;
        [STAThread]
        static void Main() {
            const string appName = "RadixConvertPractice";
            bool createdNew;
            mutex = new Mutex(true, appName, out createdNew);
            if (!createdNew) {
                MessageBox.Show("Only one instance of this app is allowed.", appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string generateBinary(int length = 0) {
            if (length > 0) {
                int[] x = new int[length];
                Random r = new Random();
                string output = "";
                while (x.Any(item => item == 1) == false)
                    for (int i = 0; i < x.Length; i++) {
                        x[i] = r.Next(0, 2);
                    }
                for (int i = 0; i < x.Length; i++) output += x[i].ToString();
                if (output.Length == length) return output;
                else {
                    MessageBox.Show("error when generating binary number");
                    return "error";
                }
            } else {
                MessageBox.Show("please enter a valid number length.");
                return "error";
            }
        }

        public static string generateOctal(int length = 0) {
            if (length > 0) {
                int[] x = new int[length];
                Random r = new Random();
                string output = "";
                while (x.Any(item => item == 1) == false)
                    for (int i = 0; i < x.Length; i++) {
                        x[i] = r.Next(0, 8);
                    }
                for (int i = 0; i < x.Length; i++) output += x[i].ToString();
                if (output.Length == length) return output;
                else {
                    MessageBox.Show("error when generating octal number");
                    return "error";
                }
            } else {
                MessageBox.Show("please enter a valid number length.");
                return "error";
            }
        }

        public static string generateDecimal(int length = 0) {
            if (length > 0) {
                int[] x = new int[length];
                Random r = new Random();
                string output = "";
                while (x.Any(item => item == 1) == false)
                    for (int i = 0; i < x.Length; i++) {
                        x[i] = r.Next(0, 10);
                    }
                for (int i = 0; i < x.Length; i++) output += x[i].ToString();
                if (output.Length == length) return output;
                else {
                    MessageBox.Show("error when generating decimal number");
                    return "error";
                }
            } else {
                MessageBox.Show("please enter a valid number length.");
                return "error";
            }
        }

        public static string generateHexadecimal(int length = 0) {
            if (length > 0) {
                Random r = new Random();
                byte[] buffer = new byte[length / 2];
                r.NextBytes(buffer);
                string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
                if (length % 2 == 0) return result;
                if (result.Length == length) return result + r.Next(16).ToString("X");
                else {
                    MessageBox.Show("error when generating hexadecimal number");
                    return "error";
                }
            } else {
                MessageBox.Show("please enter a valid number length.");
                return "error";
            }
        }
    }
}
