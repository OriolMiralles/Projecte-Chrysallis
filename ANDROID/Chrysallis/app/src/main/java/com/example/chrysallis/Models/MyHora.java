package com.example.chrysallis.Models;

import java.text.SimpleDateFormat;
import java.util.Date;

public class MyHora extends Date {
    private final SimpleDateFormat dateFormat = new SimpleDateFormat("HH:mm:ss");

    public MyHora(Date source) {

        super(source.getTime());
    }
}
