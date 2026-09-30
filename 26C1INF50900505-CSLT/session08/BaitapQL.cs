using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session08
{
    internal class BaitapQL
    {
        /*The X company has 3 working groups; group 1 has 5 members, group 2 has 3 members, and group 3 has 6 members. 
         *The data stored for each member has an ID number, full name, and completed tasks. 
         *An ID identifies each member.
        Select an appropriate data structure to save this info. Then, write functions to perform the following tasks:
        1.Initialize an array with pre-assigned values ​​or values ​​entered from the keyboard.
        2.Print a list of all members.
        3.Print the information on a member when the ID is known.
        4.Print the member with the highest number of completed tasks.
        Create the main program with menus that allow you to select the tasks to be performed.
        Hint: create a jagged array to store these members in the form [id,[name, tasks]].
         */

        static void init(string[][,] emps)
        {
            //emps = new string[3][,];
            emps[0] = new string[5, 3]
            {
                {"1001","Than Thi Det","7" },
                {"1002","Tran Thi Men","9" },
                {"1003","Nguyen Van Coi","12" },
                {"1004","Truong Van Tun","3" },
                {"1005","Dang Van Ty","8" }
            };
            emps[1] = new string[3, 3]
            {
                {"1006","","13" },
                {"1007","","8" },
                {"1008","","2" },
            };

            emps[2] = new string[6, 3]
            {
                {"1009","","5" },
                {"1010","","15" },
                {"1011","","11" },
                {"1012","","14" },
                {"1013","","9" },
                {"104","","6" },
            };
        }

        static void print_members(string[][,] emps)
        {
            foreach (string[,] row in emps)
            {
                for(int i=0;i<row.GetLength(1);i++)
                {
                    Console.WriteLine($"Id: {row[i,0]}, Name: { row[i,1]}, No Tasks: {row[i,2]}");
                }
            }
        }
        static void print_member(string[][,] emps, string id)
        {
            bool found = false;//gia su khong tim thay
            foreach (string[,] row in emps)
            {
                for (int i = 0; i < row.GetLength(1); i++)
                {
                    if (row[i, 0] == id)
                    {
                        Console.WriteLine($"Id: {row[i, 0]}, Name: {row[i, 1]}, No Tasks: {row[i, 2]}");
                        found =true;
                        //break;
                    }
                }
            }
            if(!found)
                Console.WriteLine($"khong tim thay nhan vien co id ={id}");
        }

        static string [,] search_member(string[][,] emps, string id)
        {
            foreach (string[,] row in emps)
            {
                for (int i = 0; i < row.GetLength(1); i++)
                {
                    if (row[i, 0] == id)
                    {
                        return row;
                    }
                }
            }
            return null;
        }

        static string[] most_valuable_emp(string[][,] emps)
        {
            string [] emp_max_tasks = null;
            int max = 0;
            foreach (string[,] row in emps)
            {
                for (int i = 0; i < row.GetLength(1); i++)
                {
                    int tasks = int.Parse(row[i, 2]);
                    if (tasks > max)
                    {
                        max = tasks;
                        emp_max_tasks = new string[3]{row[i,0],row[i,1],row[i,2]};
                    }
                }
            }
            return emp_max_tasks;
        }


        public static void Main(string[] args)
        {
            string[][,] emps = new string[3][,];
            init(emps);
            Console.WriteLine("DANH SACH NHAN VIEN");
            print_members(emps);
            Console.WriteLine();
            string f_id = "1002";
            print_member(emps, f_id);
            string [,]row = search_member(emps, f_id);
            if (row != null)
                Console.WriteLine($"Id: {row[0, 0]}, Name: {row[0, 1]}, No Tasks: {row[0, 2]}");
            else
                Console.WriteLine("Khong tim thay");

            string[] mve = most_valuable_emp(emps);
            Console.WriteLine("Nhan vien sieng nang nhat");
            Console.WriteLine($"Id: {mve[0]}, Name: {mve[1]}, No Tasks: {mve[2]}");

        }

        
    }
}
