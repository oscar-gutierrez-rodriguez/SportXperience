// Generated by view binder compiler. Do not edit!
package com.example.sportxperience_android.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.viewbinding.ViewBinding;
import androidx.viewbinding.ViewBindings;
import com.example.sportxperience_android.R;
import com.google.android.material.button.MaterialButton;
import java.lang.NullPointerException;
import java.lang.Override;
import java.lang.String;

public final class ActivityFormulariNivellBinding implements ViewBinding {
  @NonNull
  private final LinearLayout rootView;

  @NonNull
  public final MaterialButton btSaberNivell;

  @NonNull
  public final ImageView btTornar;

  @NonNull
  public final LinearLayout main;

  @NonNull
  public final RadioGroup pregunta1;

  @NonNull
  public final RadioGroup pregunta2;

  @NonNull
  public final RadioGroup pregunta3;

  @NonNull
  public final RadioGroup pregunta4;

  @NonNull
  public final RadioGroup pregunta5;

  @NonNull
  public final RadioGroup pregunta6;

  @NonNull
  public final RadioGroup pregunta7;

  @NonNull
  public final RadioGroup pregunta8;

  @NonNull
  public final RadioButton res11;

  @NonNull
  public final RadioButton res12;

  @NonNull
  public final RadioButton res13;

  @NonNull
  public final RadioButton res14;

  @NonNull
  public final RadioButton res15;

  @NonNull
  public final RadioButton res16;

  @NonNull
  public final RadioButton res17;

  @NonNull
  public final RadioButton res18;

  @NonNull
  public final RadioButton res21;

  @NonNull
  public final RadioButton res22;

  @NonNull
  public final RadioButton res23;

  @NonNull
  public final RadioButton res24;

  @NonNull
  public final RadioButton res25;

  @NonNull
  public final RadioButton res26;

  @NonNull
  public final RadioButton res27;

  @NonNull
  public final RadioButton res28;

  @NonNull
  public final RadioButton res31;

  @NonNull
  public final RadioButton res32;

  @NonNull
  public final RadioButton res33;

  @NonNull
  public final RadioButton res34;

  @NonNull
  public final RadioButton res35;

  @NonNull
  public final RadioButton res36;

  @NonNull
  public final RadioButton res37;

  @NonNull
  public final RadioButton res38;

  private ActivityFormulariNivellBinding(@NonNull LinearLayout rootView,
      @NonNull MaterialButton btSaberNivell, @NonNull ImageView btTornar,
      @NonNull LinearLayout main, @NonNull RadioGroup pregunta1, @NonNull RadioGroup pregunta2,
      @NonNull RadioGroup pregunta3, @NonNull RadioGroup pregunta4, @NonNull RadioGroup pregunta5,
      @NonNull RadioGroup pregunta6, @NonNull RadioGroup pregunta7, @NonNull RadioGroup pregunta8,
      @NonNull RadioButton res11, @NonNull RadioButton res12, @NonNull RadioButton res13,
      @NonNull RadioButton res14, @NonNull RadioButton res15, @NonNull RadioButton res16,
      @NonNull RadioButton res17, @NonNull RadioButton res18, @NonNull RadioButton res21,
      @NonNull RadioButton res22, @NonNull RadioButton res23, @NonNull RadioButton res24,
      @NonNull RadioButton res25, @NonNull RadioButton res26, @NonNull RadioButton res27,
      @NonNull RadioButton res28, @NonNull RadioButton res31, @NonNull RadioButton res32,
      @NonNull RadioButton res33, @NonNull RadioButton res34, @NonNull RadioButton res35,
      @NonNull RadioButton res36, @NonNull RadioButton res37, @NonNull RadioButton res38) {
    this.rootView = rootView;
    this.btSaberNivell = btSaberNivell;
    this.btTornar = btTornar;
    this.main = main;
    this.pregunta1 = pregunta1;
    this.pregunta2 = pregunta2;
    this.pregunta3 = pregunta3;
    this.pregunta4 = pregunta4;
    this.pregunta5 = pregunta5;
    this.pregunta6 = pregunta6;
    this.pregunta7 = pregunta7;
    this.pregunta8 = pregunta8;
    this.res11 = res11;
    this.res12 = res12;
    this.res13 = res13;
    this.res14 = res14;
    this.res15 = res15;
    this.res16 = res16;
    this.res17 = res17;
    this.res18 = res18;
    this.res21 = res21;
    this.res22 = res22;
    this.res23 = res23;
    this.res24 = res24;
    this.res25 = res25;
    this.res26 = res26;
    this.res27 = res27;
    this.res28 = res28;
    this.res31 = res31;
    this.res32 = res32;
    this.res33 = res33;
    this.res34 = res34;
    this.res35 = res35;
    this.res36 = res36;
    this.res37 = res37;
    this.res38 = res38;
  }

