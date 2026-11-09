# Fact de84023e

Store id: a54258ad-a866-4d00-aeb2-900f3ec3b539

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
- posted_at: `2026-11-09T22:39:45.6090730+00:00`

## Data

```json
{
  "end_line": 216,
  "entity_kind": "method",
  "parent": "TupleGreaterThan",
  "start_line": 192,
  "symbol": "TupleGreaterThan.get_fallback_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":192,"selector":"L192-L216","symbol":"TupleGreaterThan.get_fallback_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleGreaterThan.get_fallback_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 216,
    "entity_kind": "method",
    "parent": "TupleGreaterThan",
    "start_line": 192,
    "symbol": "TupleGreaterThan.get_fallback_sql"
  },
  "id": "a54258ad-a866-4d00-aeb2-900f3ec3b539",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6090730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 192,
        "selector": "L192-L216",
        "symbol": "TupleGreaterThan.get_fallback_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c06ae71a-26e7-4f5c-ab88-276ad9d3c88f",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleGreaterThan.get_fallback_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fallback_sql(self, compiler, connection)"
}
```
