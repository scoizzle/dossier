# Fact 3233aaa6

Store id: 88de6f81-25fb-4907-b0ea-4c68be508346

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
- posted_at: `2026-11-09T23:44:52.7844260+00:00`

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
  "id": "88de6f81-25fb-4907-b0ea-4c68be508346",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7844260+00:00"
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
  "subject_id": "6e9838d6-fc21-47ec-9c70-71db0eb6d9ed",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThanOrEqual.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```
