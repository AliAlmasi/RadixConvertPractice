using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;

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
                showError("Only one instance of this app is allowed.");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.firstRun) {
                string firstRunMsg = "Hello. Thank you for using RadixConvertPractice. We hope that this software will be useful for you in the practice of converting classical bases of numbers.\n\nThis is a free and open source software. You can read the source code of this software and be sure of its security and integrity.\n\nAlso, if you encounter a problem while using this software, be sure to inform the developer (by submitting an issue on GitHub) so that it can be fixed in the next versions of this software.";
                MessageBox.Show(firstRunMsg, msgTitle);
                Properties.Settings.Default.firstRun = false;
                Properties.Settings.Default.Save();
            }
            Application.Run(new Form1());
        }

        public static void showError(string errorText = "Runtime error!\nInform the developer by creating an issue on GitHub.", bool issues = false) {
            MessageBox.Show(errorText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (issues) System.Diagnostics.Process.Start("https://github.com/alialmasi/radixconvertpractice/issues");
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
                    return output;
                } catch (Exception ex) {
                    showError("error when generating binary number:\n\n" + ex.Message);
                    return "error";
                }
            } else {
                showError("please enter a valid number length.");
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
                    return output;
                } catch (Exception ex) {
                    showError("error when generating octal number:\n\n" + ex.Message);
                    return "error";
                }
            } else {
                showError("please enter a valid number length.");
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
                    return output;
                } catch (Exception ex) {
                    showError("error when generating decimal number:\n\n" + ex.Message);
                    return "error";
                }
            } else {
                showError("please enter a valid number length.");
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
                    showError("error when generating hexadecimal number:\n\n" + ex.Message);
                    return "error";
                }
            } else {
                showError("please enter a valid number length.");
                return "error";
            }
        }
    }
}