# Fact bbfb85ca

Store id: d09e7ecb-11c3-42eb-b3b9-126abef50f6f

## Text

```text
def __init__( self, verbose_name=None, name=None, width_field=None, height_field=None, **kwargs, )
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.4332350+00:00`

## Data

```json
{
  "end_line": 434,
  "entity_kind": "method",
  "parent": "ImageField",
  "start_line": 425,
  "symbol": "ImageField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":425,"selector":"L425-L434","symbol":"ImageField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 434,
    "entity_kind": "method",
    "parent": "ImageField",
    "start_line": 425,
    "symbol": "ImageField.__init__"
  },
  "id": "d09e7ecb-11c3-42eb-b3b9-126abef50f6f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4332350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 425,
        "selector": "L425-L434",
        "symbol": "ImageField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "6b9243e6-1455-43f0-b267-160be1894bfb",
  "subject_name": "django/db/models/fields/files::ImageField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, width_field=None, height_field=None, **kwargs, )"
}
```
