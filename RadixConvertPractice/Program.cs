using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RadixConvertPractice {
    static class Program {
        public static string appVersion = Application.ProductVersion[0].ToString() + Application.ProductVersion[1].ToString() + Application.ProductVersion[2].ToString();
        public static string msgTitle = Application.ProductName + " v" + appVersion;
        private static Mutex mutex = null;
        [STAThread]
        static void Main() {
            bool createdNew;
            mutex = new Mutex(true, Application.ProductName, out createdNew);
            if (!createdNew) {
                MessageBox.Show("Only one instance of this app is allowed.", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string generateBinary(int length = 0) {
            if (length > 0) {
                try {
                    int[] x = new int[length];
                    Random r = new Random();
                    string output = "";
                    while (x.Any(item => item == 1) == false)
                        for (int i = 0; i < x.Length; i++) {
                            x[i] = r.Next(0, 2);
                        }
                    for (int i = 0; i < x.Length; i++) output += x[i].ToString();
                    return output.TrimStart('0');
                } catch (Exception ex) {
                    MessageBox.Show("error when generating binary number:\n\n" + ex.Message, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "error";
                }
            } else {
                MessageBox.Show("please enter a valid number length.", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
        }

        public static string generateOctal(int length = 0) {
            if (length > 0) {
                try {
                    int[] x = new int[length];
                    Random r = new Random();
                    string output = "";
                    while (x.Any(item => item == 1) == false)
                        for (int i = 0; i < x.Length; i++) {
                            x[i] = r.Next(0, 8);
                        }
                    for (int i = 0; i < x.Length; i++) output += x[i].ToString();
                    return output.TrimStart('0');
                } catch (Exception ex) {
                    MessageBox.Show("error when generating octal number:\n\n" + ex.Message, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "error";
                }
            } else {
                MessageBox.Show("please enter a valid number length.", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
        }

        public static string generateDecimal(int length = 0) {
            if (length > 0) {
                try {
                    int[] x = new int[length];
                    Random r = new Random();
                    string output = "";
                    while (x.Any(item => item == 1) == false)
                        for (int i = 0; i < x.Length; i++) {
                            x[i] = r.Next(0, 10);
                        }
                    for (int i = 0; i < x.Length; i++) output += x[i].ToString();
                    return output.TrimStart('0');
                } catch (Exception ex) {
                    MessageBox.Show("error when generating decimal number:\n\n" + ex.Message, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "error";
                }
            } else {
                MessageBox.Show("please enter a valid number length.", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
        }

        public static string generateHexadecimal(int length = 0) {
            if (length > 0) {
                try {
                    Random r = new Random();
                    byte[] buffer = new byte[length / 2];
                    r.NextBytes(buffer);
                    string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
                    if (length % 2 == 0)
                        return result;
                    return result + r.Next(16).ToString("X");
                } catch (Exception ex) {
                    MessageBox.Show("error when generating hexadecimal number:\n\n" + ex.Message, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "error";
                }
            } else {
                MessageBox.Show("please enter a valid number length.", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
        }
    }
}