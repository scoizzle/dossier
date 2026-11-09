# Fact fb271a44

Store id: f2490ade-9a7f-4eb0-86fe-86112dc230df

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T22:39:42.2993740+00:00`

## Data

```json
{
  "end_line": 720,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 714,
  "symbol": "Field.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":714,"selector":"L714-L720","symbol":"Field.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 720,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 714,
    "symbol": "Field.__eq__"
  },
  "id": "f2490ade-9a7f-4eb0-86fe-86112dc230df",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2993740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 714,
        "selector": "L714-L720",
        "symbol": "Field.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b518db29-780d-44f7-ab98-03e8d5ee41b5",
  "subject_name": "django/db/models/fields/__init__::Field.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
