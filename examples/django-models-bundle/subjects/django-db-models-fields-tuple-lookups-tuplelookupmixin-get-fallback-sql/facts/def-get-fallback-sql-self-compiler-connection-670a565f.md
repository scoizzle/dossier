# Fact 670a565f

Store id: c48ff733-d6cb-49c4-a494-8da1a8cbca88

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
- posted_at: `2026-11-09T23:32:00.5761440+00:00`

## Data

```json
{
  "end_line": 133,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 129,
  "symbol": "TupleLookupMixin.get_fallback_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":129,"selector":"L129-L133","symbol":"TupleLookupMixin.get_fallback_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.get_fallback_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 133,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 129,
    "symbol": "TupleLookupMixin.get_fallback_sql"
  },
  "id": "c48ff733-d6cb-49c4-a494-8da1a8cbca88",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5761440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 129,
        "selector": "L129-L133",
        "symbol": "TupleLookupMixin.get_fallback_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f40ae415-21a8-47a3-ab70-09340e4edca1",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```
