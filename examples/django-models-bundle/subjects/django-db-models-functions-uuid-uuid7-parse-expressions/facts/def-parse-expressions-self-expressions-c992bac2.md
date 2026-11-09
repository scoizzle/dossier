# Fact c992bac2

Store id: 676f98b2-7016-4ab0-a2fc-11d901a6550c

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
- posted_at: `2026-11-09T22:39:47.3821440+00:00`

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
  "id": "676f98b2-7016-4ab0-a2fc-11d901a6550c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3821440+00:00"
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
  "subject_id": "dfec22de-909b-4298-bc70-ac4b038da7f9",
  "subject_name": "django/db/models/functions/uuid::UUID7._parse_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def _parse_expressions(self, *expressions)"
}
```
