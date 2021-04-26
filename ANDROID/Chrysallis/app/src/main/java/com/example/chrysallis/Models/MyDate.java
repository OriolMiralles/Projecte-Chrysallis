package com.example.chrysallis.Models;

import androidx.annotation.NonNull;

import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonParseException;

import java.lang.reflect.Type;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class MyDate extends Date {
    private final SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");


    public MyDate() {
    }

    public MyDate(Date source) {
        super(source.getTime());
    }


    public SimpleDateFormat getDateFormat() {
        return dateFormat;
    }


    @Override
    public String toString() {
        return dateFormat.format(this);
    }
}


