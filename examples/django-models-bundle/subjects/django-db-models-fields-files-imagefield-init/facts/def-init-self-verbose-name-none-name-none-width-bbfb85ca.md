# Fact bbfb85ca

Store id: 695eb5a8-36ed-4542-8f69-696fe128ba50

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
- posted_at: `2026-11-09T22:39:43.2651440+00:00`

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
  "id": "695eb5a8-36ed-4542-8f69-696fe128ba50",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2651440+00:00"
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
  "subject_id": "b656de9e-1b9a-44e5-b11c-7369ebea6ddc",
  "subject_name": "django/db/models/fields/files::ImageField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, width_field=None, height_field=None, **kwargs, )"
}
```
