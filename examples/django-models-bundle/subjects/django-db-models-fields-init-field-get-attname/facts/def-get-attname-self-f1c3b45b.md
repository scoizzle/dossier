# Fact f1c3b45b

Store id: 0ac3540b-cfd7-4c40-b811-4c84ccdc25bb

## Text

```text
def get_attname(self)
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
- posted_at: `2026-11-09T22:39:42.3374560+00:00`

## Data

```json
{
  "end_line": 1016,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1015,
  "symbol": "Field.get_attname"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1015,"selector":"L1015-L1016","symbol":"Field.get_attname"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_attname](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1016,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1015,
    "symbol": "Field.get_attname"
  },
  "id": "0ac3540b-cfd7-4c40-b811-4c84ccdc25bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3374560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1015,
        "selector": "L1015-L1016",
        "symbol": "Field.get_attname"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0b11d374-b939-4f92-a778-d0290bbacb88",
  "subject_name": "django/db/models/fields/__init__::Field.get_attname",
  "tags": [
    "entity:method"
  ],
  "text": "def get_attname(self)"
}
```
