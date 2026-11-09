# Fact 905ff9c6

Store id: f2232312-90bf-4f89-ae43-b1d31d76263c

## Text

```text
def values(cls)
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
- posted_at: `2026-11-09T23:31:55.5036470+00:00`

## Data

```json
{
  "end_line": 51,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 49,
  "symbol": "ChoicesType.values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L51","symbol":"ChoicesType.values"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 51,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 49,
    "symbol": "ChoicesType.values"
  },
  "id": "f2232312-90bf-4f89-ae43-b1d31d76263c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.5036470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L51",
        "symbol": "ChoicesType.values"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "bc4d3d8c-37c6-4c0d-a5b1-634ecdeced5b",
  "subject_name": "django/db/models/enums::ChoicesType.values",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def values(cls)"
}
```
