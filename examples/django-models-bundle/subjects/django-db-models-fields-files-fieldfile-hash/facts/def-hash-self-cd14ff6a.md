# Fact cd14ff6a

Store id: 56fffd47-78e9-48ee-994a-105b839adebc

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T22:39:43.1872470+00:00`

## Data

```json
{
  "end_line": 35,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 34,
  "symbol": "FieldFile.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"selector":"L34-L35","symbol":"FieldFile.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 35,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 34,
    "symbol": "FieldFile.__hash__"
  },
  "id": "56fffd47-78e9-48ee-994a-105b839adebc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.1872470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 34,
        "selector": "L34-L35",
        "symbol": "FieldFile.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "0ffbb96d-773b-4cf4-b4e2-a61b5757f0b4",
  "subject_name": "django/db/models/fields/files::FieldFile.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
