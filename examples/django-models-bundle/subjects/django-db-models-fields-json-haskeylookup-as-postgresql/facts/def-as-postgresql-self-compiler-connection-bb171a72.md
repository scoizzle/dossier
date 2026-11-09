# Fact bb171a72

Store id: df348e68-fa66-4aec-b579-c5a51d002f7f

## Text

```text
def as_postgresql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.6484020+00:00`

## Data

```json
{
  "end_line": 260,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 254,
  "symbol": "HasKeyLookup.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":254,"selector":"L254-L260","symbol":"HasKeyLookup.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 260,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 254,
    "symbol": "HasKeyLookup.as_postgresql"
  },
  "id": "df348e68-fa66-4aec-b579-c5a51d002f7f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6484020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 254,
        "selector": "L254-L260",
        "symbol": "HasKeyLookup.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "755cdb2e-7745-45a2-ba69-1222d6e25b6f",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection)"
}
```
