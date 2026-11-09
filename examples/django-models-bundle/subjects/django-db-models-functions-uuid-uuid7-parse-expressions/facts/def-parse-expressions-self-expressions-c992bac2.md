# Fact c992bac2

Store id: 1091f02f-f308-4ec2-9e70-07e4490f9335

## Text

```text
def _parse_expressions(self, *expressions)
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
- posted_at: `2026-11-09T23:44:54.3242680+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "method",
  "parent": "UUID7",
  "start_line": 55,
  "symbol": "UUID7._parse_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":55,"selector":"L55-L58","symbol":"UUID7._parse_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID7._parse_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "method",
    "parent": "UUID7",
    "start_line": 55,
    "symbol": "UUID7._parse_expressions"
  },
  "id": "1091f02f-f308-4ec2-9e70-07e4490f9335",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.3242680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 55,
        "selector": "L55-L58",
        "symbol": "UUID7._parse_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "6c1fcbc2-37a0-48ed-a35a-d53c8a961e50",
  "subject_name": "django/db/models/functions/uuid::UUID7._parse_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def _parse_expressions(self, *expressions)"
}
```
