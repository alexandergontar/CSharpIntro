<h3>Простой WMI агент </h3>
Собирает общую информацию о РС и его
дисках (размер, свободное место).
Основная логика в файле BL.cs
Интерфейс IPcmanager собирает информацию
о PC и дисках, модель данных в классах
PC.cs и Disk.cs. Потом информация сериализуется
в JSON формат.  Интерфейс IClient отпарвляет полученную 
JSON строку запросом http Post на тестовую бесплатную 
WebAPI, получает ответ и выводит его в консоль.

Ниже пример консольного вывода:


C:  254238171136  42884968448
Computer Name : WPET-W10-P10112
Windows Directory : C:\WINDOWS
Operating System: Microsoft Windows 10 Enterprise
Version: 10.0.19044
Manufacturer : Microsoft Corporation

 ===== JSON data ===== :
{"PcInfo":"Computer Name : WPET-W10-P10112\nWindows Directory : C:\\WINDOWS\nOperating System: Microsoft Windows 10 Enterprise\nVersion: 10.0.19044\nManufacturer : Microsoft Corporation\n","Disks":[{"DiskName":"C:","VolumeSize":254238171136,"FreeSpace":42884968448}],"PcItems":["Computer Name : WPET-W10-P10112\n","Windows Directory : C:\\WINDOWS\n","Operating System: Microsoft Windows 10 Enterprise\n","Version: 10.0.19044\n","Manufacturer : Microsoft Corporation\n"]}

 ===== Post JSON data, waiting for response ....

{
  "args": {},
  "data": "{\"PcInfo\":\"Computer Name : WPET-W10-P10112\\nWindows Directory : C:\\\\WINDOWS\\nOperating System: Microsoft Windows 10 Enterprise\\nVersion: 10.0.19044\\nManufacturer : Microsoft Corporation\\n\",\"Disks\":[{\"DiskName\":\"C:\",\"VolumeSize\":254238171136,\"FreeSpace\":42884968448}],\"PcItems\":[\"Computer Name : WPET-W10-P10112\\n\",\"Windows Directory : C:\\\\WINDOWS\\n\",\"Operating System: Microsoft Windows 10 Enterprise\\n\",\"Version: 10.0.19044\\n\",\"Manufacturer : Microsoft Corporation\\n\"]}",
  "files": {},
  "form": {},
  "headers": {
    "Content-Length": "470",
    "Content-Type": "application/json; charset=utf-8",
    "Host": "httpbin.org",
    "X-Amzn-Trace-Id": "Root=1-646dadae-2e054c100c8f700e4926b821"
  },
  "json": {
    "Disks": [
      {
        "DiskName": "C:",
        "FreeSpace": 42884968448,
        "VolumeSize": 254238171136
      }
    ],
    "PcInfo": "Computer Name : WPET-W10-P10112\nWindows Directory : C:\\WINDOWS\nOperating System: Microsoft Windows 10 Enterprise\nVersion: 10.0.19044\nManufacturer : Microsoft Corporation\n",
    "PcItems": [
      "Computer Name : WPET-W10-P10112\n",
      "Windows Directory : C:\\WINDOWS\n",
      "Operating System: Microsoft Windows 10 Enterprise\n",
      "Version: 10.0.19044\n",
      "Manufacturer : Microsoft Corporation\n"
    ]
  },
  "origin": "217.66.154.20",
  "url": "https://httpbin.org/post"
}