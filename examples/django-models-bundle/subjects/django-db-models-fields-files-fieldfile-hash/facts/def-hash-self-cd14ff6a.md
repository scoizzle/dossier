# Fact cd14ff6a

Store id: ccecf6d0-bf86-4721-bd92-ff4de22075d0

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
- posted_at: `2026-11-09T23:44:50.6159750+00:00`

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
  "id": "ccecf6d0-bf86-4721-bd92-ff4de22075d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6159750+00:00"
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
  "subject_id": "95fbd921-701f-4d36-90c4-bdcb4d0bada0",
  "subject_name": "django/db/models/fields/files::FieldFile.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
