# docs/ref/contrib/gis/measure

- Subject: docs/ref/contrib/gis/measure (id `bab24a7f-a154-4c13-963f-acb7797d4a4b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 37 of 58
- Conflicts: 0
- Gaps: 0

## Facts

- >>> Area.unit_attname("Kilometer") 'sq_km' [881141e6]
- >>> Distance.unit_attname("Mile") 'mi' [2aec5760]
- >>> a = Area(sq_mi=5) [8d4ecbf5]
- >>> dist = Distance(mi=5) [5a504056]
- >>> print(a.sq_km) 12.949940551680001 [b062e5ca]
- >>> print(dist.km) 8.04672 [e96948d9]
- .. classmethod:: unit_attname(unit_name) [557f664a3d8bb114]
- .. code-block:: pycon [eaf050be34acb41d-180]
- .. code-block:: pycon [eaf050be34acb41d-181]
- .. code-block:: pycon [eaf050be34acb41d-182]
- .. code-block:: pycon [eaf050be34acb41d-183]
- .. code-block:: pycon [eaf050be34acb41d-184]
- .. code-block:: pycon [eaf050be34acb41d-185]
- .. method:: __getattr__(unit_att) [11db7f966e689f45]
- :class:`Area` attributes are the same as :class:`Distance` attributes, except they are prefixed with ``sq_`` (area units are square in nature). For example, ``Area(sq_m=2)`` creates an :class:`Area` object representing two square meters. [c17eced3]
- >>> a = d1 * d2 # Returns an Area object. >>> print(a) 40.2336 sq_km [8b4f79b2]
- >>> from django.contrib.gis.measure import D, Distance >>> d1 = Distance(km=5) >>> print(d1) 5.0 km >>> d2 = D(mi=5) # `D` is an alias for `Distance` >>> print(d2) 5.0 mi [7d49912d]
- >>> print(Distance.unit_attname("US Survey Foot")) survey_ft >>> print(Distance.unit_attname("centimeter")) cm [d2897b56]
- >>> print(d1 + d2) # Adding 5 miles to 5 kilometers 13.04672 km >>> print(d2 - d1) # Subtracting 5 kilometers from 5 miles 1.89314403881 mi [27d57c26]
- >>> print(d1.mi) # Converting 5 kilometers to miles 3.10685596119 >>> print(d2.km) # Converting 5 miles to kilometers 8.04672 [8e4787b5]
- Alias for :class:`Area` class. [c5a1527d]
- Alias for :class:`Distance` class. [3eaf5ccd]
- Returns the area unit attribute name for the given full unit name. For example: [a282f1e9]
- Returns the area value in units corresponding to the given unit attribute. For example: [c084d803]
- Returns the distance unit attribute name for the given full unit name. For example: [d3271c6d]
- To initialize a distance object, pass in a keyword corresponding to the desired :ref:`unit attribute name <supported_units>` set with desired value. For example, the following creates a distance object representing 5 miles: [5177501b]
- .. _supported_units: [560602fd]
- .. class:: A [1bb9c9ac]
- .. class:: Area(**kwargs) [b667acbb]
- .. class:: D [7ac6b494]
- .. class:: Distance(**kwargs) [16ba3b93]
- .. code-block:: pycon [eaf050be34acb41d-186]
- .. code-block:: pycon [eaf050be34acb41d-187]
- .. code-block:: pycon [eaf050be34acb41d-188]
- .. code-block:: pycon [eaf050be34acb41d-189]
- .. code-block:: pycon [eaf050be34acb41d-190]
- .. note:: [942ae6c11625c81c-67]

## Beyond the budget

17 more facts did not fit in the budget: [0ddb1ce0] [a61db341] [c5a6cace] [50faf2ea] [f26c1131] [71004870] [cf1461d9a1a7899c-4] [aac72aa3] [43caa976] [7751429d] [4c6af0be] [31bea3fc] [f8d8eb61] [03a424f2] [bfbb5db8] [e2ef116ba2a404b8-2] [4d4bf744e1be7be5-2]
