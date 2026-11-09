# Fact 93fae2b8

Store id: 88af67e4-2050-4494-a817-0eacf16a5b5e

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
- posted_at: `2026-11-09T22:39:43.6398780+00:00`

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
  "id": "88af67e4-2050-4494-a817-0eacf16a5b5e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6398780+00:00"
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
  "subject_id": "c2398fe3-19a8-46f1-a0e0-755e865f2a3b",
  "subject_name": "django/db/models/fields/json::HasKeyLookup._combine_sql_parts",
  "tags": [
    "entity:method"
  ],
  "text": "def _combine_sql_parts(self, parts)"
}
```
