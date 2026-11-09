# Fact b98b6400

Store id: 3381410a-7cbc-4f19-bf3f-73f74b5d9ec7

## Text

```text
def names(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.2992790+00:00`

## Data

```json
{
  "end_line": 38,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 35,
  "symbol": "ChoicesType.names"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L38","symbol":"ChoicesType.names"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.names](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 38,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 35,
    "symbol": "ChoicesType.names"
  },
  "id": "3381410a-7cbc-4f19-bf3f-73f74b5d9ec7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.2992790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L38",
        "symbol": "ChoicesType.names"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "1cae226c-2488-490d-b962-f5a367aeb4de",
  "subject_name": "django/db/models/enums::ChoicesType.names",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def names(cls)"
}
```
