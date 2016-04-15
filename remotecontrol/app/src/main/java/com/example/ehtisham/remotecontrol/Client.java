package com.example.ehtisham.remotecontrol;

/**
 * Created by Shami on 4/9/2016.
 */
import android.os.StrictMode;

import java.io.PrintWriter;
import java.net.Socket;


public class Client {

    public static void SendCommand(String command) {
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);
        Socket socket;
        try {
            socket = new Socket( "192.168.8.100", 8080);
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