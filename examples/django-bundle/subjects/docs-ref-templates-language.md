# docs/ref/templates/language

- Subject: docs/ref/templates/language (id `684cbbde-629f-4113-9233-402be5f7d13f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 29 of 275
- Conflicts: 0
- Gaps: 0

## Facts

- <h2>Entry two</h2> <p>This is my second entry.</p> </div> </body> </html> [7c7d6e7d]
- <div id="content"> <h2>Entry one</h2> <p>This is my first entry.</p> [f7844abb]
- <div id="content"> {% block content %}{% endblock %} </div> </body> </html> [deac67b3]
- <h2>Editors</h2> {% for user in editors %} {% partial user-info %} {% endfor %} {% endblock %} [643af6ce]
- <ul> {% for athlete in athlete_list %} <li>{{ athlete.name }}</li> {% endfor %} </ul> [f4fc0f7bab0509f9-2]
- Nor this: {{ other_data }} {% autoescape on %} Auto-escaping applies again: {{ name }} {% endautoescape %} {% endautoescape %} [75e55e02]
- {% for k, v in defaultdict.items %} Do something with k and v here... {% endfor %} [afb63a04]
- {% if athlete_list %} Number of athletes: {{ athlete_list|length }} {% elif athlete_in_locker_room_list %} Athletes should be out of the locker room soon! {% else %} No athletes. {% endif %} [f03fd2c002ce73bb-2]
- {% if athlete_list|length > 1 %} Team: {% for athlete in athlete_list %} ... {% endfor %} {% else %} Athlete: {{ athlete_list.0.name }} {% endif %} [1296ac68]
- {{ value|default:"nothing" }} [8b7e163a0a87884d-2]
- {{ value|filesizeformat }} [54b5481de784a387-2]
- {{ value|length }} [6e1bd6743dc1e163-2]
- {% block content %} ... {% endblock content %} [be2f2d74]
- {% if change_title %} {% block title %}Hello!{% endblock title %} {% endif %} [2d4bf4c1]
- {% translate "Title" as title %} {% block content %}{{ title }}{% endblock %} [a028e626]
- * Dictionary lookup * Attribute or method lookup * Numeric index lookup [41b10868]
- .. code-block:: html+django [685d15dfb6eb2285-265]
- :doc:`The Templates Reference </ref/templates/index>` Covers built-in tags, built-in filters, using an alternative template language, and more. [a275e2aa]
- <!DOCTYPE html> <html lang="en"> <head> <link rel="stylesheet" href="style.css"> <title>My amazing blog</title> </head> [f4052435]
- <!DOCTYPE html> <html lang="en"> <head> <link rel="stylesheet" href="style.css"> <title>{% block title %}My amazing site{% endblock %}</title> </head> [1a22eba3]
- <b>username [99372d0d]
- <body> <div id="sidebar"> <ul> <li><a href="/">Home</a></li> <li><a href="/blog/">Blog</a></li> </ul> </div> [624d71de]
- <body> <div id="sidebar"> {% block sidebar %} <ul> <li><a href="/">Home</a></li> <li><a href="/blog/">Blog</a></li> </ul> {% endblock %} </div> [5e1adff0]
- <h1>This &amp; that</h1> <b>Hello!</b> [7f51462c]
- <script>alert('hello')</script> [d3d26f19]
- Auto-escaping is on by default. Hello {{ name }} [7cfb4de6]
- Because dictionary lookup happens first, that behavior kicks in and provides a default value instead of using the intended ``.items()`` method. In this case, consider converting to a dictionary first. [70308324]
- Hello, <b>username [26a824f9]
- Hello, {{ name }} [e0618213]

## Beyond the budget

205 more facts did not fit in the budget: [024e35fea9218591] [ae21a9e6] [419a933961c34d87-2] [f806d6e3] [e4e899d7] [fab1652f] [0a7a47fd] [d2cbe934] [a6c13d7a] [0b89d747] [676a8675] [f666c567] [652a5a76e4b2dc7a] [58f03f8b] [9b1ba8df] [696e3965] [2750f03c] [dbbef8a6] [dda03afd] [f0facff9] [84e6c8cc] [eed1a4b0] [73452fb0] [c9576a7e] [2a0f7c95] [0666709e] [24efc8de] [8d05c5a1] [063692ad] [d31bc6fc] [8117379c] [76b99195] [0a6c70ed0cb3c3fb-6] [2cd10847] [6cbfa189] [afbf1ecc] [f7338aa1] [5305aa93] [dec424a0] [500a4a3bf5772a1b-2] [818b95d8] [068c8998] [a249201a] [f167952c] [7779432c] [21d96842] [aa4b4ffc] [6eac78d3] [3a13c3db] [1738875e] [00c8858c] [4d174882] [8487877f] [599677a0] [03212c70] [6d31d417] [5c213d5a] [6d3eb4df] [952bd31a] [744c53e2] [17c68b05] [4f256904] [a1619b62] [c1f68f8f2b188343-2] [ad3564bd] [7dcc9bc0] [1ee3ac30] [80adc708] [210215c0] [324e0f1f] [6c494cd1] [2f7e4c2e] [b4d96615] [18cb0f2a] [e68225db] [8aa20e98] [6aeec3ab63d3bfd4-3] [50bed6e0d454902f-5] [50bed6e0d454902f-6] [f1634b861a77cfdb-20] [ba063aebe37527ec] [78682175] [3ad6730c] [6e5c274d] [c6853e96] [6b4a5e54e001d097-27] [6b4a5e54e001d097-28] [6b4a5e54e001d097-29] [a1eb26d754a3d60c-38] [2ec0f12b] [39f09d26] [2cf79dcd] [db96f1e1] [eb92fdf6] [917a4b7a] [587b6587] [f9983ce9] [0f9b5e7c] [5389722e] [dc4d8077] [ffb7d0bf] [af20adf0] [2f9ba310] [d807a428] [c43ce1b9] [acfe8cd9] [74b77b4c] [97e8eb2b] [c65747a0] [b236da2d] [9e144f45] [2a78a8eb] [05c27985] [8bda6248] [a7690e73] [bb7dc8ca] [e1e7684b] [b15d09cc] [6defe5a3] [880e4c0e] [7663529b] [36400274] [c24be3e6] [3c89f178] [776ba907] [73d54527] [55e9dd07] [9ef2d06d] [271f13d7] [4cac6935] [035b71fe] [308bfedf] [8aef7804] [1bcf0bb2] [d61002d1] [42814bd3] [311ee15a] [9a20bc7a] [9f81b8e4] [84a09386] [59b300b0] [4c56f9d8] [e149cad7] [a6dd5c13] [6b467563] [08ff750f] [fb87b370] [838f58b8] [b86948ff] [5f1236b1] [0dd826c9] [f3e9c59f] [9b083eaf] [78bacb38] [4af47334] [059af285478e7ee4-2] [50bb06b6] [69ef43f6] [0ca3060a] [be1c7a81] [599487cd] [b366b6e6] [7c1eadd7] [32cce9a4ed33af09-2] [dfc7a76d] [d1d2d63f] [7ddbd04f] [0b7c0c39] [b883a7a0] [00d48a95] [1e5661eb] [50b4735ad9254de8] [231ac37b] [eb800b0f] [ae1b9684] [53916d89] [048386f7] [7f61ceba] [c1df33fb] [a5a0b956] [58acc688] [67908b39] [c80abe0c] [aa56b56a] [8ade2878] [74870081] [47ed946c] [bc466035] [224214ba] [637528fe] [91a05bb2] [853c5007] [7d0b5d30dab82953] [c776e209] [81311a22] [ca9c85a3] [be93f045] [aca6193d] [4fc6c657] [ccc3a3b8] [381ef10b] [949b4c20] [2ef9086c] [390a2eba] [5c14562b]
