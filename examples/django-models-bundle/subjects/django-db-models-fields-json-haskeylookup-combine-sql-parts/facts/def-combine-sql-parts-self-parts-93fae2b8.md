# Fact 93fae2b8

Store id: 81c3bfcd-6389-4d81-a195-4aa07c23a5dd

## Text

```text
def _combine_sql_parts(self, parts)
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
- posted_at: `2026-11-09T23:31:57.8833360+00:00`

## Data

```json
{
  "end_line": 220,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 216,
  "symbol": "HasKeyLookup._combine_sql_parts"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":216,"selector":"L216-L220","symbol":"HasKeyLookup._combine_sql_parts"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup._combine_sql_parts](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 220,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 216,
    "symbol": "HasKeyLookup._combine_sql_parts"
  },
  "id": "81c3bfcd-6389-4d81-a195-4aa07c23a5dd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8833360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 216,
        "selector": "L216-L220",
        "symbol": "HasKeyLookup._combine_sql_parts"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7705daa5-0322-4225-a446-4c044098b0d2",
  "subject_name": "django/db/models/fields/json::HasKeyLookup._combine_sql_parts",
  "tags": [
    "entity:method"
  ],
  "text": "def _combine_sql_parts(self, parts)"
}
```
