using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScreenEffects : MonoBehaviour
{
    //==============================
    //AXIAL TILING
    //==============================

    public Color demoStandard_col;
    public int demoStandard_iNumRows;
    public bool demoStandard_bFillColumnsFirst;
    public float demoStandard_fDelay;
    public bool demoStandard_bIsLeft;
    public bool demoStandard_bIsBottom;

    public void DemoTileScreen()
    {
        ScreenEffects.AxialTiling(demoStandard_col, demoStandard_iNumRows, demoStandard_fDelay, this, demoStandard_bFillColumnsFirst, demoStandard_bIsLeft, demoStandard_bIsBottom);
    }

    //==============================
    //DIAGONAL TILING
    //==============================

    public Color demoDiag_col;
    public int demoDiag_iNumRows;
    public float demoDiag_fDelay;
    public bool demoDiag_bIsLeft;
    public bool demoDiag_bIsBottom;

    public void DemoTileScreenDiagonally()
    {
        ScreenEffects.DiagonalTiling(demoDiag_col, demoDiag_iNumRows, demoDiag_fDelay, demoDiag_bIsLeft, demoDiag_bIsBottom, this);
    }

    //==============================
    //HORIZONTAL TILING
    //==============================

    public Color demoHorBan_col;
    public AnimationCurve demoHorBan_animCurve;
    public int demoHorBan_iNumBan;
    public float demoHorBan_fDelay;
    public float demoHorBan_fAcrossTime;
    public bool demoHorBan_bIsLeft;
    public bool demoHorBan_bIsEntering;
    public bool demoHorBan_bIsTop;

    public void DemoHorizontalBanners()
    {
        ScreenEffects.HorizontalBanners(demoHorBan_col, demoHorBan_iNumBan, demoHorBan_fDelay, demoHorBan_fAcrossTime, demoHorBan_bIsLeft, demoHorBan_bIsEntering, demoHorBan_bIsTop, this, null, demoHorBan_animCurve);
    }

    //==============================
    //VERTICAL BANNERS
    //==============================

    public Color demoVerBan_col;
    public AnimationCurve demoVerBan_animCurve;
    public int demoVerBan_iNumBan;
    public float demoVerBan_fDelay;
    public float demoVerBan_fAcrossTime;
    public bool demoVerBan_bIsLeft;
    public bool demoVerBan_bIsEntering;
    public bool demoVerBan_bIsTop;

    public void DemoVerticalBanners()
    {
        ScreenEffects.VerticalBanners(demoVerBan_col, demoVerBan_iNumBan, demoVerBan_fDelay, demoVerBan_fAcrossTime, demoVerBan_bIsLeft, demoVerBan_bIsEntering, demoVerBan_bIsTop, this, null, demoVerBan_animCurve);
    }

    //==============================
    //BARS
    //==============================

    public Color demoBar_col;
    public AnimationCurve demoBar_animCurve;
    public float demoBar_fTime;
    public float demoBar_fProportion;
    public bool demoBar_bIsHorizontal;
    public bool demoBar_bIsEntering;

    public void DemoBars()
    {
        ScreenEffects.Bars(demoBar_fTime, demoBar_bIsHorizontal, demoBar_bIsEntering, demoBar_fProportion, demoBar_col, this, null, demoBar_animCurve);
    }

    //==============================
    //KEYHOLE
    //==============================

    public Keyhole demoKey_keyhole;
    public Color demoKey_Col;
    public AnimationCurve demoKey_anim;
    public float demoKey_fTime;
    public Transform demoKey_target;
    public bool demoKey_bIsEntering;

    public void DemoKeyhole()
    {
        ScreenEffects.Keyhole(demoKey_keyhole, demoKey_target, demoKey_fTime, demoKey_bIsEntering, demoKey_Col, demoKey_anim, this);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            StartCoroutine(Showcase());
        }
    }

    private IEnumerator Showcase()
    {
        ScreenEffects.AxialTiling(demoStandard_col, demoStandard_iNumRows, demoStandard_fDelay, this, demoStandard_bFillColumnsFirst, demoStandard_bIsLeft, demoStandard_bIsBottom);

        yield return new WaitForSeconds(2);

        ScreenEffects.Keyhole(demoKey_keyhole, demoKey_target, demoKey_fTime, false, demoKey_Col, demoKey_anim, this);

        yield return new WaitForSeconds(1.7f);

        ScreenEffects.DiagonalTiling(demoDiag_col, demoDiag_iNumRows, demoDiag_fDelay, true, false, this);

        yield return new WaitForSeconds(2.2f);

        ScreenEffects.HorizontalBanners(demoHorBan_col, demoHorBan_iNumBan, demoHorBan_fDelay, demoHorBan_fAcrossTime, demoHorBan_bIsLeft, false, demoHorBan_bIsTop, this, null, demoHorBan_animCurve);

        yield return new WaitForSeconds(2);

        ScreenEffects.AxialTiling(demoStandard_col, demoStandard_iNumRows, demoStandard_fDelay, this, demoStandard_bFillColumnsFirst, demoStandard_bIsLeft, demoStandard_bIsBottom);

        yield return new WaitForSeconds(2);

        ScreenEffects.VerticalBanners(demoVerBan_col, demoVerBan_iNumBan, demoVerBan_fDelay, demoVerBan_fAcrossTime, demoVerBan_bIsLeft, false, demoVerBan_bIsTop, this, null, demoVerBan_animCurve);

        yield return new WaitForSeconds(2);

        ScreenEffects.HorizontalBanners(demoHorBan_col, demoHorBan_iNumBan, demoHorBan_fDelay, demoHorBan_fAcrossTime, false, true, demoHorBan_bIsTop, this, null, demoHorBan_animCurve);

        yield return new WaitForSeconds(2);

        ScreenEffects.VerticalBanners(demoVerBan_col, demoVerBan_iNumBan, demoVerBan_fDelay, demoVerBan_fAcrossTime, demoVerBan_bIsLeft, false, false, this, null, demoVerBan_animCurve);

        yield return new WaitForSeconds(2);

        ScreenEffects.Bars(demoBar_fTime, demoBar_bIsHorizontal, demoBar_bIsEntering, demoBar_fProportion, demoBar_col, this, null, demoBar_animCurve);

        yield return new WaitForSeconds(1f);

        ScreenEffects.Bars(demoBar_fTime, demoBar_bIsHorizontal, false, demoBar_fProportion, demoBar_col, this, null, demoBar_animCurve);

        yield return new WaitForSeconds(1f);

        ScreenEffects.Keyhole(demoKey_keyhole, demoKey_target, demoKey_fTime, true, demoKey_Col, demoKey_anim, this);
    }
}