  @Override
  @NonNull
  public LinearLayout getRoot() {
    return rootView;
  }

  @NonNull
  public static ActivityFormulariNivellBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static ActivityFormulariNivellBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.activity_formulari_nivell, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static ActivityFormulariNivellBinding bind(@NonNull View rootView) {
    // The body of this method is generated in a way you would not otherwise write.
    // This is done to optimize the compiled bytecode for size and performance.
    int id;
    missingId: {
      id = R.id.bt_saberNivell;
      MaterialButton btSaberNivell = ViewBindings.findChildViewById(rootView, id);
      if (btSaberNivell == null) {
        break missingId;
      }

      id = R.id.bt_tornar;
      ImageView btTornar = ViewBindings.findChildViewById(rootView, id);
      if (btTornar == null) {
        break missingId;
      }

      LinearLayout main = (LinearLayout) rootView;

      id = R.id.pregunta1;
      RadioGroup pregunta1 = ViewBindings.findChildViewById(rootView, id);
      if (pregunta1 == null) {
        break missingId;
      }

      id = R.id.pregunta2;
      RadioGroup pregunta2 = ViewBindings.findChildViewById(rootView, id);
      if (pregunta2 == null) {
        break missingId;
      }

      id = R.id.pregunta3;
      RadioGroup pregunta3 = ViewBindings.findChildViewById(rootView, id);
      if (pregunta3 == null) {
        break missingId;
      }

      id = R.id.pregunta4;
      RadioGroup pregunta4 = ViewBindings.findChildViewById(rootView, id);
      if (pregunta4 == null) {
        break missingId;
      }

      id = R.id.pregunta5;
      RadioGroup pregunta5 = ViewBindings.findChildViewById(rootView, id);
      if (pregunta5 == null) {
        break missingId;
      }

      id = R.id.pregunta6;
      RadioGroup pregunta6 = ViewBindings.findChildViewById(rootView, id);
      if (pregunta6 == null) {
        break missingId;
      }

      id = R.id.pregunta7;
      RadioGroup pregunta7 = ViewBindings.findChildViewById(rootView, id);
      if (pregunta7 == null) {
        break missingId;
      }

      id = R.id.pregunta8;
      RadioGroup pregunta8 = ViewBindings.findChildViewById(rootView, id);
      if (pregunta8 == null) {
        break missingId;
      }

      id = R.id.res1_1;
      RadioButton res11 = ViewBindings.findChildViewById(rootView, id);
      if (res11 == null) {
        break missingId;
      }

      id = R.id.res1_2;
      RadioButton res12 = ViewBindings.findChildViewById(rootView, id);
      if (res12 == null) {
        break missingId;
      }

      id = R.id.res1_3;
      RadioButton res13 = ViewBindings.findChildViewById(rootView, id);
      if (res13 == null) {
        break missingId;
      }

      id = R.id.res1_4;
      RadioButton res14 = ViewBindings.findChildViewById(rootView, id);
      if (res14 == null) {
        break missingId;
      }

      id = R.id.res1_5;
      RadioButton res15 = ViewBindings.findChildViewById(rootView, id);
      if (res15 == null) {
        break missingId;
      }

      id = R.id.res1_6;
      RadioButton res16 = ViewBindings.findChildViewById(rootView, id);
      if (res16 == null) {
        break missingId;
      }

      id = R.id.res1_7;
      RadioButton res17 = ViewBindings.findChildViewById(rootView, id);
      if (res17 == null) {
        break missingId;
      }

      id = R.id.res1_8;
      RadioButton res18 = ViewBindings.findChildViewById(rootView, id);
      if (res18 == null) {
        break missingId;
      }

      id = R.id.res2_1;
      RadioButton res21 = ViewBindings.findChildViewById(rootView, id);
      if (res21 == null) {
        break missingId;
      }

      id = R.id.res2_2;
      RadioButton res22 = ViewBindings.findChildViewById(rootView, id);
      if (res22 == null) {
        break missingId;
      }

      id = R.id.res2_3;
      RadioButton res23 = ViewBindings.findChildViewById(rootView, id);
      if (res23 == null) {
        break missingId;
      }

      id = R.id.res2_4;
      RadioButton res24 = ViewBindings.findChildViewById(rootView, id);
      if (res24 == null) {
        break missingId;
      }

      id = R.id.res2_5;
      RadioButton res25 = ViewBindings.findChildViewById(rootView, id);
      if (res25 == null) {
        break missingId;
      }

      id = R.id.res2_6;
      RadioButton res26 = ViewBindings.findChildViewById(rootView, id);
      if (res26 == null) {
        break missingId;
      }

      id = R.id.res2_7;
      RadioButton res27 = ViewBindings.findChildViewById(rootView, id);
      if (res27 == null) {
        break missingId;
      }

      id = R.id.res2_8;
      RadioButton res28 = ViewBindings.findChildViewById(rootView, id);
      if (res28 == null) {
        break missingId;
      }

      id = R.id.res3_1;
      RadioButton res31 = ViewBindings.findChildViewById(rootView, id);
      if (res31 == null) {
        break missingId;
      }

      id = R.id.res3_2;
      RadioButton res32 = ViewBindings.findChildViewById(rootView, id);
      if (res32 == null) {
        break missingId;
      }

      id = R.id.res3_3;
      RadioButton res33 = ViewBindings.findChildViewById(rootView, id);
      if (res33 == null) {
        break missingId;
      }

      id = R.id.res3_4;
      RadioButton res34 = ViewBindings.findChildViewById(rootView, id);
      if (res34 == null) {
        break missingId;
      }

      id = R.id.res3_5;
      RadioButton res35 = ViewBindings.findChildViewById(rootView, id);
      if (res35 == null) {
        break missingId;
      }

      id = R.id.res3_6;
      RadioButton res36 = ViewBindings.findChildViewById(rootView, id);
      if (res36 == null) {
        break missingId;
      }

      id = R.id.res3_7;
      RadioButton res37 = ViewBindings.findChildViewById(rootView, id);
      if (res37 == null) {
        break missingId;
      }

      id = R.id.res3_8;
      RadioButton res38 = ViewBindings.findChildViewById(rootView, id);
      if (res38 == null) {
        break missingId;
      }

      return new ActivityFormulariNivellBinding((LinearLayout) rootView, btSaberNivell, btTornar,
          main, pregunta1, pregunta2, pregunta3, pregunta4, pregunta5, pregunta6, pregunta7,
          pregunta8, res11, res12, res13, res14, res15, res16, res17, res18, res21, res22, res23,
          res24, res25, res26, res27, res28, res31, res32, res33, res34, res35, res36, res37,
          res38);
    }
    String missingId = rootView.getResources().getResourceName(id);
    throw new NullPointerException("Missing required view with ID: ".concat(missingId));
  }
}
