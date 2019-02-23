using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System;
using System.Text;

public class NetWorkSC : MonoBehaviour {

    private System.Object shutDownLock = new object();

    public string serverAddress = "192.168.0.11";
    public int portTCP = 11900;


    private NetworkStream networkStream;
    private StreamReader streamReader;
    private StreamWriter streamWriter;


    private Thread threadReceive_TCP;

    private bool isConnected = false;
    public bool IsConnected
    {
        get { return isConnected; }
    }

    private TcpClient tcpClient;
    private Thread thread_connect;

    void Start()
    {
        tcpClient = new TcpClient();
        thread_connect = new Thread(BeginConnection);
        thread_connect.Start();
    }

    private void BeginConnection()
    {
        int conCount = 0;
        while (isConnected == false)
        {
            try
            {
                Debug.Log("접속 시도중 : " + serverAddress + ":" + portTCP);
                tcpClient.Connect(serverAddress, portTCP);
                isConnected = true;

            }
            catch (SocketException e)
            {
                Debug.Log("접속 실패. 인터넷이 끊겼거나, 상대가 접속중이 아닙니다.");
                conCount++;
                if (conCount > 5)
                {
                    Debug.Log("프로그램을 다시 켜주세요.");
                    isConnected = false;
                    return;
                }
            }
            catch (Exception e)
            {
                Debug.Log("Connect: " + e.ToString());
            }
        }

        Debug.Log("상대방과 연결 되었습니다.");

        InitTcp();
    }

    public void InitTcp()
    {
        tcpClient.NoDelay = true;
        networkStream = tcpClient.GetStream();
        streamWriter = new StreamWriter(networkStream, Encoding.UTF8);
        streamReader = new StreamReader(networkStream, Encoding.UTF8);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SendTcp("PSH");
        }
    }

    public void SendTcp(string str)
    {
        if (isConnected)
        {
            try
            {
                Debug.Log("SendTcp: " + str);
                streamWriter.WriteLine(str);
                streamWriter.Flush();
            }
            catch (Exception e)
            {
                Debug.Log("SendTcp: " + e.Message);
            }
        }
        else
        {
            Debug.Log("상대방이 접속중이 아닙니다.");
        }
    }


    public void ShutDown()
    {
        lock (shutDownLock)
        {
            if (isConnected)
            {
                isConnected = false;

                streamReader.Close();
                streamWriter.Close();

                try
                {
                    tcpClient.Close();
                }
                catch (Exception e)
                {
                    Debug.Log("Shut Down: " + e.Message);
                }
            }
        }
    }
}