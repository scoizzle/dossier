# Fact 3233aaa6

Store id: 4219f9ab-6e9a-441c-af25-82b7898afe90

## Text

```text
def get_fallback_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:00.6172200+00:00`

## Data

```json
{
  "end_line": 300,
  "entity_kind": "method",
  "parent": "TupleLessThanOrEqual",
  "start_line": 276,
  "symbol": "TupleLessThanOrEqual.get_fallback_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":276,"selector":"L276-L300","symbol":"TupleLessThanOrEqual.get_fallback_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLessThanOrEqual.get_fallback_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 300,
    "entity_kind": "method",
    "parent": "TupleLessThanOrEqual",
    "start_line": 276,
    "symbol": "TupleLessThanOrEqual.get_fallback_sql"
  },
  "id": "4219f9ab-6e9a-441c-af25-82b7898afe90",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6172200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 276,
        "selector": "L276-L300",
        "symbol": "TupleLessThanOrEqual.get_fallback_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e48be6d5-85c3-4971-af5c-031ac3a3dd9b",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThanOrEqual.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```
