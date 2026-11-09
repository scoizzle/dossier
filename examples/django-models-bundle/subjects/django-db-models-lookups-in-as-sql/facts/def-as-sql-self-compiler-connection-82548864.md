# Fact 82548864

Store id: 64024ad4-e11c-4588-81e1-068b9b1378b5

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:55.0082260+00:00`

## Data

```json
{
  "end_line": 559,
  "entity_kind": "method",
  "parent": "In",
  "start_line": 551,
  "symbol": "In.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":551,"selector":"L551-L559","symbol":"In.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::In.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 559,
    "entity_kind": "method",
    "parent": "In",
    "start_line": 551,
    "symbol": "In.as_sql"
  },
  "id": "64024ad4-e11c-4588-81e1-068b9b1378b5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0082260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 551,
        "selector": "L551-L559",
        "symbol": "In.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f9e84ab0-4a41-423f-b8cb-197247448262",
  "subject_name": "django/db/models/lookups::In.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
