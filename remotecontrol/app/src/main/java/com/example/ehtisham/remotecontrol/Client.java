package com.example.ehtisham.remotecontrol;

/**
 * Created by Jamil on 4/9/2016.
 */
import android.os.StrictMode;

import java.io.PrintWriter;
import java.net.Socket;


public class Client {

    public boolean check(String ip)
    {
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);
        Socket socket;
        try {
        //    socket = new Socket( "192.168.0.106", 8080);
            socket = new Socket( ip, 8080);
            socket.close();
            return true;
        } catch (Exception e) {

            e.printStackTrace();
        }
        return false;
    }
    public static void SendCommand(String command,String ip) {
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);
        Socket socket;
        try {
            socket = new Socket( ip, 8080);
            PrintWriter writer = new PrintWriter(socket.getOutputStream());
            writer.print(command);
            writer.flush();
            writer.close();
            socket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }

    }

}