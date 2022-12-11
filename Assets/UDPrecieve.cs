using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDPrecieve : MonoBehaviour
{
    Thread receiveThread;
    UdpClient cl;
    public int port=5052;
    public bool startRec=true;
    public bool print_con=true;
    public string data;
    
    public void Start()
    {
        receiveThread=new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground=true;
        receiveThread.Start();
        
    }
    
    private void ReceiveData(){
    
    
    cl=new UdpClient(port);
    while(startRec){
    try{
    
    IPEndPoint anyIP=new IPEndPoint(IPAddress.Any,0);
    byte[] dataByte=cl.Receive(ref anyIP);
    data=Encoding.UTF8.GetString(dataByte);
    if(print_con){print(data);
    }
    
    
    
    }
    catch(Exception err){
    
    print(err.ToString());
    }
       
    
    
    }
    }

 
}
