# Fact 3980886f

Store id: e0df2ece-5022-4c66-bb06-4c50784bc18d

## Text

```text
class BooleanField(Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.0521040+00:00`

## Data

```json
{
  "end_line": 1243,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1200,
  "symbol": "BooleanField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1200,"selector":"L1200-L1243","symbol":"BooleanField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BooleanField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1243,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1200,
    "symbol": "BooleanField"
  },
  "id": "e0df2ece-5022-4c66-bb06-4c50784bc18d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0521040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1200,
        "selector": "L1200-L1243",
        "symbol": "BooleanField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bf90735d-df6e-4929-936e-d4b6366e362e",
  "subject_name": "django/db/models/fields/__init__::BooleanField",
  "tags": [
    "entity:class"
  ],
  "text": "class BooleanField(Field)"
}
```
