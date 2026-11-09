# docs/ref/contrib/gis/measure

- Subject: docs/ref/contrib/gis/measure (id `c2ea7947-2aa1-4957-b913-16be4bb1a063`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1991 tokens
- Facts shown: 58 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- >>> Area.unit_attname("Kilometer") 'sq_km' [881141e6]
- >>> Distance.unit_attname("Mile") 'mi' [2aec5760]
- >>> a = Area(sq_mi=5) [8d4ecbf5]
- >>> dist = Distance(mi=5) [5a504056]
- >>> print(a.sq_km) 12.949940551680001 [b062e5ca]
- >>> print(dist.km) 8.04672 [e96948d9]
- .. classmethod:: unit_attname(unit_name) [557f664a3d8bb114]
- .. classmethod:: unit_attname(unit_name) [557f664a3d8bb114-2]
- .. code-block:: pycon [eaf050be34acb41d-180]
- .. code-block:: pycon [eaf050be34acb41d-181]
- .. code-block:: pycon [eaf050be34acb41d-182]
- .. code-block:: pycon [eaf050be34acb41d-183]
- .. code-block:: pycon [eaf050be34acb41d-184]
- .. code-block:: pycon [eaf050be34acb41d-185]
- .. method:: __getattr__(unit_att) [11db7f966e689f45]
- .. method:: __getattr__(unit_att) [11db7f966e689f45-2]
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
- Returns the distance value in units corresponding to the given unit attribute. For example: [3313f500]
- To initialize a distance object, pass in a keyword corresponding to the desired :ref:`unit attribute name <supported_units>` set with desired value. For example, the following creates a distance object representing 5 miles: [5177501b]
- To initialize an area object, pass in a keyword corresponding to the desired :ref:`unit attribute name <supported_units>` set with desired value. For example, the following creates an area object representing 5 square miles: [20de9f08]
- .. _supported_units: [560602fd]
- .. class:: A [1bb9c9ac]

## All facts

- [b667acbb] .. class:: Area(**kwargs)
- [7ac6b494] .. class:: D
- [16ba3b93] .. class:: Distance(**kwargs)
- [eaf050be34acb41d-186] .. code-block:: pycon
- [eaf050be34acb41d-187] .. code-block:: pycon
- [eaf050be34acb41d-188] .. code-block:: pycon
- [eaf050be34acb41d-189] .. code-block:: pycon
- [eaf050be34acb41d-190] .. code-block:: pycon
- [0ddb1ce0] .. module:: django.contrib.gis.measure :synopsis: GeoDjango's distance and area measurement objects.
- [942ae6c11625c81c-67] .. note::
- [a61db341] .. rubric:: Footnotes .. [#] `Robert Coup <https://koordinates.com/>`_ is the initial author of the measure objects, and was inspired by Brian Beck's work in `geopy <https://github.com/geopy/geopy/>`_ and Geoff Biggs' PhD work on dimensioned units for robotics.
- [c5a6cace] :class:`Distance` objects may be instantiated using a keyword argument indicating the context of the units. In the example below, two different distance objects are instantiated in units of kilometers (``km``) and miles (``mi``):
- [50faf2ea] =================== Measurement Objects ===================
- [f26c1131] ================================= ======================================== Unit Attribute Full name or alias(es) ================================= ======================================== ``ha`` Hectare ================================= ========================================
- [71004870] ================================= ======================================== Unit Attribute Full name or alias(es) ================================= ======================================== ``km`` Kilometre, Kilometer ``mi`` Mile ``m`` Meter, Metre ``yd`` Yard ``ft`` Foot, Foot (International) ``survey_ft`` U.S. Foot, US survey foot ``inch`` Inches ``cm`` Centimeter ``mm`` Millimetre, Millimeter ``um`` Micrometer, Micrometre ``british_ft`` British foot (Sears 1922) ``british_yd`` British yard (Sears 1922) ``british_chain_sears`` British chain (Sears 1922) ``indian_yd`` Indian yard, Yard (Indian) ``sears_yd`` Yard (Sears) ``clarke_ft`` Clarke's Foot ``chain`` Chain ``chain_benoit`` Chain (Benoit) ``chain_sears`` Chain (Sears) ``british_chain_benoit`` British chain (Benoit 1895 B) ``british_chain_sears_truncated`` British chain (Sears 1922 truncated) ``gold_coast_ft`` Gold Coast foot ``link`` Link ``link_benoit`` Link (Benoit) ``link_sears`` Link (Sears) ``clarke_link`` Clarke's link ``fathom`` Fathom ``rod`` Rod ``furlong`` Furlong, Furrow Long ``nm`` Nautical Mile ``nm_uk`` Nautical Mile (UK) ``german_m`` German legal metre ================================= ========================================
- [cf1461d9a1a7899c-4] Example =======
- [aac72aa3] For conversions, access the preferred unit attribute to get a converted distance quantity:
- [43caa976] In addition to unit with the ``sq_`` prefix, the following units are also supported on :class:`Area`:
- [7751429d] Measurement API ===============
- [4c6af0be] Moreover, arithmetic operations may be performed between the distance objects:
- [31bea3fc] Supported units ===============
- [f8d8eb61] The :mod:`django.contrib.gis.measure` module contains objects that allow for convenient representation of distance and area units of measure. [#]_ Specifically, it implements two objects, :class:`Distance` and :class:`Area` -- both of which may be accessed via the :class:`D` and :class:`A` convenience aliases, respectively.
- [03a424f2] To determine what the attribute abbreviation of a unit is, the ``unit_attname`` class method may be used:
- [bfbb5db8] Two :class:`Distance` objects multiplied together will yield an :class:`Area` object, which uses squared units of measure:
- [e2ef116ba2a404b8-2] ``Area`` --------
- [4d4bf744e1be7be5-2] ``Distance`` ------------
