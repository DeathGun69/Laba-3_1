using System;
using System.Collections.Generic;
using System.Net;


namespace KPO_laba3_1
{
    

    class Program
    {
        static void Main(string[] args)
        {
            /*String str = new String("");

            str = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostEntry(str);

            Console.WriteLine($"\nХост: {str} \nIP-адрес{ip.AddressList[2]}\n"); */
            
            string ip_list = "";
            List<Connection> con_ip_list = new List<Connection>();
            try {
                for(int i=0; i<255; i++){
                    ip_list = "192.168.56." + i;
                    Connection con = new Connection(ip_list);
                    if (con.active == true)
                        con_ip_list.Add(con);
                }
                foreach(var curAdd in con_ip_list){
                    curAdd.get_Information();
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
            
    }
}