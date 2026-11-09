# Fact 06dbe375

Store id: 5c9473cd-4033-4442-9e0b-9d2e7e20e250

## Text

```text
def __init__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.9931820+00:00`

## Data

```json
{
  "end_line": 76,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 53,
  "symbol": "CompositePrimaryKey.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":53,"selector":"L53-L76","symbol":"CompositePrimaryKey.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 76,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 53,
    "symbol": "CompositePrimaryKey.__init__"
  },
  "id": "5c9473cd-4033-4442-9e0b-9d2e7e20e250",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9931820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 53,
        "selector": "L53-L76",
        "symbol": "CompositePrimaryKey.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "fc6e5a49-5852-45cf-86c3-e1e1d5514fa5",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
