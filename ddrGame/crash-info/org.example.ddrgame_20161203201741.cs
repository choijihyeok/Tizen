S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: ddrgame
PID: 7610
Date: 2016-12-03 20:17:41+0900
Executable File Path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000ee88

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x8000ee78, esi = 0xbfb6e0b7
ebp = 0xbfb6e008, esp = 0xbfb6dfd0
eax = 0xb8b53700, ebx = 0xb64207fc
ecx = 0x00000000, edx = 0xb8b52fb8
eip = 0xb63d2254

Memory Information
MemTotal:      123 KB
MemFree:        38 KB
Buffers:         6 KB
Cached:     149100 KB
VmPeak:      80040 KB
VmSize:      80040 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16132 KB
VmRSS:       16132 KB
VmData:      19984 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33452 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 7610 TID = 7610
7610 7628 7819 

Maps Information
b2c05000 b2c0f000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c15000 b2c21000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c22000 b2c43000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c48000 b2c49000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c4a000 b2c4f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c50000 b2c51000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c52000 b2c54000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c55000 b2c61000 r-xp /usr/lib/libdrm.so.2.4.0
b2c62000 b2c65000 r-xp /usr/lib/libdri2.so.0.0.0
b2c66000 b2c70000 r-xp /usr/lib/libtbm.so.1.0.0
b2c71000 b2c86000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c87000 b2c99000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b349b000 b34a4000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34a5000 b34ae000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34af000 b34c1000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34c8000 b34c9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34ca000 b34cb000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34cc000 b34cf000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34d0000 b34d3000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35db000 b35e1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35e2000 b3726000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3736000 b3738000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3739000 b373a000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b373b000 b3741000 r-xp /usr/lib/libcapi-system-sensor.so.0.2.0
b3742000 b3746000 r-xp /opt/usr/apps/org.example.ddrgame/bin/ddrgame
b3748000 b3781000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4184000 b418f000 r-xp /lib/libnss_files-2.20-2014.11.so
b4191000 b419c000 r-xp /lib/libnss_nis-2.20-2014.11.so
b419e000 b41b5000 r-xp /lib/libnsl-2.20-2014.11.so
b41b9000 b41c1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41c3000 b41e7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41e8000 b41e9000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41ea000 b41ed000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41ee000 b41f5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41f6000 b4200000 r-xp /usr/lib/libsensord-share.so
b4201000 b421d000 r-xp /usr/lib/libsensor.so.1.2.0
b421f000 b4228000 r-xp /usr/lib/libappcore-common.so.1.1
b422b000 b422d000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4242000 b4244000 r-xp /usr/lib/libXau.so.6.0.0
b4245000 b4267000 r-xp /usr/lib/libxcb.so.1.1.0
b4269000 b4272000 r-xp /lib/libcrypt-2.20-2014.11.so
b429b000 b429d000 r-xp /usr/lib/libiri.so
b429e000 b42c4000 r-xp /lib/libexpat.so.1.5.2
b42c6000 b4331000 r-xp /usr/lib/libssl.so.1.0.0
b4337000 b4343000 r-xp /usr/lib/libethumb.so.1.13.0
b4344000 b4348000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4349000 b459a000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b15000 b5b25000 r-xp /usr/lib/libXi.so.6.1.0
b5b26000 b5b28000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b29000 b5b2f000 r-xp /usr/lib/libXtst.so.6.1.0
b5b30000 b5b3a000 r-xp /usr/lib/libXrender.so.1.3.0
b5b3b000 b5b44000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b46000 b5b48000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b49000 b5b4e000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b4f000 b5b61000 r-xp /usr/lib/libXext.so.6.4.0
b5b62000 b5b64000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b65000 b5b67000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b69000 b5cab000 r-xp /usr/lib/libX11.so.6.3.0
b5caf000 b5cb9000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cba000 b5cd0000 r-xp /usr/lib/libudev.so.1.6.0
b5cd3000 b5cd7000 r-xp /lib/libattr.so.1.1.0
b5cd8000 b5d07000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d09000 b5d0f000 r-xp /usr/lib/libffi.so.6.0.2
b5d10000 b5d33000 r-xp /lib/libz.so.1.2.8
b5d34000 b5d37000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d38000 b5e94000 r-xp /usr/lib/libxml2.so.2.9.2
b5e9a000 b5f81000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f8e000 b5f91000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f92000 b5fb4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fb5000 b5fc9000 r-xp /lib/libresolv-2.20-2014.11.so
b5fcd000 b5ff1000 r-xp /usr/lib/liblzma.so.5.0.3
b5ff2000 b5ff4000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ff6000 b6000000 r-xp /usr/lib/libembryo.so.1.13.0
b6001000 b602a000 r-xp /usr/lib/libpng12.so.0.50.0
b602b000 b6074000 r-xp /usr/lib/libjpeg.so.8.0.2
b6085000 b608c000 r-xp /lib/librt-2.20-2014.11.so
b608e000 b60ad000 r-xp /usr/lib/libector.so.1.13.0
b60b0000 b60dd000 r-xp /usr/lib/liblua-5.1.so
b60de000 b616e000 r-xp /usr/lib/libfreetype.so.6.11.3
b6172000 b61b0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61b1000 b61c7000 r-xp /usr/lib/libfribidi.so.0.3.1
b61c8000 b6221000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6224000 b626f000 r-xp /lib/libm-2.20-2014.11.so
b6271000 b6283000 r-xp /usr/lib/libeio.so.1.13.0
b6284000 b6287000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6288000 b628e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b628f000 b62b2000 r-xp /usr/lib/libefreet.so.1.13.0
b62b5000 b62e0000 r-xp /usr/lib/libeldbus.so.1.13.0
b62e1000 b6315000 r-xp /usr/lib/libecore_con.so.1.13.0
b6317000 b6320000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6321000 b632a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b632b000 b633e000 r-xp /usr/lib/libeo.so.1.13.0
b6340000 b6353000 r-xp /usr/lib/libecore_input.so.1.13.0
b6354000 b635b000 r-xp /usr/lib/libecore_file.so.1.13.0
b635c000 b637f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6380000 b63ac000 r-xp /usr/lib/libeet.so.1.13.0
b63b5000 b6420000 r-xp /usr/lib/libeina.so.1.13.0
b6423000 b643a000 r-xp /usr/lib/libefl.so.1.13.0
b643c000 b65a3000 r-xp /usr/lib/libicuuc.so.51.1
b65b1000 b67bd000 r-xp /usr/lib/libicui18n.so.51.1
b67c5000 b6814000 r-xp /usr/lib/libecore_x.so.1.13.0
b6816000 b6830000 r-xp /lib/libgcc_s-4.9.so.1
b6832000 b6836000 r-xp /lib/libcap.so.2.21
b6837000 b687d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b687e000 b6885000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6887000 b68d9000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68db000 b6a66000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a6b000 b6b39000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b3c000 b6b40000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b41000 b6b50000 r-xp /usr/lib/libvconf.so.0.2.45
b6b51000 b6b54000 r-xp /usr/lib/libvasum.so.0.3.1
b6b55000 b6b58000 r-xp /usr/lib/libttrace.so.1.1
b6b5a000 b6b5e000 r-xp /usr/lib/libiniparser.so.0
b6b5f000 b6b8f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b90000 b6b99000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b9a000 b6bbf000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bc0000 b6bd0000 r-xp /usr/lib/libunwind.so.8.0.1
b6bda000 b6d88000 r-xp /lib/libc-2.20-2014.11.so
b6d90000 b6ed3000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ed5000 b6f2d000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f2e000 b6f62000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f65000 b7039000 r-xp /usr/lib/libedje.so.1.13.0
b703c000 b7068000 r-xp /usr/lib/libecore.so.1.13.0
b7079000 b729f000 r-xp /usr/lib/libevas.so.1.13.0
b72c7000 b72df000 r-xp /lib/libpthread-2.20-2014.11.so
b72e3000 b765d000 r-xp /usr/lib/libelementary.so.1.13.0
b767d000 b7681000 r-xp /usr/lib/libsmack.so.1.0.0
b7682000 b768b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b768c000 b768f000 r-xp /usr/lib/libdlog.so.0.0.0
b7690000 b7695000 r-xp /usr/lib/libbundle.so.0.1.22
b7696000 b7699000 r-xp /lib/libdl-2.20-2014.11.so
b769b000 b76c0000 r-xp /usr/lib/libaul.so.0.1.0
b76c3000 b76c5000 r-xp /usr/lib/libappsvc.so.0.1.0
b76c6000 b76cb000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76cc000 b76d3000 r-xp /usr/lib/libappcore-efl.so.1.1
b76d5000 b76da000 r-xp /usr/lib/libsys-assert.so
b76dd000 b76de000 r-xp [vdso]
b76de000 b7700000 r-xp /lib/ld-2.20-2014.11.so
b7702000 b770a000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7610)
Call Stack Count: 9
 0: eina_list_append + 0x54 (0xb63d2254) [/usr/lib/libeina.so.1] + 0x1d254
 1: create_base_gui + 0x68b (0xb3743eeb) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x1eeb
 2: app_create + 0x2c (0xb374370c) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x170c
 3: (0xb76c861b) [/usr/lib/libcapi-appfw-application.so.0] + 0x261b
 4: appcore_efl_main + 0x327 (0xb76cfc27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
 5: ui_app_main + 0x140 (0xb76c8c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
 6: main + 0x2aa (0xb374367a) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0x167a
 7: win_delete_request_cb + 0x28 (0xb7704148) [/opt/usr/apps/org.example.ddrgame/bin/ddrgame] + 0xb7704148
 8: __libc_start_main + 0xde (0xb6bf1e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.ddrgame
Package ID : org.example.ddrgame
Version: 1.0.0
Package Type: tpk
App Name: ddrgame
App ID: org.example.ddrgame
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
:17:39.658+0900 D/rpm-installer( 7763): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-developers-root.pem]
12-03 20:17:39.658+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[30]
12-03 20:17:39.658+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29080003] pkg_type[tpk] package[org.example.ddrgame] key[install_percent] val[30] pmsg[(null)]
12-03 20:17:39.658+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[30]
12-03 20:17:39.668+0900 D/rpm-installer( 7763): rpm-installer.c: __ri_verify_file(336) > valid signature
12-03 20:17:39.668+0900 D/rpm-installer( 7763): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[1108]
12-03 20:17:39.668+0900 D/rpm-installer( 7763): MIIDOzCCAiOgAwIBAgIBADANBgkqhkiG9w0BAQUFADBYMRowGAYDVQQKDBFUaXplbiBBc3NvY2lhdGlvbjEaMBgGA1UECwwRVGl6ZW4gQXNzb2NpYXRpb24xHjAcBgNVBAMMFVRpemVuIERldmVsb3BlcnMgUm9vdDAeFw0xMjAxMDEwMDAwMDBaFw0zMjAxMDEwMDAwMDBaMFgxGjAYBgNVBAoMEVRpemVuIEFzc29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEeMBwGA1UEAwwVVGl6ZW4gRGV2ZWxvcGVycyBSb290MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAp2rCwXTYh28vcagXWLIeVtEvXA5EeTR9UnL4Dzyd7hIq8rkxLbIMMOcCrXMTc7bEH2twFaTuXxyKXMW/2c+id3m3Z1B5caCqwSPr72oKPSI4jSkvrAC5W7EHx16M818aG4tQkXIUBhDrtSmH6dFOdt8zGq2fanj1sETfUmXAeLGE7OQYcEb2SoWGXR75Ytfp1LAw/L3luuG/kbzBcrZt1Cv05jfCP575eope6p5p80Gl0tieXyPYhSLVTLwhEdWx18CMaC7IXQo2Bm+JdjDH0Ruh/vTRnjFtmVB+nBOZNVzMHNOPUVFKSgysX/+PlM4jBTvbaTnPCZUkC/O75tYIpwIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4IBAQBw95ibcuAiKpAEqBMyTZtOf0okhSi9NYfs/AFIPLH5REnhtQkPmKsvDp21OSdzrFEL42rV94K98QChD9tGO6Mwp1ZHM3No7/PLC3EelOwmn4dr3KPGdjvQNSwKRblGh0Hjn4fI+studFLLv6ldCLIpA/Ssgf9GuUbcjTC8OWBYPVUQ6YoXAcuHbfhr6a
12-03 20:17:39.668+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_verify_signatures(1274) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.ddrgame/author-signature.xml) succeed.
12-03 20:17:39.668+0900 D/rpm-installer( 7763): rpm-installer-signature.c: _ri_process_signaturevalue(533) > SignatureValue, len=[176]
12-03 20:17:39.668+0900 D/rpm-installer( 7763): 
12-03 20:17:39.668+0900 D/rpm-installer( 7763): Nx4raKdXHwSssvavy+NowCT4bCnomNqnLew3VZSxGZ4sC2naHgLsw304hRqHNSGJNYsfViP1/QdW
12-03 20:17:39.668+0900 D/rpm-installer( 7763): FyljqhgtOarRByNKefgdkDMxXwkfPWgYhZ5tk0Rq8QTwEuZwk8kapxmCbyepW4ZXjKQByQ3rp6No
12-03 20:17:39.668+0900 D/rpm-installer( 7763): kFwH2Y1+85csTM0/Z/Y=
12-03 20:17:39.668+0900 D/rpm-installer( 7763): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[909]
12-03 20:17:39.668+0900 D/rpm-installer( 7763): 
12-03 20:17:39.668+0900 D/rpm-installer( 7763): MIICmzCCAgQCCQDXI7WLdVZwiTANBgkqhkiG9w0BAQUFADCBjzELMAkGA1UEBhMCS1IxDjAMBgNV
12-03 20:17:39.668+0900 D/rpm-installer( 7763): BAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEiMCAGA1UE
12-03 20:17:39.668+0900 D/rpm-installer( 7763): CwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwbVGl6ZW4gUHVibGljIERpc3Ry
12-03 20:17:39.668+0900 D/rpm-installer( 7763): aWJ1dG9yIENBMB4XDTEyMTAyOTEzMDMwNFoXDTIyMTAyNzEzMDMwNFowgZMxCzAJBgNVBAYTAktS
12-03 20:17:39.668+0900 D/rpm-installer( 7763): MQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0Ex
12-03 20:17:39.668+0900 D/rpm-installer( 7763): IjAgBgNVBAsMGVRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKDAmBgNVBAMMH1RpemVuIFB1Ymxp
12-03 20:17:39.668+0900 D/rpm-installer( 7763): YyBEaXN0cmlidXRvciBTaWduZXIwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBALtMvlc5hENK
12-03 20:17:39.668+0900 D/rpm-installer( 7763): 90ZdA+y66+Sy0enD1gpZDBh5T9RP0oRsptJv5jjNTseQbQi0SZOdOXb6J7iQdlBCtR343RpIEz8H
12-03 20:17:39.668+0900 D/rpm-installer( 7763): mrBy7mSY7mgwoU4EPpp4CTSUeAuKcmvrNOngTp5Hv7Ngf02TTHOLK3hZLpGayaDviyNZB5PdqQdB
12-03 20:17:39.668+0900 D/rpm-installer( 7763): hokKjzAzAgMBAAEwDQYJKoZIhvcNAQEFBQADgYEAvGp1gxxAIlFfhJH1efjb9BJK/rtRkbYn9+Ez
12-03 20:17:39.668+0900 D/rpm-installer( 7763): GEbEULg1svsgnyWisFimI3uFvgI/swzr1eKVY3Sc8MQ3+Fdy3EkbDZ2+WAubhcEkorTWjzWz2fL1
12-03 20:17:39.668+0900 D/rpm-installer( 7763): vKaYjeIsuEX6TVRUugHWudPzcEuQRLQf8ibZWjbQdBmpeQYBMg5x+xKLCJc=
12-03 20:17:39.668+0900 D/rpm-installer( 7763): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[942]
12-03 20:17:39.668+0900 D/rpm-installer( 7763): 
12-03 20:17:39.668+0900 D/rpm-installer( 7763): MIICtDCCAh2gAwIBAgIJAMDbehElPNKvMA0GCSqGSIb3DQEBBQUAMIGVMQswCQYDVQQGEwJLUjEO
12-03 20:17:39.668+0900 D/rpm-installer( 7763): MAwGA1UECAwFU3V3b24xDjAMBgNVBAcMBVN1d29uMRYwFAYDVQQKDA1UaXplbiBUZXN0IENBMSMw
12-03 20:17:39.668+0900 D/rpm-installer( 7763): IQYDVQQLDBpUVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEpMCcGA1UEAwwgVGl6ZW4gUHVibGlj
12-03 20:17:39.668+0900 D/rpm-installer( 7763): IERpc3RyaWJ1dG9yIFJvb3QgQ0EwHhcNMTIxMDI5MTMwMjUwWhcNMjIxMDI3MTMwMjUwWjCBjzEL
12-03 20:17:39.668+0900 D/rpm-installer( 7763): MAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6
12-03 20:17:39.668+0900 D/rpm-installer( 7763): ZW4gVGVzdCBDQTEiMCAGA1UECwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwb
12-03 20:17:39.668+0900 D/rpm-installer( 7763): VGl6ZW4gUHVibGljIERpc3RyaWJ1dG9yIENBMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDe
12-03 20:17:39.668+0900 D/rpm-installer( 7763): OTS/3nXvkDEmsFCJIvRlQ3RKDcxdWJJp625pFqHdmoJBdV+x6jl1raGK2Y1sp2Gdvpjc/z92yzAp
12-03 20:17:39.668+0900 D/rpm-installer( 7763): bE/UVLPh/tRNZPeGhzU4ejDDm7kzdr2f7Ia0U98K+OoY12ucwg7TYNItj9is7Cj4blGfuMDzd2ah
12-03 20:17:39.668+0900 D/rpm-installer( 7763): 2AgnCGlwNwV/pv+uVQIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4GBACqJ
12-03 20:17:39.668+0900 D/rpm-installer( 7763): KO33YdoGudwanZIxMdXuxnnD9R6u72ltKk1S4zPfMJJv482CRGCI4FK6djhlsI4i0Lt1SVIJEed+
12-03 20:17:39.668+0900 D/rpm-installer( 7763): yc3qckGm19dW+4xdlkekon7pViEBWuyHw8OWv3RXtTum1+PGHjBJ2eYY4ZKIpz73U/1NC16sTB/0
12-03 20:17:39.668+0900 D/rpm-installer( 7763): VhfnkHwPl
12-03 20:17:39.668+0900 D/CERT_SVC( 7763): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem
12-03 20:17:39.668+0900 D/rpm-installer( 7763): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
12-03 20:17:39.668+0900 D/rpm-installer( 7763): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
12-03 20:17:39.668+0900 D/rpm-installer( 7763): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem]
12-03 20:17:39.688+0900 D/rpm-installer( 7763): rpm-installer.c: __ri_verify_file(336) > valid signature
12-03 20:17:39.688+0900 D/rpm-installer( 7763): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[908]
12-03 20:17:39.688+0900 D/rpm-installer( 7763): MIICozCCAgwCCQD9XW6kNg4bbjANBgkqhkiG9w0BAQUFADCBlTELMAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEjMCEGA1UECwwaVFRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKTAnBgNVBAMMIFRpemVuIFB1YmxpYyBEaXN0cmlidXRvciBSb290IENBMB4XDTEyMTAyNjA4MDAyN1oXDTIyMTAyNDA4MDAyN1owgZUxCzAJBgNVBAYTAktSMQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0ExIzAhBgNVBAsMGlRUaXplbiBEaXN0cmlidXRvciBUZXN0IENBMSkwJwYDVQQDDCBUaXplbiBQdWJsaWMgRGlzdHJpYnV0b3IgUm9vdCBDQTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA8o0kPY1U9El1BbBUF1k4jCq6mH8a6MmDJdjgsz+hILAYsPWimRTXUcW8GAUWhZWgm1Fbb49xWcasA8b4bIJabC/6hLb8uWiozzpRXyQJbe7k//RocskRqDmFOky8ANFsCCww72/Xbq8BFK1sxlGdmOWQiGwDWBDlS2Lw1XOMqb0CAwEAATANBgkqhkiG9w0BAQUFAAOBgQBUotZqTNFr+SNyqeZqhOToRsg3ojN1VJUa07qdlVo5I1UObSE+UTJPJ0NtSj7OyTY7fF3E4xzUv/w8aUoabQP1erEmztY/AVD+phHaPytkZ/Dx+zDZ1u5e9bKm5zfY4dQs/A53zDQta5a/NkZOEF97Dj3+bzAh2bP7KOszlocFYw==
12-03 20:17:39.688+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.ddrgame/signature1.xml) succeed.
12-03 20:17:39.688+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
12-03 20:17:39.688+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(7763), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(60)
12-03 20:17:39.688+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(7763), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(60)
12-03 20:17:39.688+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
12-03 20:17:39.688+0900 D/PKGMGR_INSTALLER( 7763): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.ddrgame] key[install_percent] value[60]
12-03 20:17:39.688+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(7763), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(60)
12-03 20:17:39.688+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(7763), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(60)
12-03 20:17:39.688+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
12-03 20:17:39.688+0900 E/PKGMGR_CERT( 7763): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
12-03 20:17:39.688+0900 D/PKGMGR  ( 3118): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 E/PKGMGR_CERT( 7763): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 16
12-03 20:17:39.688+0900 E/PKGMGR_CERT( 7763): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 16
12-03 20:17:39.688+0900 E/PKGMGR_CERT( 7763): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 1
12-03 20:17:39.688+0900 E/PKGMGR_CERT( 7763): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 7 4
12-03 20:17:39.688+0900 E/PKGMGR_CERT( 7763): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 8 4
12-03 20:17:39.688+0900 E/PKGMGR_CERT( 7763): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 9 4
12-03 20:17:39.688+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 D/DATA_PROVIDER_MASTER( 2962): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.ddrgame] 60
12-03 20:17:39.688+0900 D/PKGMGR  ( 3065): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 D/QUICKPANEL( 2963): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.ddrgame key:install_percent val:60
12-03 20:17:39.688+0900 D/PKGMGR  ( 7758): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 W/cluster-home( 2908): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.ddrgame]
12-03 20:17:39.688+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29080003] pkg_type[tpk] package[org.example.ddrgame] key[install_percent] val[60] pmsg[(null)]
12-03 20:17:39.688+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 D/PKGMGR  ( 2985): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
12-03 20:17:39.688+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[60]
12-03 20:17:39.688+0900 D/ESD     ( 2959): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29590002), pkg_type(tpk), pkgid(org.example.ddrgame), key(install_percent), val(60)
12-03 20:17:39.698+0900 E/PKGMGR_CERT( 7763): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
12-03 20:17:39.698+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.ddrgame), result=[0]
12-03 20:17:39.698+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.ddrgame), result=[0]
12-03 20:17:39.698+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame, 5, _), result=[0]
12-03 20:17:39.698+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/shared, 5, _), result=[0]
12-03 20:17:39.698+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/shared/res, 5, _), result=[0]
12-03 20:17:39.698+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/shared/data, 2), result=[0]
12-03 20:17:39.698+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.ddrgame/shared/data], label=[$1$org.exam$aAnh6.J7RR0Vvi7oaShJf0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.ddrgame/shared/cache], label=[$1$org.exam$aAnh6.J7RR0Vvi7oaShJf0]
12-03 20:17:39.708+0900 E/rpm-installer( 7763): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [a+ff#XX4vz2m4AI3lzpSRp5k2z4=] for shared/trusted.
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/shared/trusted, 1, a+ff#XX4vz2m4AI3lzpSRp5k2z4=), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/bin, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/data, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/lib, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/res, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/cache, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/tizen-manifest.xml, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/author-signature.xml, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/usr/apps/org.example.ddrgame/signature1.xml, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.ddrgame, /opt/share/packages/org.example.ddrgame.xml, 0, org.example.ddrgame), result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.ddrgame] version set to [2.4] result=[0]
12-03 20:17:39.708+0900 D/rpm-installer( 7763): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
12-03 20:17:39.718+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.ddrgame, 7), result=[0]
12-03 20:17:39.718+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(7763), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(100)
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(7763), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(100)
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
12-03 20:17:39.718+0900 D/PKGMGR_INSTALLER( 7763): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.ddrgame] key[install_percent] value[100]
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(7763), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(100)
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(7763), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(install_percent), val(100)
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
12-03 20:17:39.718+0900 D/rpm-installer( 7763): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.ddrgame) is done.
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(7763), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(end), val(ok)
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(7763), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(end), val(ok)
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
12-03 20:17:39.718+0900 D/PKGMGR_INSTALLER( 7763): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.ddrgame] key[end] value[ok]
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(7763), zone(host), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(end), val(ok)
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(7763), pkg_typ(tpk), pkg_id(org.example.ddrgame), key(end), val(ok)
12-03 20:17:39.718+0900 D/PKGMGR  ( 7763): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
12-03 20:17:39.718+0900 D/PKGMGR  ( 3118): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.718+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.718+0900 D/DATA_PROVIDER_MASTER( 2962): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.ddrgame] 100
12-03 20:17:39.718+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.718+0900 D/QUICKPANEL( 2963): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.ddrgame key:install_percent val:100
12-03 20:17:39.718+0900 D/PKGMGR  ( 3065): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.718+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.718+0900 W/cluster-home( 2908): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.ddrgame]
12-03 20:17:39.718+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.718+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29080003] pkg_type[tpk] package[org.example.ddrgame] key[install_percent] val[100] pmsg[(null)]
12-03 20:17:39.718+0900 D/PKGMGR  ( 3118): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.718+0900 D/PKGMGR  ( 7758): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.718+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 D/DATA_PROVIDER_MASTER( 2962): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.ddrgame] ok
12-03 20:17:39.718+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.ddrgame], event_type[1]
12-03 20:17:39.718+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
12-03 20:17:39.718+0900 D/PKGMGR  ( 7758): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 D/PKGMGR  ( 2992): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 D/PKGMGR  ( 3065): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 D/ISF_PANEL_EFL( 3065): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.ddrgame event_type=UPDATE event_state=COMPLETED progress=100 error=0
12-03 20:17:39.718+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
12-03 20:17:39.718+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
12-03 20:17:39.718+0900 D/DATA_PROVIDER_MASTER( 2962): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.ddrgame]
12-03 20:17:39.718+0900 D/PKGMGR  ( 2963): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 D/QUICKPANEL( 2963): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.ddrgame key:end val:ok
12-03 20:17:39.718+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 W/cluster-home( 2908): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.ddrgame]
12-03 20:17:39.718+0900 D/cluster-home( 2908): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.ddrgame]
12-03 20:17:39.718+0900 D/PKGMGR  ( 2908): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29080003] pkg_type[tpk] package[org.example.ddrgame] key[end] val[ok] pmsg[(null)]
12-03 20:17:39.718+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
12-03 20:17:39.718+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
12-03 20:17:39.718+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
12-03 20:17:39.718+0900 D/PKGMGR  ( 2802): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.718+0900 D/AUL_AMD ( 2802): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.ddrgame), key(end), value(ok)
12-03 20:17:39.718+0900 W/AUL_AMD ( 2802): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
12-03 20:17:39.728+0900 D/AUL_AMD ( 2802): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.ddrgame, type:rpm
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.ddrgame]
12-03 20:17:39.728+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.ddrgame]
12-03 20:17:39.728+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.ddrgame]
12-03 20:17:39.728+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
12-03 20:17:39.728+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
12-03 20:17:39.728+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.ddrgame]
12-03 20:17:39.728+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.728+0900 D/PKGMGR  ( 2985): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
12-03 20:17:39.728+0900 D/PKGMGR  ( 2985): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.728+0900 D/PKGMGR  ( 2985): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
12-03 20:17:39.728+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[install_percent], value=[100]
12-03 20:17:39.728+0900 D/ESD     ( 2959): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29590002), pkg_type(tpk), pkgid(org.example.ddrgame), key(install_percent), val(100)
12-03 20:17:39.728+0900 D/PKGMGR  ( 2959): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.ddrgame_869789768], pkg_type=[tpk], pkgid=[org.example.ddrgame], key=[end], value=[ok]
12-03 20:17:39.728+0900 D/ESD     ( 2959): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29590002), pkg_type(tpk), pkgid(org.example.ddrgame), key(end), val(ok)
12-03 20:17:39.728+0900 D/ESD     ( 2959): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
12-03 20:17:39.728+0900 W/ISF_PANEL_EFL( 3065): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
12-03 20:17:39.728+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.ddrgame] Name[ddrgame] Icon[/opt/usr/apps/org.example.ddrgame/shared/res/ddrgame.png] enable[1] system[0]
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.ddrgame]
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.ddrgame
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.ddrgame], name[ddrgame], menuId[1], isPreload[0] isPreload[0]
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
12-03 20:17:39.728+0900 E/cluster-home( 2908): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.ddrgame] Name[ddrgame] Icon[/opt/usr/apps/org.example.ddrgame/shared/res/ddrgame.png] enable[1] system[0]
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [ddrgame]
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
12-03 20:17:39.728+0900 D/test-log( 2908): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.ddrgame/shared/res/ddrgame.png], New icon path[/opt/usr/apps/org.example.ddrgame/shared/res/ddrgame.png]!!!!!
12-03 20:17:39.728+0900 D/cluster-home( 2908): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
12-03 20:17:39.998+0900 D/rpm-installer( 7763): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
12-03 20:17:39.998+0900 D/rpm-installer( 7763): rpm-appcore-intf.c: main(259) > ------------------------------------------------
12-03 20:17:39.998+0900 D/rpm-installer( 7763): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
12-03 20:17:39.998+0900 D/rpm-installer( 7763): rpm-appcore-intf.c: main(261) > ------------------------------------------------
12-03 20:17:39.998+0900 D/PKGMGR_SERVER( 7760): pkgmgr-server.c: sighandler(387) > child exit [7763]
12-03 20:17:39.998+0900 E/PKGMGR_SERVER( 7760): pkgmgr-server.c: sighandler(402) > child NORMAL exit [7763]
12-03 20:17:41.648+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(838) > __request_handler: 0
12-03 20:17:41.648+0900 D/AUL_AMD ( 2802): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.ddrgame
12-03 20:17:41.648+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 20:17:41.648+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
12-03 20:17:41.658+0900 I/AUL     ( 2802): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
12-03 20:17:41.658+0900 D/AUL     ( 2802): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 7813, pid = 7815
12-03 20:17:41.658+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 20:17:41.658+0900 D/PKGMGR_INFO( 2802): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
12-03 20:17:41.658+0900 I/AUL     ( 2802): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
12-03 20:17:41.658+0900 E/AUL_AMD ( 2802): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
12-03 20:17:41.658+0900 W/AUL_AMD ( 2802): amd_launch.c: _start_app(2233) > caller pid : 7815
12-03 20:17:41.658+0900 E/AUL_AMD ( 2802): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
12-03 20:17:41.658+0900 W/AUL_AMD ( 2802): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.ddrgame) pkgid(org.example.ddrgame) attribute(600)
12-03 20:17:41.658+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2648) > process_pool: false
12-03 20:17:41.658+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
12-03 20:17:41.658+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.ddrgame
12-03 20:17:41.658+0900 W/AUL_AMD ( 2802): amd_launch.c: _start_app(2665) > pad pid(-5)
12-03 20:17:41.658+0900 D/AUL_AMD ( 2802): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
12-03 20:17:41.658+0900 D/AUL_AMD ( 2802): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
12-03 20:17:41.658+0900 D/AUL     ( 2802): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.ddrgame
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
12-03 20:17:41.658+0900 W/AUL_PAD ( 2960): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
12-03 20:17:41.658+0900 D/AUL     ( 2960): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 7610, bin path: /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 20:17:41.658+0900 W/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(265) > Check app launching
12-03 20:17:41.658+0900 D/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
12-03 20:17:41.658+0900 D/RESOURCED( 2896): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.ddrgame, pkgid = org.example.ddrgame, flags = 1536
12-03 20:17:41.658+0900 D/RESOURCED( 2896): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.ddrgame, pkgname = org.example.ddrgame, ref = 1
12-03 20:17:41.658+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
12-03 20:17:41.658+0900 E/RESOURCED( 2896): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
12-03 20:17:41.658+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
12-03 20:17:41.658+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.ddrgame, launchpad type: 0
12-03 20:17:41.658+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
12-03 20:17:41.658+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.ddrgame
12-03 20:17:41.658+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.ddrgame
12-03 20:17:41.658+0900 D/AUL     ( 7610): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (7628) is sent.
12-03 20:17:41.658+0900 D/AUL     ( 7610): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 7628, signo: 10
12-03 20:17:41.668+0900 D/AUL     ( 7610): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.ddrgame / pkg_type : rpm / app_path : /opt/usr/apps/org.example.ddrgame/bin/ddrgame
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.ddrgame/bin/ddrgame##
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0ODA3NjM4NjEvNjU5MDY4AA==##
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA3ODE1AA==##
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.ddrgame/bin/ddrgame, real app argc: 8
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
12-03 20:17:41.668+0900 D/AUL_PAD ( 7610): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.ddrgame/bin/ddrgame)
12-03 20:17:41.668+0900 I/CAPI_APPFW_APPLICATION( 7610): app_main.c: ui_app_main(788) > app_efl_main
12-03 20:17:41.668+0900 D/LAUNCH  ( 7610): appcore-efl.c: appcore_efl_main(1692) > [ddrgame:Application:main:done]
12-03 20:17:41.668+0900 D/APP_CORE( 7610): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
12-03 20:17:41.668+0900 D/APP_CORE( 7610): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.ddrgame/res/locale
12-03 20:17:41.668+0900 D/APP_CORE( 7610): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
12-03 20:17:41.678+0900 D/APP_CORE( 7610): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
12-03 20:17:41.678+0900 D/AUL     ( 7610): app_sock.c: __create_server_sock(156) > pg path - already exists
12-03 20:17:41.678+0900 D/APP_CORE( 7610): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4228520
12-03 20:17:41.678+0900 D/LAUNCH  ( 7610): appcore-efl.c: __before_loop(1136) > [ddrgame:Platform:appcore_init:done]
12-03 20:17:41.678+0900 I/CAPI_APPFW_APPLICATION( 7610): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
12-03 20:17:41.728+0900 E/EFL     ( 7610): eo<7610> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 20:17:41.728+0900 E/EFL     ( 7610): eo<7610> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 20:17:41.728+0900 E/EFL     ( 7610): eo<7610> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 20:17:41.728+0900 E/EFL     ( 7610): eo<7610> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 20:17:41.738+0900 E/EFL     ( 7610): eo<7610> lib/eo/eo.c:676 _eo_call_resolve() in elm_container.eo.c:1: func 'elm_obj_container_content_set' (1011) could not be resolved for class 'Elm_Box'.
12-03 20:17:41.758+0900 D/AUL_PAD ( 2960): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
12-03 20:17:41.758+0900 W/AUL     ( 2802): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7610, appid: org.example.ddrgame
12-03 20:17:41.758+0900 D/AUL     ( 2802): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
12-03 20:17:41.758+0900 E/AUL     ( 2802): simple_util.c: __trm_app_info_send_socket(330) > access
12-03 20:17:41.758+0900 D/AUL_AMD ( 2802): amd_launch.c: _start_app(2700) > add app group info
12-03 20:17:41.758+0900 E/AUL     ( 2802): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
12-03 20:17:41.758+0900 D/AUL_AMD ( 2802): amd_status.c: _status_add_app_info_list(427) > pid(7610) appid(org.example.ddrgame) pkgid(org.example.ddrgame) comp(uiapp)
12-03 20:17:41.768+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.ddrgame, 7610
12-03 20:17:41.768+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.ddrgame with pkgname
12-03 20:17:41.768+0900 E/RESOURCED( 2896): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.ddrgame
12-03 20:17:41.768+0900 D/RESOURCED( 2896): proc-main.c: resourced_proc_status_change(888) > available memory = 318
12-03 20:17:41.808+0900 W/CRASH_MANAGER( 7820): worker.c: worker_job(1204) > 1107610646472148076386
