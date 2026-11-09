# Fact 670a565f

Store id: 77868320-24db-48ae-b49b-d01a8b9cccc1

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
- posted_at: `2026-11-09T22:39:45.5876020+00:00`

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
  "id": "77868320-24db-48ae-b49b-d01a8b9cccc1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5876020+00:00"
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
  "subject_id": "a1513348-5fc6-403f-8a6c-4156ad88fed8",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```
