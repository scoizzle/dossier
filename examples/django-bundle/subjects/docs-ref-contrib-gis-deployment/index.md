# docs/ref/contrib/gis/deployment

- Subject: docs/ref/contrib/gis/deployment (id `fe45d6d4-d009-4fc2-a16f-0865bf3b004b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 236 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- For example, when configuring your application with ``mod_wsgi``, set the ``WSGIDaemonProcess`` attribute ``threads`` to ``1``, unless Apache may crash when running your GeoDjango application. Increase the number of ``processes`` instead. [94d7a98f]
- GeoDjango uses the GDAL geospatial library which is not thread safe at this time. Thus, it is *highly* recommended to not use threading when deploying -- in other words, use an appropriate configuration of Apache. [d141c7ab]
- .. warning:: [c54b54cb0805732a-21]
- =================== Deploying GeoDjango =================== [1d5bbe79]
- Basically, the deployment of a GeoDjango application is not different from the deployment of a normal Django application. Please consult Django's :doc:`deployment documentation </howto/deployment/index>`. [19c9a02e]
