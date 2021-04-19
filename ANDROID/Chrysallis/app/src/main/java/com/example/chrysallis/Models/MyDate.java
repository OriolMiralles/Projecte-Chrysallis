package com.example.chrysallis.Models;

import java.text.SimpleDateFormat;
import java.util.Date;

public class MyDate extends Date {
    private final SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");

    public MyDate() {
    }

    public MyDate(Date source) {
        super(source.getTime());
    }



    @Override
    public String toString() {
        return dateFormat.format(this);
    }
}
